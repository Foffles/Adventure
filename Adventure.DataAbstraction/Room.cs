using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure.DataAbstraction
{
    public class Room
    {
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

        WarriorRoom warriorRoom;
        public WarriorRoom WarriorRoom
        {
            get
            {
                return this.warriorRoom;
            }
            set
            {
                this.warriorRoom = value;
            }
        }

        string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        int sequence;
        public int Sequence
        {
            get
            {
                return this.sequence;
            }
            set
            {
                this.sequence = value;
            }
        }

    }
}
