using DungeonLibrary;
using System;

namespace DungeonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Title/Introduction
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n  Your Journey Begins!\n");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine
                   ("         | _______________________\n" +
                    "   () ===| _______________________ >\n" +
                    "         |\n\n");
            Console.ResetColor();
            #endregion


            #region Player Set Up
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("  ****** CHARACTER CREATION ******\n");
            Console.ResetColor();

            #region Character Name Assignment
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("  Please enter your character name: ");
            Console.ResetColor();
            string playerName = Console.ReadLine();
            #endregion
            Console.Clear();

            #region Race Selection
            List<Race> race = Enum.GetValues<Race>().ToList();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n\n  Please Select Your Character's Race: \n");
            Console.ResetColor();
            int index1 = 1;
            foreach (Race item in race)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"  {index1++}) {item}");
                Console.ResetColor();

            }
            Console.WriteLine();
            int.TryParse(Console.ReadLine(), out int choice);
            //from the collection
            Race playerRace = (Race)(choice - 1);
            #endregion
            Console.Clear();

            #region Weapon Selection
            //TODONE Let them choose a weapon.
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"\n\n  Please Select Your Weapon: \n");
            Console.ResetColor();

            Weapon playerWeapon = (Weapon.GetWeapon());

            #endregion
            Console.Clear();

            Player player = new Player(playerName, 40, 5, 70, playerRace, playerWeapon);

            #endregion

            #region Main Game Loop
            bool exit = false;//if true, quit the whole game

            do
            {
                string room = GetRoom(out int index);//generate a room
                Console.WriteLine(room);
                Monster monster = new();


                if (index == 0 || index == 1 || index == 2)
                {
                    monster = Monster.GetMonster(); //generates a monster
                }
                else if (index == 3 || index == 4 || index == 5)
                {
                    monster = Dragon.GetDragon(); //generates a dragon

                }
                else if (index == 6 || index == 7 || index == 8)
                {
                    monster = Skeleton.GetSkeleton(); //generates a skeleton
                    
                }
                else
                {
                    monster = Goblin.GetGoblin();//generates a goblin
                   
                }

                Console.Write($" In this room... ");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write($"{monster.Name}\n");
                Console.ResetColor();
                #region Encounter Loop


                bool newRoom = false;

                do
                {
                    #region MENU
                    //Prompt the user
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("\n\n  Please choose an action:\n");
                    Console.ResetColor();
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("  A) Attack\n");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine("  R) Run Away\n");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("  P) Player Info\n");
                  
                    Console.WriteLine("  W) Weapon Info\n");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("  M) Monster Info\n");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("  I) Inventory\n");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("  X) Exit\n\n");
                    Console.ResetColor(); 
                    

                    string userChoice = Console.ReadKey(true).Key.ToString();
                    Console.Clear();
                    switch (userChoice)
                    {
                        case "A":
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n  ATTACK!  \n\n");
                            Console.ResetColor();
                            Thread.Sleep(1000);
                            Console.WriteLine(
                                "             __\r\n" +
                                "           ,. |_'.\r\n" +
                                "          / / /:\\ \\\r\n" +
                                "        _/_/_/::: |\r\n" +
                                "       /o_'/o>::/ /\r\n" +
                                "       / /'/:::/ /\r\n" +
                                "      / /_/::.'_/ \r\n" +
                                "     / / \\__.-'\r\n" +
                                "    / /\r\n" +
                                "   / /\r\n" +
                                "    /\r\n\r\n"
                                );
                            Thread.Sleep(500);
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("\n  ATTACK!  \n\n");
                            Console.ResetColor();
                            Console.WriteLine (
                                               "                                  \r\n" +
                                               "                                  \r\n" +
                                               "                                  \r\n" +
                                               "                                  \r\n" +
                                               "                                  \r\n" +
                                               "                                  \r\n" +
                                               "                                  \r\n" +
                                               "      _________________.---.______\r\n" +
                                               "     (_(______________(_o o_(____()\r\n" +
                                               "                  .___.'. .'.___.\r\n" +
                                               "                 \\ o    Y    o /\r\n" +
                                               "                   \\\\__   __/ /\r\n" +
                                               "                     '.__'-'__.'\r\n" +
                                               "                         '''\r\n\r\n");

                            bool deadMonster = Combat.DoBattle(player, monster);
                            newRoom = deadMonster;
                            break;

                        case "R":
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine("\n\n  Run Away!!!");
                            Console.ResetColor();
                            Thread.Sleep(1000);
                            Console.WriteLine($"\n  {monster.Name} attacks you as you flee...");
                            Combat.DoAttack(monster, player);
                            Console.WriteLine();
                            Thread.Sleep(2000);
                            Console.Clear();
                            newRoom = true;
                            break;

                        case "P":
                            Console.WriteLine(player);

                            break;

                        case "W":
                            Console.WriteLine(playerWeapon);

                            break;

                        case "M":
                            Console.WriteLine(monster);

                            break;

                        case "X":
                            Console.WriteLine("\n\n  No one likes a quitter.");
                            exit = true;
                            break;

                        case "I":
                            //TODO : Call the Inventory method or class
                            Console.WriteLine(Player.getInventory());
                            break;


                        default:
                            #region Invalid Input
                            Console.WriteLine("\n\n  You have made a grave error. Wanna try again?");
                            #endregion
                            break;

                    }

                    #endregion

                    #region Check Player Life
                    //TODO Check Player Life
                    //If you have an inventory, or a revive object, could use it at this point
                    if (player.Life <= 0)
                    {
                        Console.WriteLine("  Dude...You died!\a");
                        exit = true; //end the game
                    }
                    #endregion

                } while (!newRoom && !exit);//while both newRoom and exit are not true, keep looping.
                #endregion
            } while (!exit);//while exit is not true, keep looping
            #endregion

            #region Outro
            //TODO Final Score, end the story
            Console.WriteLine($"  You defeated {player.Score} monster(s).");

            //Ask the player if they wanna play again, if so, use main args below
            //Main(args);//restarts the application, or main method in this case.
            Console.ReadKey(true);
            #endregion

        }

        private static string GetRoom(out int index)
        {
            string[] rooms = {

                "\n\n This room has a smoothly hewn natural stone floor that have been polished smooth.\n" +
                " A stylized eye about ten feet across has been engraved in the floor.\n", //0

                "\n\n This room has a roughly hewn stone floor that has small gravel and dirt strewn around.\n" +
                " Line traces of violet light appear and disappear randomly across the floor.\n", //1

                "\n\n This room has stone blocks that have been fitted together into tiles for the floor.\n" +
                " The floors and bottom few feet of the walls of this room are covered in a green-black paste.\n", //2

                "\n\n This room has a limestone tile floor. A light smatter of small rounded stones about the size of\n" +
                " pebbles are scattered about this room.\n", //3

                "\n\n This room has a hard-packed dirt floor. When walked on, it gives a few inches like a soft mat or sponge.\n" +
                " The ceiling is a barrel vaulted (a semi-circular ceiling running in a single direction) and that looks\n" +
                " like it was once plastered smooth and painted.\n",  //4

                "\n\n This room has a black granite tile floor. Several feet from the entryway are a group of almost\n" +
                " a dozen steel shafted spears protruding up from the floor. They are angled towards the door and\n" +
                " appear stained with old blood. Many are bent and several seem to be missing.\n", //5

                "\n\n This room has a hexagonal slate tile floor. Streaks of blood begin in the entryway\n" +
                " and continue across the room, ending at the wall on your right.\n", //6

                "\n\n This room has clay bricks that have been laid down to form a floor. The floor of this room is cracked\n" +
                " and uneven, like a brick that has been shattered and crudely put back together. Finger width cracks\n" +
                " run throughout the room, making you wonder if the floor is stable.\n", //7

                "\n\n This room has a roughly hewn stone floor that has a channel or groove cut into it. It is about a hand's\n" +
                " width wide and runs directly at the entryway. It appears to be several feet deep, and the glint of what\n" +
                " might be metal can be seen deep within it.\n", //8

                "\n\n Four sets of circles are painted crudely on the floor, each circle inscribes a different shape;\n" +
                " triangle, square, four-pointed star and a six-pointed star. Small wisps of smoke rise up from the\n" +
                " floor and dissipate after rising about a foot.\n", //9

                "\n\n This room has a colored ceramic tile floor. Crude chalk drawings adorn the floor. They appear to be\n" +
                " pictures of goblins battling humanoids, and winning.\n" //10
            };
            Random rand = new Random();

            index = rand.Next(rooms.Length);

            string room = rooms[index];

            return room;

            //refactoring -> rewriting code
            //return rooms[new Random().Next(rooms.Length)];

        }


    }
}
