using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure.BusinessObjects
{
    public class Room
    {

        Adventure.DataAbstraction.Room room;


        public Room()
        {
            room = new DataAbstraction.Room();
        }

        public string Name
        {
            get
            {
                return room.Name;
            }
        }
    }
}
