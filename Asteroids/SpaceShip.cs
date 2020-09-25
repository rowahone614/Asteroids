using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids
{
    class SpaceShip
    {
        public int pointOneX;
        public int pointTwoX;
        public int pointThreeX;
        public int pointOneY;
        public int pointTwoY;
        public int pointThreeY;

        public SpaceShip(int _pointOneX, int _pointTwoX, int _pointThreeX, int _pointOneY, int _pointTwoY, int _pointThreeY)
        {
            pointOneX = _pointOneX;
            pointTwoX = _pointTwoX;
            pointThreeX = _pointThreeX;
            pointOneY = _pointOneY;
            pointTwoY = _pointTwoY;
            pointThreeY = _pointThreeY;
        }
    }
}
