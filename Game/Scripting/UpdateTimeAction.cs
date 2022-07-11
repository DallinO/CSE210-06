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
    public class UpdateTimeAction : Action
    {
        /// <summary>
        /// Constructs a new instance of MoveActorsAction.
        /// </summary>
        public UpdateTimeAction()
        {
        }

        /// <inheritdoc/>
        public void Execute(Cast cast, Script script)
        {
            Time time = (Time)cast.GetFirstActor("Time");
            double elapsedTime = Math.Round(Raylib.GetTime(), 3);
            time.SetText(elapsedTime.ToString());
        }
    }
}