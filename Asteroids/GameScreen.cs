using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Asteroids
{
    public partial class GameScreen : UserControl
    {

        // Rowan Honeywell
        // October 5th, 2020
        // Description: A basic game made to model the classic "Asteroids" video game

        public GameScreen()
        {
            InitializeComponent();

            // Resets all scores and counters

            SetParameters();
            gameLoop.Enabled = true;
        }

        // Global declarations

        // Boolean declarations

        Boolean spaceDown, cKeyDown;

        // List declarations

        List<Asteroids> asteroidList = new List<Asteroids>();
        List<Lazers> lazerList = new List<Lazers>();

        // Variable declaration for "Asteroids" class

        int asteroidSpeed = 3;
        int asteroidDirection;
        int asteroidSize = 10;
        int asteroidInterval = 50 - (5 * OptionsScreen.setStartingLevel);

        // Counter and score variables

        int frameCounter = 0;
        int totalFrameCounter = 0;
        int tickCounter = 51;
        int turnCounter = 0;
        int shotCounter = 51;
        int speedController = 0;
        int levelCounter = OptionsScreen.setStartingLevel;
        public static int playerScore = 0;

        // Variable declaration for "Lazers" class

        int lazerSpeed = 5;
        int lazerSize = 3;

        // Brush declaration

        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush blueBrush = new SolidBrush(Color.Cyan);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        SolidBrush greenBrush = new SolidBrush(Color.Lime);

        // Sound declaration

        SoundPlayer lazerBlast = new SoundPlayer(Properties.Resources.lazerBlast);
        SoundPlayer crashSound = new SoundPlayer(Properties.Resources.crashSound);
        SoundPlayer levelUpSound = new SoundPlayer(Properties.Resources.levelUpSound);

        // Random declaration

        Random rand = new Random();

        // Creates hitbox for ship

        Asteroids shipHitBox = new Asteroids(20, 240, 240, "Up");

        public void SetParameters()
        {

            // Variables to be reset when game restarts

            playerScore = 0;
            turnCounter = 0;
            totalFrameCounter = 0;
            asteroidSpeed = 5;
            asteroidSize = 10;
            levelUpLabel.Visible = false;
        }
        public void ControlShip()
        {

            // Controls the rotation of the ship

            if (frameCounter >= 4)
            {
                if (spaceDown)
                {
                    turnCounter++;
                }
                frameCounter = 0;
            }

            // shotCounter controls how often the player can shoot

            shotCounter++;

            // If the player presses "C" and a certain amount of time has passed 
            // since the last lazer was shot, a new Lazer is shot

            if (cKeyDown && shotCounter > 10)
            {
                if (OptionsScreen.setSoundOptions)
                {
                    lazerBlast.Play();
                }

                // shotCounter is reset
                
                shotCounter = 0;


                // Declares the direction which the Lazer travels

                switch (turnCounter)
                {
                    case 0:
                        Lazers newUpLazer = new Lazers(lazerSize, 250, 250, "Up");
                        lazerList.Add(newUpLazer);
                        break;
                    case 1:
                        Lazers newLeftLazer = new Lazers(lazerSize, 250, 250, "Left");
                        lazerList.Add(newLeftLazer);
                        break;
                    case 2:
                        Lazers newDownLazer = new Lazers(lazerSize, 250, 250, "Down");
                        lazerList.Add(newDownLazer);
                        break;
                    case 3:
                        Lazers newRightLazer = new Lazers(lazerSize, 250, 250, "Right");
                        lazerList.Add(newRightLazer);
                        break;
                }

            }

            // Controls how the Lazer moves

            foreach (Lazers l in lazerList)
            {
                if (l.direction == "Up")
                {
                    l.MoveUp(lazerSpeed);
                }
                else if (l.direction == "Left")
                {
                    l.MoveLeft(lazerSpeed);
                }
                else if (l.direction == "Down")
                {
                    l.MoveDown(lazerSpeed);
                }
                else if (l.direction == "Right")
                {
                    l.MoveRight(lazerSpeed);
                }
            }

            // If a Lazer moves off of the screen, the Lazer is removed from the list 

            if (lazerList.Count > 0 && (lazerList[0].lazerY >= this.Height || lazerList[0].lazerY <= 0 
                || lazerList[0].lazerX >= this.Width ||lazerList[0].lazerX <= 0))
            {
                lazerList.RemoveAt(0);
            }
        }

        public void AsteroidControl()
        {

            // If enough time has passed, a new asteroid is created

            if (tickCounter >= asteroidInterval)
            {

                // Randomizes where the asteroid spawns from

                asteroidDirection = rand.Next(1, 5);

                // Declares the direction that the asteroid will travel

                switch (asteroidDirection)
                {
                    case 1:
                        Asteroids newDownAsteroid = new Asteroids(asteroidSize, 245, 0, "Down");
                        asteroidList.Add(newDownAsteroid);
                        break;
                    case 2:
                        Asteroids newLeftAsteroid = new Asteroids(asteroidSize, 0, 245, "Right");
                        asteroidList.Add(newLeftAsteroid);
                        break;
                    case 3:
                        Asteroids newUpAsteroid = new Asteroids(asteroidSize, 245, 500, "Up");
                        asteroidList.Add(newUpAsteroid);
                        break;
                    case 4:
                        Asteroids newRightAsteroid = new Asteroids(asteroidSize, 500, 245, "Left");
                        asteroidList.Add(newRightAsteroid);
                        break;
                }
                tickCounter = 0;
            }

            // Controls how the Asteroid moves

            foreach (Asteroids a in asteroidList)
            {
                if (a.direction == "Up")
                {
                    a.MoveUp(asteroidSpeed);
                }
                else if (a.direction == "Left")
                {
                    a.MoveLeft(asteroidSpeed);
                }
                else if (a.direction == "Down")
                {
                    a.MoveDown(asteroidSpeed);
                }
                else if (a.direction == "Right")
                {
                    a.MoveRight(asteroidSpeed);
                }
                
            }

            // Checks for a collision between the Ship and an Asteroid

            foreach (Asteroids a in asteroidList)
            {
                if (shipHitBox.shipCollision(a))
                {

                    // Plays a sound effect

                    if (OptionsScreen.setSoundOptions)
                    {
                        crashSound.Play();
                    }

                    // Stops the game and switches to the GameOverScreen

                    gameLoop.Stop();

                    Form f = this.FindForm();
                    f.Controls.Remove(this);
                    GameOverScreen gs = new GameOverScreen();
                    f.Controls.Add(gs);
                    return;
                }
            }

            // Checks for a collision between a Lazer and an Asteroid

            foreach (Lazers l in lazerList)
            {
                foreach (Asteroids a in asteroidList)
                {
                    if (a.lazerCollision(l))
                    {
                        // Removes the Lazer and Asteroid that collided from their respective lists

                        playerScore++;                  
                        asteroidList.Remove(a);
                        lazerList.Remove(l);
                        return;
                    }
                }
            }
            
            // Controls the frequency of which Asteroids spawn

            if (speedController >= 500 && levelCounter < 8)
            {

                // Plays a sound effect

                if (OptionsScreen.setSoundOptions)
                {
                    levelUpSound.Play();
                }

                // The higher the level, the more frequently that Asteroids spawn

                levelCounter++;
                asteroidInterval -= 3;
                speedController = 0;
            }

            // Lets the user know that their level has increased

            levelUpLabel.Visible = false;
            if (speedController >= 0 && speedController <= 25 && levelCounter > 1 && totalFrameCounter > 200)
            {
                levelUpLabel.Visible = true;
            }
        }

        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            // Checks if the keys have been pressed

            switch (e.KeyCode)
            {
                case Keys.Space:
                    spaceDown = true;
                    break;
                case Keys.C:
                    cKeyDown = true;
                    break;
            }
        }

        private void GameScreen_KeyUp(object sender, KeyEventArgs e)
        {

            // Checks if the keys have been released

            switch (e.KeyCode)
            {
                case Keys.Space:
                    spaceDown = false;
                    break;
                case Keys.C:
                    cKeyDown = false;
                    break;
            }
        }

        private void gameLoop_Tick(object sender, EventArgs e)
        {

            // Prints the user's score and level

            levelLabel.Text = "Level : " + levelCounter;
            scoreLabel.Text = "Score : " + playerScore;

            // Goes through all methods that control the Ship and the Asteroids

            ControlShip();
            AsteroidControl();

            // Adds to all timers and counters

            frameCounter++;
            totalFrameCounter++;
            tickCounter++;
            speedController++;

            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            foreach (Asteroids a in asteroidList)
            {

                // Paints the Asteroids based on the colour that the user selected

                switch (OptionsScreen.setAsteroidColour)
                {
                    case 0:
                        e.Graphics.FillRectangle(redBrush, a.asteroidX, a.asteroidY, a.size, a.size);
                        break;
                    case 1:
                        e.Graphics.FillRectangle(blueBrush, a.asteroidX, a.asteroidY, a.size, a.size);
                        break;
                    case 2:
                        e.Graphics.FillRectangle(greenBrush, a.asteroidX, a.asteroidY, a.size, a.size);
                        break;
                    case 3:
                        e.Graphics.FillRectangle(yellowBrush, a.asteroidX, a.asteroidY, a.size, a.size);
                        break;
                }
            }

            // Paints the Lazers based on the colour that the user selected

            foreach (Lazers l in lazerList)
            {
                switch (OptionsScreen.setLazerColour)
                {
                    case 0:
                        e.Graphics.FillRectangle(redBrush, l.lazerX, l.lazerY, lazerSize, lazerSize);
                        break;
                    case 1:
                        e.Graphics.FillRectangle(blueBrush, l.lazerX, l.lazerY, lazerSize, lazerSize);
                        break;
                    case 2:
                        e.Graphics.FillRectangle(greenBrush, l.lazerX, l.lazerY, lazerSize, lazerSize);
                        break;
                    case 3:
                        e.Graphics.FillRectangle(yellowBrush, l.lazerX, l.lazerY, lazerSize, lazerSize);
                        break;
                }
            }

            // Draws the Ship based on every possible rotation and colour selected by the user

            Point[] shipTriangle = new Point[3];
            switch (turnCounter)
            {
                case 0:
                    shipTriangle[0] = new Point(250, 230);
                    shipTriangle[1] = new Point(240, 270);
                    shipTriangle[2] = new Point(260, 270);
                    switch (OptionsScreen.setShipColour)
                    {
                        case 0:
                            e.Graphics.FillPolygon(redBrush, shipTriangle);
                            break;
                        case 1:
                            e.Graphics.FillPolygon(blueBrush, shipTriangle);
                            break;
                        case 2:
                            e.Graphics.FillPolygon(greenBrush, shipTriangle);
                            break;
                        case 3:
                            e.Graphics.FillPolygon(yellowBrush, shipTriangle);
                            break;
                    }
                    break;
                case 1:
                    shipTriangle[0] = new Point(230, 250);
                    shipTriangle[1] = new Point(270, 260);
                    shipTriangle[2] = new Point(270, 240);
                    switch (OptionsScreen.setShipColour)
                    {
                        case 0:
                            e.Graphics.FillPolygon(redBrush, shipTriangle);
                            break;
                        case 1:
                            e.Graphics.FillPolygon(blueBrush, shipTriangle);
                            break;
                        case 2:
                            e.Graphics.FillPolygon(greenBrush, shipTriangle);
                            break;
                        case 3:
                            e.Graphics.FillPolygon(yellowBrush, shipTriangle);
                            break;
                    }
                    break;
                case 2:
                    shipTriangle[0] = new Point(250, 270);
                    shipTriangle[1] = new Point(260, 230);
                    shipTriangle[2] = new Point(240, 230);
                    switch (OptionsScreen.setShipColour)
                    {
                        case 0:
                            e.Graphics.FillPolygon(redBrush, shipTriangle);
                            break;
                        case 1:
                            e.Graphics.FillPolygon(blueBrush, shipTriangle);
                            break;
                        case 2:
                            e.Graphics.FillPolygon(greenBrush, shipTriangle);
                            break;
                        case 3:
                            e.Graphics.FillPolygon(yellowBrush, shipTriangle);
                            break;
                    }
                    break;
                case 3:
                    shipTriangle[0] = new Point(230, 240);
                    shipTriangle[1] = new Point(230, 260);
                    shipTriangle[2] = new Point(270, 250);
                    switch (OptionsScreen.setShipColour)
                    {
                        case 0:
                            e.Graphics.FillPolygon(redBrush, shipTriangle);
                            break;
                        case 1:
                            e.Graphics.FillPolygon(blueBrush, shipTriangle);
                            break;
                        case 2:
                            e.Graphics.FillPolygon(greenBrush, shipTriangle);
                            break;
                        case 3:
                            e.Graphics.FillPolygon(yellowBrush, shipTriangle);
                            break;
                    }
                    break;
                case 4:

                    // Sets the ship back to its primary orientation

                    turnCounter = 0;
                    break;
            }
        }
    }
}
