using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure.DataAbstraction
{
    public class Ability
    {
        int abilityId;
        public int AbilityId
        {
            get
            {
                return this.abilityId;
            }
            set
            {
                this.abilityId = value;
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
