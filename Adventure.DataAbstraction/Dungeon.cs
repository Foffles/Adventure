using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure.DataAbstraction
{
    public class Dungeon
    {
        Room[] rooms;
        public Room[] Rooms
        {
            get
            {
                return this.rooms;
            }
            set
            {
                this.rooms = value;
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

        string introText;
        public string IntroText
        {
            get
            {
                return this.introText;
            }
            set
            {
                this.introText = value;
            }
        }
    }
}
