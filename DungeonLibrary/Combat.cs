using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryLibrary;

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
                Console.WriteLine($"  {attacker.Name} hit {defender.Name} for {damage} damage!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"  {attacker.Name} missed!");
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

                Console.WriteLine($"\n  {player.Name} killed {monster.Name}!\n");
                Console.ResetColor();

                //To print
                Item item = Item.GetItems();
                bool repeat = false;
                do
                {
                    Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"\n  {monster.Name} dropped {item.Name}!\n");
                    Console.ResetColor();
   
                    Console.WriteLine($"\n  Would you like to pick up {item.Name}?\n\n  Y) Yes\n  N) No\n\n");
               
                    string choice = Console.ReadLine();

                        if (choice.ToLower() == "y")
                        {
                            player.AddItem(item);
                            Thread.Sleep(1000);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\n  {item.Name} added to inventory!");
                        Console.ResetColor();
                            repeat = false;
                        }
                        else if (choice.ToLower() == "n")
                        {
                            Thread.Sleep(3000);
                            Console.WriteLine($"\n  {item.Name} dropped!");
                            repeat = false;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("\n\n  You seem to have gotten lost, Hero! Try again!");
                            Thread.Sleep(2000);
                            Console.Clear();
                            repeat = true;
                        }

                } while (repeat == true);

                      
                Thread.Sleep(3000);

                Console.Clear();

                return true;//victory!! (monster is dead)
            }
        }
    }
}
