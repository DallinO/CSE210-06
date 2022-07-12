using System.Collections.Generic;
using Unit05.Game.Casting;
using Unit05.Game.Scripting;
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
            List<Actor> liveRounds = bullet.GetLiveRounds();
            List<int> deadRounds = bullet.GetDeadRounds();
            Alien aliens = (Alien)cast.GetFirstActor("Aliens");
            List<Actor> alienList = aliens.GetAlienList();
            List<int> killList = aliens.GetKillList();
            Score score = (Score)cast.GetFirstActor("Score");

            foreach (Actor alien in alienList)
            {
                foreach (Actor round in liveRounds)
                {
                    Point alienPosition = alien.GetPosition();
                    int apx = alienPosition.GetX();
                    int apy = alienPosition.GetY();

                    Point roundPosition = round.GetPosition();
                    int rpx = roundPosition.GetX();
                    int rpy = roundPosition.GetY();

                    if ((rpx >= apx && rpx <= apx + 15) && (rpy >= apy && rpy <= apy + 15))
                    {
                        score.AddPoint(100);
                        alien.SetText("");
                        alien.SetPosition(Constants.graveyard);
                        alien.SetVelocity(new Point(0, 0));

                        round.SetPosition(Constants.spentCasings);
                        round.SetVelocity(new Point(0, 0));

                    }
                    
                }

            }
        }
    }
}