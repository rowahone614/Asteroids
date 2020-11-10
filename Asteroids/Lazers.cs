using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids
{
    class Lazers
    {

        // Global integer declaration

        public int lazerSize, lazerY, lazerX;

        // Global string declaration

        public string direction;
        
        public Lazers(int _lazerSize, int _lazerY, int _lazerX, string _direction)
        {

            // Defines Lazer attributes

            lazerSize = _lazerSize;
            lazerY = _lazerY;
            lazerX = _lazerX;
            direction = _direction;
        }

        // Declares Lazer moving behaviours
        public void MoveDown(int lazerSpeed)
        {
            lazerY += lazerSpeed;
        }
        public void MoveUp(int lazerSpeed)
        {
            lazerY -= lazerSpeed;
        }
        public void MoveLeft(int lazerSpeed)
        {
            lazerX -= lazerSpeed;
        }
        public void MoveRight(int lazerSpeed)
        {
            lazerX += lazerSpeed;
        }
    }
}
