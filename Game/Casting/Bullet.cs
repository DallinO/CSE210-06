using Unit05.Game.Casting;
using System.Collections.Generic;

namespace Unit05.Game.Casting
{
    class Bullet : Actor
    {
        List<Actor> LiveRounds = new List<Actor>();
        public Bullet()
        {

        }

        public void AddBullet(Player player)
        {
            Bullet bullet = new Bullet();
            bullet.SetText("*");
            bullet.SetPosition(player.GetPosition());
            bullet.SetVelocity(new Point(0, 15));
            bullet.SetColor(Raylib_cs.Color.GREEN);
            LiveRounds.Add(bullet);
        }

        public List<Actor> GetLiveRounds()
        {
            return LiveRounds;
        }
    }
}