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

        // Global integer declaration

        public int size, asteroidX, asteroidY;

        // Global string declaration

        public string direction;
        public Asteroids(int _size, int _asteroidX, int _asteroidY, string _direction)
        {

            // Defines Asteroid attributes

            size = _size;
            asteroidX = _asteroidX;
            asteroidY = _asteroidY;
            direction = _direction;
        }

        // Defines Asteroid moving behaviours
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


        // Declaration of collision between Asteroids and the Ship
        public Boolean shipCollision(Asteroids a)
        {
            Rectangle asteroidRec = new Rectangle(a.asteroidX, a.asteroidY, a.size, a.size);
            Rectangle shipRec = new Rectangle(asteroidX, asteroidY, size, size);

            // Returns whether or not the two objects have collided
            return asteroidRec.IntersectsWith(shipRec);
        }

        // Declaration of collision between Asteroids and Lazers
        public Boolean lazerCollision(Lazers l)
        {
            Rectangle lazerRec = new Rectangle(l.lazerX, l.lazerY, l.lazerSize, l.lazerSize);
            Rectangle asteroidRec = new Rectangle(asteroidX, asteroidY, size, size);

            // Returns whether or not the two objects have collided
            return asteroidRec.IntersectsWith(lazerRec);
        }
    }
}
