using Unit05.Game.Scripting;
using Unit05.Game.Casting;
using System.Collections.Generic;
using Raylib_cs;
using System;

namespace Unit05.Game.Scripting
{
    public class FireAlienBullet : Operation
    {
        Random rnd = new Random();
        public FireAlienBullet()
        {
        }
        public void Execute(Cast cast, Script script)
        {
            Alien aliens = (Alien)cast.GetFirstActor("Aliens");
            List<Actor> alienList = aliens.GetAlienList();
            Bullet bullet = (Bullet)cast.GetFirstActor("Bullet");
            

            foreach (Actor alien in alienList)
            {

                if (rnd.Next(300) == 0)
                {
                    bullet.AddAlienBullet(alien);
                }
            }
        }
    }
}