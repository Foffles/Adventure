using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure.DataAbstraction
{
    class WarriorRoom
    {
        int warriorRoomId;
        public int WarriorRoomId
        {
            get
            {
                return this.warriorRoomId;
            }
            set
            {
                this.warriorRoomId = value;
            }
        }

        int roomId;
        public int RoomId
        {
            get
            {
                return this.roomId;
            }
            set
            {
                this.roomId = value;
            }
        }
    }
}
