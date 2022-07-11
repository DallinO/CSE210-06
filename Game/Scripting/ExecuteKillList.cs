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
    public class ExecuteKillList : Action
    {
        public  ExecuteKillList()
        {
        }
        public void Execute(Cast cast, Script script)
        {
            Alien aliens = (Alien)cast.GetFirstActor("Aliens");
            List<Actor> alienList = aliens.GetAlienList();
            KillList killList = (KillList)cast.GetFirstActor("Aliens");
            List<int> alienIndexes = killList.GetKillList();
            
            foreach(int index in alienIndexes)
            {
                alienList.Remove(alienList[index]);
                
            }

            killList.ResetList();
        }
    }
}