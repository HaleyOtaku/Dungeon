﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonLibrary;

namespace DungeonApp
{
    internal class TestHarness
    {
        static void Main(string[] args)
        {
            //TODO Rename Things + Add Flavor
            //Fill in flavor for all monster descriptions (Use ChatGPT descriptions)
            //Change m1-4 names and descriptions and stats


            //Inventory
            //List or Enum or other holding option
            //Holds usable and non-usable objects
            //Give users option to use potions or equip looted weapons or original weapon if swapped out


            //Loot
            //1 Loot drop per monster battle
            //If want to equip it or use it (potion or weapon)?
            //If so, use now, or equip weapon now and put current weapon into inventory.
            //Ask if want to pick up
            //If so, want to put in inventory?
            //If not, get rid of it


            //Want to give player option to check out stats of weapon during initial picking and then determine whether or not to equip
            //originally selected weapon or choose another one.

            //player.equipweapon = lootedweapon



            // Jeremy Notes:

            //in inventory page of menu, after ask if wanna use, put (player.Life +=  ((Potion) item).PotionHealing)
            //Player.EquippedWeapon = (Weapon)item)
            //Remove from inventory after use
            //Inventory.RemoveAt(//playerChoiceAtInventoryPage)


            //cw("Are you sure? Y/N")
            //string response = Console.ReadKey(true).Key.ToString();
            //switch (response) { }




        }
    }


}


