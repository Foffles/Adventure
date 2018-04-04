using System;
using System.Collections.Generic;
using System.Text;

namespace Adventure.BusinessObjects
{
    public class Dungeon
    {
        Adventure.DataAbstraction.Dungeon dungeon;

        public Dungeon()
        {
            populateTutorialDungeon();
        }



        // This will go away and Dungeon() will be refactored when we have a database. Populates a tutorial dungeon.
        public void populateTutorialDungeon()
        {
            dungeon = new DataAbstraction.Dungeon();
            dungeon.Rooms = new DataAbstraction.Room[4];


            dungeon.Rooms[0].RoomId = 1;
            dungeon.Rooms[0].Sequence = 1;
            dungeon.Rooms[0].Name = "Intro Room 1";
            //dungeon.Rooms[0].WarriorRoomId = 1;
            //dungeon.Rooms[0].WarriorRoom.RoomId = 1;
            //dungeon.Rooms[0].WarriorRoom.WarriorRoomId = 1;
            //dungeon.Rooms[0].WarriorRoom.Enemies[0].Name = "Intro Room 1 - Enemy 1";
            //dungeon.Rooms[0].WarriorRoom.Enemies[0].Abilities[0].Name = "Intro Room 1 - Enemy 1 - Ability 1";
            //dungeon.Rooms[0].WarriorRoom.Enemies[0].Abilities[0].AbilityId = 1;

            dungeon.Rooms[1].RoomId = 2;
            dungeon.Rooms[1].Sequence = 2;
            dungeon.Rooms[1].Name = "Intro Room 2";
            //dungeon.Rooms[1].WarriorRoomId = 2;
            //dungeon.Rooms[1].WarriorRoom.RoomId = 2;
            //dungeon.Rooms[1].WarriorRoom.WarriorRoomId = 2;
            //dungeon.Rooms[1].WarriorRoom.Enemies[0].Name = "Intro Room 2 - Enemy 1";
            //dungeon.Rooms[1].WarriorRoom.Enemies[0].Abilities[0].Name = "Intro Room 2 - Enemy 1 - Ability 1";
            //dungeon.Rooms[1].WarriorRoom.Enemies[0].Abilities[0].AbilityId = 1;

            dungeon.Rooms[2].RoomId = 3;
            dungeon.Rooms[2].Sequence = 3;
            dungeon.Rooms[2].Name = "Intro Room 3";
            //dungeon.Rooms[2].WarriorRoomId = 3;
            //dungeon.Rooms[2].WarriorRoom.RoomId = 3;
            //dungeon.Rooms[2].WarriorRoom.WarriorRoomId = 3;
            //dungeon.Rooms[2].WarriorRoom.Enemies[0].Name = "Intro Room 3 - Enemy 1";
            //dungeon.Rooms[2].WarriorRoom.Enemies[0].Abilities[0].Name = "Intro Room 3 - Enemy 1 - Ability 1";
            //dungeon.Rooms[2].WarriorRoom.Enemies[0].Abilities[0].AbilityId = 1;

            dungeon.Rooms[3].RoomId = 4;
            dungeon.Rooms[3].Sequence = 4;
            dungeon.Rooms[3].Name = "Intro Room 4";
            //dungeon.Rooms[3].WarriorRoomId = 4;
            //dungeon.Rooms[3].WarriorRoom.RoomId = 4;
            //dungeon.Rooms[3].WarriorRoom.WarriorRoomId = 4;
            //dungeon.Rooms[3].WarriorRoom.Enemies[0].Name = "Intro Room 4 - Enemy 1";
            //dungeon.Rooms[3].WarriorRoom.Enemies[0].Abilities[0].Name = "Intro Room 4 - Enemy 1 - Ability 1";
            //dungeon.Rooms[3].WarriorRoom.Enemies[0].Abilities[0].AbilityId = 1;

        }


        public string Name
        {
            get
            {
                return dungeon.Name;
            }
        }
    }
}
