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
        public GameScreen()
        {
            InitializeComponent();
            SetParameters();
            gameLoop.Enabled = true;
        }
        //Global Variables
        Boolean spaceDown, cKeyDown;

        List<Asteroids> asteroidList = new List<Asteroids>();
        List<Lazers> lazerList = new List<Lazers>();

        int asteroidSpeed = 3;
        int asteroidDirection;
        int asteroidSize = 10;
        int asteroidInterval = 75 - (5 * (OptionsScreen.setStartingLevel - 1));

        int frameCounter = 0;
        int tickCounter = 51;
        int turnCounter = 0;
        int shotCounter = 51;
        int speedController = 0;
        int levelCounter = OptionsScreen.setStartingLevel;

        int lazerSpeed = 5;
        int lazerSize = 3;

        SolidBrush redBrush = new SolidBrush(Color.Red);
        SolidBrush blueBrush = new SolidBrush(Color.Cyan);
        SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
        SolidBrush greenBrush = new SolidBrush(Color.Lime);

        SoundPlayer lazerBlast = new SoundPlayer(Properties.Resources.lazerBlast);
        SoundPlayer crashSound = new SoundPlayer(Properties.Resources.crashSound);
        Random rand = new Random();

        Asteroids shipHitBox = new Asteroids(20, 240, 240, "Up");

        public void SetParameters()
        {
            turnCounter = 0;
            asteroidSpeed = 5;
            asteroidSize = 10;
        }
        public void ControlShip()
        {
            if (frameCounter >= 4)
            {
                if (spaceDown)
                {
                    turnCounter++;
                }
                frameCounter = 0;
            }
            shotCounter++;
            if (cKeyDown && shotCounter > 10)
            {
                lazerBlast.Play();
                shotCounter = 0;

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

            if (lazerList.Count > 0 && (lazerList[0].lazerY >= this.Height || lazerList[0].lazerY <= 0 
                || lazerList[0].lazerX >= this.Width ||lazerList[0].lazerX <= 0))
            {
                lazerList.RemoveAt(0);
            }
        }

        public void AsteroidControl()
        {

            if (tickCounter >= asteroidInterval)
            {
                asteroidDirection = rand.Next(1, 5);

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

            foreach (Asteroids a in asteroidList)
            {
                if (shipHitBox.shipCollision(a))
                {
                    crashSound.Play();
                    gameLoop.Stop();

                    Form f = this.FindForm();
                    f.Controls.Remove(this);
                    GameOver go = new GameOver();
                    f.Controls.Add(go);
                    return;
                }
            }

            foreach (Lazers l in lazerList)
            {
                foreach (Asteroids a in asteroidList)
                {
                    if (a.lazerCollision(l))
                    {
                        asteroidList.Remove(a);
                        lazerList.Remove(l);
                        return;
                    }
                }
            }

            if (speedController >= 500 && asteroidInterval > 30)
            {
                levelCounter++;
                asteroidInterval -= 3;
                speedController = 0;
            }
        }
        private void GameScreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            //player 1 button presses
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
            //player 1 button releases
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
            levelLabel.Text = "Level : " + levelCounter;
            ControlShip();
            AsteroidControl();
            frameCounter++;
            tickCounter++;
            speedController++;
            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {

            foreach (Asteroids a in asteroidList)
            {
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
            Point[] triangle = new Point[3];
            switch (turnCounter)
            {
                case 0:
                    triangle[0] = new Point(250, 230);
                    triangle[1] = new Point(240, 270);
                    triangle[2] = new Point(260, 270);
                    switch (OptionsScreen.setShipColour)
                    {
                        case 0:
                            e.Graphics.FillPolygon(redBrush, triangle);
                            break;
                        case 1:
                            e.Graphics.FillPolygon(blueBrush, triangle);
                            break;
                        case 2:
                            e.Graphics.FillPolygon(greenBrush, triangle);
                            break;
                        case 3:
                            e.Graphics.FillPolygon(yellowBrush, triangle);
                            break;
                    }
                    break;
                case 1:
                    triangle[0] = new Point(230, 250);
                    triangle[1] = new Point(270, 260);
                    triangle[2] = new Point(270, 240);
                    switch (OptionsScreen.setShipColour)
                    {
                        case 0:
                            e.Graphics.FillPolygon(redBrush, triangle);
                            break;
                        case 1:
                            e.Graphics.FillPolygon(blueBrush, triangle);
                            break;
                        case 2:
                            e.Graphics.FillPolygon(greenBrush, triangle);
                            break;
                        case 3:
                            e.Graphics.FillPolygon(yellowBrush, triangle);
                            break;
                    }
                    break;
                case 2:
                    triangle[0] = new Point(250, 270);
                    triangle[1] = new Point(260, 230);
                    triangle[2] = new Point(240, 230);
                    switch (OptionsScreen.setShipColour)
                    {
                        case 0:
                            e.Graphics.FillPolygon(redBrush, triangle);
                            break;
                        case 1:
                            e.Graphics.FillPolygon(blueBrush, triangle);
                            break;
                        case 2:
                            e.Graphics.FillPolygon(greenBrush, triangle);
                            break;
                        case 3:
                            e.Graphics.FillPolygon(yellowBrush, triangle);
                            break;
                    }
                    break;
                case 3:
                    triangle[0] = new Point(230, 240);
                    triangle[1] = new Point(230, 260);
                    triangle[2] = new Point(270, 250);
                    switch (OptionsScreen.setShipColour)
                    {
                        case 0:
                            e.Graphics.FillPolygon(redBrush, triangle);
                            break;
                        case 1:
                            e.Graphics.FillPolygon(blueBrush, triangle);
                            break;
                        case 2:
                            e.Graphics.FillPolygon(greenBrush, triangle);
                            break;
                        case 3:
                            e.Graphics.FillPolygon(yellowBrush, triangle);
                            break;
                    }
                    break;
                case 4:
                    turnCounter = 0;
                    break;
            }
        }
    }
}
