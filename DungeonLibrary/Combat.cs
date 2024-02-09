using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonLibrary
{
    public class Combat
    {
        //not a datatype class, just a method warehouse.

        //let's create a method to handle one side of the attack

        public static void DoAttack(Character attacker, Character defender) {
        
             //find the adjusted hit chance:
             int chance = attacker.CalcHitChance()-defender.CalcDodge();

            //get a random number from 1-100
            int roll = new Random().Next(1,101);

            //To slow the program and make the user think something is happening, we can
            //tell the thread to sleep. (System.Threading)

            //TODO : Use this pause to make the monster have a grand entrance before beginning the fight
            Thread.Sleep(500);

            //the attacker "Hits" if the roll is less than the adjusted hit chance.
            if (roll < chance)
            {
                //Calculate the damage
                int damage = attacker.CalcDamage();

                //Subtract the damage from the defender's life

                defender.Life -= damage;// (+=) would heal them 
                //TODO : Use this logic to make a healing potion work

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{attacker.Name} hit {defender.Name} for {damage} damage!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{attacker.Name} missed!");
                Console.ResetColor();
            }


        }

        public static bool DoBattle(Player player, Monster monster) //tells the console if the monster is dead
        {
            #region Potential Expansions
            //Initiative property on the Character class
            //if (player.initiative >= monster.Initiative)
            //could change who attacks first


            //Racial or Weapon Bonus
            //Could give Harengon two attacks as a racial bonus, see structure below
            //If (player.PlayerRace == Race.Harengon) {DoAttack(player,monster)}
            #endregion

            DoAttack(player, monster);
            //if the monster is still alive, they get to attack.
            if (monster.Life > 0)
            {
                DoAttack(monster, player);
                return false; //we did not kill the monster
            }
            else 
            {

                //TODO : Call a Loot or Inventory Class, Randomly Drop from a List
                //Q: What class to put a loot or inventory class? Player and Monster classes? Character?
                //Make new classes for each and call them appropriately in either player or monster?

                #region Potential Expansion - Combat Rewards
                //you could add logic here to grant player life.
                //player.Life += player.MaxLife / 10


                //Item class - name of item 
                //Item rubyNecklace = new Item("Ruby Necklace", "Increases Max Life", "Max Life", 10);
                //press I to access inventory
                //weapons and potions are easier than equipment

                //Player would have property "inventory" List of item called inventory
                //Monster could have one as well if they drop loot.
                //Player has a List<Item> Inventory
                //player.Inventory.Add(rubyNecklace);

                //int coins = new Random().Next(1,11);

                //TODO: Give Character Class an Inventory
                //Might put inventory in Character class so that players and monsters both have one
                #endregion

                player.Score++;
                Console.ForegroundColor= ConsoleColor.Green;

                Console.WriteLine($"\nYou killed {monster.Name}!\n");
                Console.ResetColor();
                return true;//victory!! (monster is dead)
            }
        }
    }
}
