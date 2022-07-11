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
            List<Actor> roundList = bullet.GetLiveRounds();
            KillList aliens = (KillList)cast.GetFirstActor("Aliens");
            List<Actor> alienList = aliens.GetAlienList();
            List<int> killList = aliens.GetKillList();
            int alienListLength = 0;

            foreach (Actor alien in alienList)
            {
                alienListLength = alienListLength + 1;
            }

            for(int i = 0; i < alienListLength; i++)
            {
                foreach (Actor round in roundList)
                {
                    Point alienPosition = alienList[i].GetPosition();
                    int apx = alienPosition.GetX();
                    int apy = alienPosition.GetY();

                    Point roundPosition = round.GetPosition();
                    int rpx = roundPosition.GetX();
                    int rpy = roundPosition.GetY();

                    if ((rpx >= apx && rpx <= apx + 30) && (rpy >= apy && rpy <= apy + 30))
                    {
                        Color alienColor = alienList[i].GetColor();
                        int r = alienColor.GetRed();
                        int g = alienColor.GetGreen();
                        int b = alienColor.GetBlue();

                        if(g == 255)
                        {
                            if(r == 255)
                            {
                                alienList[i].SetColor(Constants.RED);
                            }
                            else
                            {
                                alienList[i].SetColor(Constants.YELLOW);
                            }
                        }
                        else
                        {
                            killList.Add(i);
                        }
                    }
                }
            }
        }
    }
}