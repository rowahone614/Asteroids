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
        public int lazerSize, lazerY, lazerX;
        public string direction;
        
        public Lazers(int _lazerSize, int _lazerY, int _lazerX, string _direction)
        {
            lazerSize = _lazerSize;
            lazerY = _lazerY;
            lazerX = _lazerX;
            direction = _direction;
        }
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
