using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure.DataAbstraction
{
    public class Hero
    {
        public static Dictionary<int, string> classNames = new Dictionary<int, string>() {
            { 1, "Warrior" },
            { 2, "Healer" },
            { 3, "Mage" },
            { 4, "Paladin" },
            { 5, "Rogue" }
        };

        int heroId;
        public int HeroId
        {
            get
            {
                return this.heroId;
            }
            set
            {
                this.heroId = value;
            }
        }

        int playerId;
        public int PlayerId
        {
            get
            {
                return this.playerId;
            }
            set
            {
                this.playerId = value;
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
                return classNames[classId];
            }
        }

        public Dictionary<int, string> ClassNames
        {
            get
            {
                return classNames;
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
