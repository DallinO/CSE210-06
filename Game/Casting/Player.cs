using System.Collections.Generic;
using Raylib_cs;

namespace Unit05.Game.Casting
{
    public class Player : Actor
    {
        int lives = 3;
        public Player()
        {
        }

        public void SetLives(int input)
        {
            lives = lives - input;
        }

        public int GetLives()
        {
            return lives;
        }

    }

}