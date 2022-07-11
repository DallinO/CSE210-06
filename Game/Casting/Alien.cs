using System.Collections.Generic;
using Raylib_cs;

namespace Unit05.Game.Casting
{
    public class Alien : Actor
    {
        List<Actor> AlienList = new List<Actor>();
        public Alien()
        {
            AddAliens();
        }

        private void AddAliens()
        {

            for (int i = 1; i < 17; i++)
            {
                Actor alien = new Actor();
                if (i < 9)
                {
                    Point point = (new Point((i * 90) + Constants.CELL_SIZE, Constants.CELL_SIZE));
                    alien.SetPosition(point);
                }
                if (i >= 9)
                {
                    Point point = (new Point(((i - 8) * 90) + Constants.CELL_SIZE, Constants.CELL_SIZE * 4));
                    alien.SetPosition(point);
                }
                
                alien.SetText("<V>");
                alien.SetColor(Color.GREEN);
                alien.SetVelocity(new Point(0, 5));
                this.AlienList.Add(alien);
            }

        }

        public List<Actor> GetAlienList()
        {
            return AlienList;
        }
    }

}