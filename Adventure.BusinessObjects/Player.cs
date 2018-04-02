using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure.BusinessObjects
{
    public class Player
    {
        Adventure.DataAbstraction.Player player;

        public Player()
        {
            player = new DataAbstraction.Player();
        }

        public void populatePlayer(string Name)
        {
            player.Name = Name;

        }
        
        public string Name {
            get
            {
                return player.Name;
            }
        }

    }
}
