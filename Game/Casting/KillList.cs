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
    public class KillList : Alien
    {
        List<int> killList = new List<int>();
        public  KillList()
        {
        }

        public List<int> GetKillList()
        {
            return killList;
        }

        public void ResetList()
        {
            killList = new List<int>();
        }
    }
}