using Unit05.Game.Casting;
using System.Collections.Generic;
using Raylib_cs;
using System;


namespace Unit05.Game.Casting
{
    class Bullet : Actor
    {
        List<Actor> LiveRounds = new List<Actor>();
        public Bullet()
        {

        }


        public void AddBullet(Player player, bool roundFired)
        {
            Bullet bullet = new Bullet();
                bullet.SetText("*");
                bullet.SetPosition(player.GetPosition());
                bullet.SetVelocity(new Point(0, -15));
                bullet.SetColor(Raylib_cs.Color.RED);
                LiveRounds.Add(bullet);
        }

        public void RemoveBullet(List<Actor> roundList)
        {
            foreach (Actor round in roundList)
            {
                Point bulletPosition = round.GetPosition();
                if (bulletPosition.GetY() < 15)
                {
                    round.SetText("");
                }
            }

        }

        public List<Actor> GetLiveRounds()
        {
            return LiveRounds;
        }
    }
}