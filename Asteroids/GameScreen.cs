using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        List<Asteroids> downAsteroidList = new List<Asteroids>();
        List<Asteroids> upAsteroidList = new List<Asteroids>();
        List<Asteroids> rightAsteroidList = new List<Asteroids>();
        List<Asteroids> leftAsteroidList = new List<Asteroids>();
        List<Lazers> lazerList = new List<Lazers>();

        int asteroidSpeed = 3;
        int asteroidDirection;
        int asteroidSize = 10;

        int frameCounter = 0;
        int tickCounter = 0;
        int turnCounter = 0;

        int lazerSpeed = 5;
        int lazerSize = 3;

        SolidBrush shipBrush = new SolidBrush(Color.White);
        SolidBrush asteroidBrush = new SolidBrush(Color.Red);
        SolidBrush lazerBrush = new SolidBrush(Color.Cyan);

        Random rand = new Random();

        public void SetParameters()
        {
            Asteroids newAsteroid = new Asteroids(asteroidSize, 245, 0);

            downAsteroidList.Add(newAsteroid);

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
            if (cKeyDown)
            {
                Lazers newLazer = new Lazers(lazerSize, 250, 250);

                lazerList.Add(newLazer);

                foreach (Lazers l in lazerList)
                {
                    switch (turnCounter)
                    {
                             case 0:
                             
                        
                    }
                }
                

            }
        }

        public void AsteroidControl()
        {
            foreach(Asteroids a in downAsteroidList)
            {
                a.MoveDown(asteroidSpeed);
            }
            foreach(Asteroids a in leftAsteroidList)
            {
                a.MoveRight(asteroidSpeed);
            }
            foreach (Asteroids a in upAsteroidList)
            {
                a.MoveUp(asteroidSpeed);
            }
            foreach (Asteroids a in rightAsteroidList)
            {
                a.MoveLeft(asteroidSpeed);
            }
            if (tickCounter >= 75)
            {
                asteroidDirection = rand.Next(1, 5);

                switch (asteroidDirection)
                {
                    case 1:
                        Asteroids newDownAsteroid = new Asteroids(asteroidSize, 245, 0);
                        downAsteroidList.Add(newDownAsteroid);
                        break;
                    case 2:
                        Asteroids newLeftAsteroid = new Asteroids(asteroidSize, 0, 245);
                        leftAsteroidList.Add(newLeftAsteroid);
                        break;
                    case 3:
                        Asteroids newUpAsteroid = new Asteroids(asteroidSize, 245, 500);
                        upAsteroidList.Add(newUpAsteroid);
                        break;
                    case 4:
                        Asteroids newRightAsteroid = new Asteroids(asteroidSize, 500, 245);
                        rightAsteroidList.Add(newRightAsteroid);
                        break;
                }

                tickCounter = 0;
            }

            if (downAsteroidList.Count > 0 && downAsteroidList[0].asteroidY >= 450)
            {
                downAsteroidList.RemoveAt(0);
            }
            else if (leftAsteroidList.Count > 0 && leftAsteroidList[0].asteroidX >= 450)
            {
                leftAsteroidList.RemoveAt(0);
            }
            else if (upAsteroidList.Count > 0 && upAsteroidList[0].asteroidY <= 50)
            {
                upAsteroidList.RemoveAt(0);
            }
            else if (rightAsteroidList.Count > 0 && rightAsteroidList[0].asteroidX <= 50)
            {
                rightAsteroidList.RemoveAt(0);
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
            ControlShip();
            AsteroidControl();
            frameCounter++;
            tickCounter++;
            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {

            foreach (Asteroids a in downAsteroidList.Union(leftAsteroidList).Union(upAsteroidList).Union(rightAsteroidList))
            {
                e.Graphics.FillRectangle(asteroidBrush, a.asteroidX, a.asteroidY, a.size, a.size);
            }
            foreach (Lazers l in lazerList)
            {
                e.Graphics.FillRectangle(lazerBrush, l.lazerX, l.lazerY, lazerSize, lazerSize);
            }
            Point[] triangle = new Point[3];
            switch (turnCounter)
            {
                case 0:
                    triangle[0] = new Point(250, 230);
                    triangle[1] = new Point(240, 270);
                    triangle[2] = new Point(260, 270);
                    e.Graphics.FillPolygon(shipBrush, triangle);
                    break;
                case 1:
                    triangle[0] = new Point(230, 250);
                    triangle[1] = new Point(270, 260);
                    triangle[2] = new Point(270, 240);
                    e.Graphics.FillPolygon(shipBrush, triangle);
                    break;
                case 2:
                    triangle[0] = new Point(250, 270);
                    triangle[1] = new Point(260, 230);
                    triangle[2] = new Point(240, 230);
                    e.Graphics.FillPolygon(shipBrush, triangle);
                    break;
                case 3:
                    triangle[0] = new Point(230, 240);
                    triangle[1] = new Point(230, 260);
                    triangle[2] = new Point(270, 250);
                    e.Graphics.FillPolygon(shipBrush, triangle);
                    break;
                case 4:
                    turnCounter = 0;
                    break;
            }
        }
    }
}
