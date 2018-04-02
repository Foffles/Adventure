using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure.DataAbstraction
{
    public class Hero
    {
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

        int classId;
        public int ClassId
        {
            get
            {
                return this.classId;
            }
            set
            {
                this.classId = value;
            }
        }

        public string ClassName
        {
            get
            {
                switch (classId)
                {
                    case 1:
                        return "Warrior";
                    case 2:
                        return "Healer";
                    case 3:
                        return "Mage";
                    case 4:
                        return "Paladin";
                    case 5:
                        return "Rogue";
                    default:
                        return "Unknown";

                }
            }
        }

        int level;
        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                this.level = value;
            }
        }

    }
}
