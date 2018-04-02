using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure.DataAbstraction
{
    public class Player
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
    }
}
