using System.Collections.Generic;
using Raylib_cs;

namespace Unit05.Game.Casting
{
    public class Alien : Actor
    {
        List<Actor> AlienList = new List<Actor>();
        List<int> killList = new List<int>();
        public Alien()
        {
            AddAliens();
        }

        private void AddAliens()
        {

            for (int i = 1; i <= 32; i++)
            {
                Actor alien = new Actor();
                if (i < 9)
                {
                    Point point = (new Point((i * 90) + Constants.CELL_SIZE, Constants.CELL_SIZE));
                    alien.SetPosition(point);
                    alien.SetText("<v>");
                    alien.SetColor(Constants.BLUE);
                }
                if (i > 8 && i < 17)
                {
                    Point point = (new Point(((i - 8) * 90) + Constants.CELL_SIZE, Constants.CELL_SIZE * 4));
                    alien.SetPosition(point);
                    alien.SetText("<v>");
                    alien.SetColor(Constants.GREEN);
                }
                if (i > 16 && i < 25)
                {
                    Point point = (new Point(((i - 16) * 90) + Constants.CELL_SIZE, Constants.CELL_SIZE * 8));
                    alien.SetPosition(point);
                    alien.SetText("<v>");
                    alien.SetColor(Constants.YELLOW);
                }
                if (i > 24)
                {
                    Point point = (new Point(((i - 24) * 90) + Constants.CELL_SIZE, Constants.CELL_SIZE * 12));
                    alien.SetPosition(point);
                    alien.SetText("<v>");
                    alien.SetColor(Constants.RED);
                }
                
                alien.SetVelocity(new Point(0, 5));
                this.AlienList.Add(alien);
            }

        }

        public List<Actor> GetAlienList()
        {
            return AlienList;
        }

        public List<int> GetKillList()
        {
            return killList;
        }
    }

}