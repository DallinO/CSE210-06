using Unit05.Game.Services;
using Unit05.Game.Directing;
using Unit05.Game.Casting;
using Unit05.Game.Scripting;
using System.Collections.Generic;
using Unit05.Game;



namespace Unit05
{
    /// <summary>
    /// The program's entry point.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Cast cast = new Cast();
            // Create Player
            cast.AddActor("Player", new Player());
            Player player = (Player)cast.GetFirstActor("Player");
            player.SetPosition(new Point(435, 570));
            player.SetColor(new Color(0, 255, 0));
            player.SetText("<^>" );
            // Creat Aliens
            cast.AddActor("Aliens", new KillList());
            // Create Time Display
            cast.AddActor("Time", new Time());
            Actor time = cast.GetFirstActor("Time");
            time.SetPosition(new Point(800, 15));
            time.SetColor(Constants.WHITE);
            // Create Bullet
            cast.AddActor("Bullet", new Bullet());
            Bullet bullet = (Bullet)cast.GetFirstActor("Bullet");

            KeyboardService keyboardService = new KeyboardService();
            VideoService videoService = new VideoService(false);

            Script script = new Script();
            script.AddAction("input", new ControlActorsAction(keyboardService, player));
            script.AddAction("update", new MoveActorsAction());
            script.AddAction("update", new UpdateTimeAction());
            script.AddAction("update", new HandleBulletCollision());
            script.AddAction("update", new ExecuteKillList());
            script.AddAction("output", new DrawActorsAction(videoService));

            Director director = new Director(videoService);
            director.StartGame(cast, script);
            
            
        }
    }
}