using System.Collections.Generic;
using Unit05.Game.Casting;
using Unit05.Game.Services;
using Raylib_cs;
using System;


namespace Unit05.Game.Scripting
{
    /// <summary>
    /// <para>An update action that moves all the actors.</para>
    /// <para>
    /// The responsibility of MoveActorsAction is to move all the actors.
    /// </para>
    /// </summary>
    public class HandleBulletCollision : Action
    {
        /// <summary>
        /// Constructs a new instance of MoveActorsAction.
        /// </summary>
        public HandleBulletCollision()
        {
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            Bullet bullet = (Bullet)cast.GetFirstActor("Bullet");
            List<Actor> roundList = bullet.GetLiveRounds();
            Alien aliens = (Alien)cast.GetFirstActor("Aliens");
            List<Actor> alienList = aliens.GetAlienList();

            foreach (Actor alien in alienList)
            {
                foreach (Actor round in roundList)
                {
                    if (alien.GetPosition().Equals(round.GetPosition()))
                    {
                        alien.SetText("");
                    }
                }
            }
        }
    }
}