using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids
{
    class Lazers
    {
        public int lazerSize, lazerY, lazerX;
        
        public Lazers(int _lazerSize, int _lazerY, int _lazerX)
        {
            lazerSize = _lazerSize;
            lazerY = _lazerY;
            lazerX = _lazerX;
        }
        public void MoveDown(int lazerSpeed)
        {
            lazerY += lazerSpeed;
        }
    }
}
