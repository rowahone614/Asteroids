using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asteroids
{
    class Asteroids
    {
        public int size, asteroidX, asteroidY;
        public string direction;
        public Asteroids(int _size, int _asteroidX, int _asteroidY, string _direction)
        {
            size = _size;
            asteroidX = _asteroidX;
            asteroidY = _asteroidY;
            direction = _direction;
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

        public Boolean shipCollision(Asteroids a)
        {
            Rectangle asteroidRec = new Rectangle(a.asteroidX, a.asteroidY, a.size, a.size);
            Rectangle shipRec = new Rectangle(asteroidX, asteroidY, size, size);

            return asteroidRec.IntersectsWith(shipRec);
        }
        public Boolean lazerCollision(Lazers l)
        {
            Rectangle lazerRec = new Rectangle(l.lazerX, l.lazerY, l.lazerSize, l.lazerSize);
            Rectangle asteroidRec = new Rectangle(asteroidX, asteroidY, size, size);

            return asteroidRec.IntersectsWith(lazerRec);
        }
    }
}
