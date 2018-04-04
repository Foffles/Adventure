using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure.DataAbstraction
{
    public class Enemy
    {
        int enemyId;
        public int EnemyId
        {
            get
            {
                return this.enemyId;
            }
            set
            {
                this.enemyId = value;
            }
        }

        Ability[] abilities;
        public Ability[] Abilities
        {
            get
            {
                return this.abilities;
            }
            set
            {
                this.abilities = value;
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

    }
}
