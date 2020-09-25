using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asteroids
{
    class Asteroids
    {
        public int size, asteroidX, asteroidY;

        public Asteroids(int _size, int _asteroidX, int _asteroidY)
        {
            size = _size;
            asteroidX = _asteroidX;
            asteroidY = _asteroidY;
        }

        public void MoveDown(int asteroidSpeed)
        {
            asteroidY += asteroidSpeed;
        }
        public void MoveUp(int asteroidSpeed)
        {
            asteroidY -= asteroidSpeed;
        }
        public void MoveLeft(int asteroidSpeed)
        {
            asteroidX -= asteroidSpeed;
        }
        public void MoveRight(int asteroidSpeed)
        {
            asteroidX += asteroidSpeed;
        }
    }
}
