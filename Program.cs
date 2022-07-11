using Unit05.Game.Services;
using Unit05.Game.Directing;
using Unit05.Game.Casting;
using Unit05.Game.Scripting;
using System.Collections.Generic;
using Unit05.Game;
using Raylib_cs;



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
            cast.AddActor("Player", new Player());
            Player player = (Player)cast.GetFirstActor("Player");
            player.SetPosition(new Point(435, 570));
            player.SetColor(Raylib_cs.Color.GREEN);
            player.SetText("<^>" );

            KeyboardService keyboardService = new KeyboardService();
            VideoService videoService = new VideoService(false);

            Script script = new Script();
            script.AddAction("input", new ControlActorsAction(keyboardService));
            script.AddAction("update", new MoveActorsAction());
            //script.AddAction("update", new HandleCollisionsAction());
            script.AddAction("output", new DrawActorsAction(videoService));

            Director director = new Director(videoService);
            director.StartGame(cast, script);
            
            
        }
    }
}