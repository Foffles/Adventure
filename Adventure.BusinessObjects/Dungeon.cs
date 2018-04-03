using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure.BusinessObjects
{
    public class Dungeon
    {
        Adventure.DataAbstraction.Dungeon dungeon;
        Adventure.DataAbstraction.Room[] rooms;

        public Dungeon()
        {
            dungeon = new DataAbstraction.Dungeon();
            rooms = new DataAbstraction.Room[1];
        }


        public string Name
        {
            get
            {
                return dungeon.Name;
            }
        }
    }
}
