using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure.BusinessObjects
{
    public class Hero
    {
        Adventure.DataAbstraction.Hero hero;

        public Hero ()
        {
            hero = new DataAbstraction.Hero();
        }

        public void populateHero(string Name, int ClassId)
        {
            hero.Name = Name;
            hero.ClassId = ClassId;
            hero.Level = 1;
        }


        public override string ToString()
        {
            return "\n****************************" 
                + "\nHero: " + hero.Name 
                + "\nClass: " + hero.ClassName
                + "\nLevel: " + hero.Level
                + "\n****************************\n";
        }

        public string Name
        {
            get
            {
                return hero.Name;
            }
        }

        public int ClassId
        {
            get
            {
                return hero.ClassId;
            }
        }

        public string ClassName
        {
            get
            {
                return hero.ClassName;
            }
        }

        public Dictionary<int, string> ClassNames
        {
            get
            {
                return hero.ClassNames;
            }
        }

        public int Level
        {
            get
            {
                return hero.Level;
            }
        }
    }
}
