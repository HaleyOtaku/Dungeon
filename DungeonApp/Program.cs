﻿using DungeonLibrary;
using System;

namespace DungeonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int index = 1;
            #region Title/Introduction
            Console.WriteLine("Your Journey Begins!\n");
            Console.WriteLine
                   ("      | _______________________\n" +
                    "() ===| _______________________ >\n" +
                    "      |\n");
            #endregion


            #region Player Set Up
            Console.WriteLine("****** CHARACTER CREATION ******");

            #region Character Name Assignment
            Console.Write("Please enter your character name: ");
            string playerName = Console.ReadLine();
            #endregion
            Console.Clear();

            #region Race Selection
            List<Race> race = Enum.GetValues<Race>().ToList();
            Console.WriteLine($"Please Select Your Character's Race: \n");
            int index1 = 1;
            foreach (Race item in race)
            {

                Console.WriteLine($"{index1++}) {item}");

            }
            Console.WriteLine();
            int.TryParse(Console.ReadLine(), out int choice);
            //from the collection
            Race playerRace = (Race)(choice - 1);
            #endregion
            Console.Clear();

            #region Weapon Selection
            //TODONE Let them choose a weapon.
            Console.WriteLine($"Please Select Your Weapon: \n");

            Weapon playerWeapon = (Weapon.GetWeapon());

            #endregion
            Console.Clear();

            Player player = new Player(playerName, 40, 5, 70, playerRace,playerWeapon);

            #endregion

            #region Main Game Loop
            bool exit = false;//if true, quit the whole game
            string room = GetRoom();//generate a room
            Console.WriteLine(room);

            do {
                if (room[index] == 0 || room[index] == 1 || room[index] == 2) {
                    Monster monster = Monster.GetMonster(); //generates a monster
                    Console.WriteLine("In this room..." + monster.Name);
                    #region Encounter Loop
                    bool newRoom = false;
                    do
                    {
                        #region MENU
                        //Prompt the user
                        Console.Write("\nPlease choose an action:\n" +
                            "A) Attack\n" +
                            "R) Run away\n" +
                            "P) Player Info\n" +
                            "W) Weapon Info\n"+
                            "M) Monster Info\n" +
                            "I) Inventory\n" +
                            "X) Exit\n\n");

                        string userChoice = Console.ReadKey(true).Key.ToString();
                        Console.Clear();
                        switch (userChoice)
                        {
                            case "A":
                                Console.WriteLine("ATTACK!");
                                bool deadMonster = Combat.DoBattle(player, monster);
                                newRoom = deadMonster;
                                break;

                            case "R":
                                Console.WriteLine("Run away!!!");
                                Console.WriteLine($"{monster.Name} attacks you as you flee...");
                                Combat.DoAttack(monster, player);
                                Console.WriteLine();
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
                                Console.WriteLine("No one likes a quitter.");
                                exit = true;
                                break;

                            case "I":
                                //TODO : Call the Inventory method or class
                                break;


                            default:
                                #region Invalid Input
                                Console.WriteLine("You have made a grave error. Wanna try again?");
                                #endregion
                                break;

                        }

                        #endregion

                        #region Check Player Life
                        //TODO Check Player Life
                        //If you have an inventory, or a revive object, could use it at this point
                        if (player.Life <= 0)
                        {
                            Console.WriteLine("Dude...You died!\a");
                            exit = true; //end the game
                        }
                        #endregion

                    } while (!newRoom && !exit);//while both newRoom and exit are not true, keep looping.
                    #endregion
                }

                else if (room[index] == 3 || room[index] == 4 || room[index] == 5) {
                    Dragon dragon = Dragon.GetDragon(); //generates a dragon
                    Console.WriteLine("In this room..." + dragon.Name);
                    #region Encounter Loop


                bool newRoom = false;
                
                    do {
                    #region MENU
                    //Prompt the user
                    Console.Write("\nPlease choose an action:\n" +
                        "A) Attack\n" +
                        "R) Run away\n" +
                        "P) Player Info\n" +
                        "W) Weapon Info\n" +
                        "M) Monster Info\n" +
                        "I) Inventory\n"+
                        "X) Exit\n\n");

                    string userChoice = Console.ReadKey(true).Key.ToString();
                    Console.Clear();
                    switch (userChoice)
                    {
                        case "A":
                            Console.WriteLine("ATTACK!");
                            bool deadMonster = Combat.DoBattle(player, dragon);
                            newRoom = deadMonster;
                            break;

                        case "R":
                            Console.WriteLine("Run away!!!");
                            Console.WriteLine($"{dragon.Name} attacks you as you flee...");
                            Combat.DoAttack(dragon,player);
                            Console.WriteLine();
                            newRoom = true;
                            break;

                        case "P":
                            Console.WriteLine(player);
                     
                            break;

                        case "W":
                            Console.WriteLine(playerWeapon);

                            break;

                            case "M":
                            Console.WriteLine(dragon);
                            
                            break;

                        case "X":
                            Console.WriteLine("No one likes a quitter.");
                            exit = true;
                            break;

                        case "I":
                            //TODO : Call the Inventory method or class
                            break;


                        default:
                            #region Invalid Input
                            Console.WriteLine("You have made a grave error. Wanna try again?");
                            #endregion
                            break;

                    }

                    #endregion

                    #region Check Player Life
                    //TODO Check Player Life
                    //If you have an inventory, or a revive object, could use it at this point
                    if (player.Life <= 0)
                    {
                        Console.WriteLine("Dude...You died!\a");
                        exit = true; //end the game
                    }
                    #endregion

                } while (!newRoom && !exit);//while both newRoom and exit are not true, keep looping.
                #endregion

                } else if (room[index] == 6 || room[index] == 7 || room[index] == 8) {
                    Skeleton skeleton = Skeleton.GetSkeleton(); //generates a skeleton
                    Console.WriteLine("In this room..." + skeleton.Name);
                    #region Encounter Loop


                    bool newRoom = false;

                    do
                    {
                        #region MENU
                        //Prompt the user
                        Console.Write("\nPlease choose an action:\n" +
                            "A) Attack\n" +
                            "R) Run away\n" +
                            "P) Player Info\n" +
                            "W) Weapon Info\n" +
                            "M) Monster Info\n" +
                            "I) Inventory\n" +
                            "X) Exit\n\n");

                        string userChoice = Console.ReadKey(true).Key.ToString();
                        Console.Clear();
                        switch (userChoice)
                        {
                            case "A":
                                Console.WriteLine("ATTACK!");
                                bool deadMonster = Combat.DoBattle(player, skeleton);
                                newRoom = deadMonster;
                                break;

                            case "R":
                                Console.WriteLine("Run away!!!");
                                Console.WriteLine($"{skeleton.Name} attacks you as you flee...");
                                Combat.DoAttack(skeleton, player);
                                Console.WriteLine();
                                newRoom = true;
                                break;

                            case "P":
                                Console.WriteLine(player);

                                break;

                            case "W":
                                Console.WriteLine(playerWeapon);

                                break;

                            case "M":
                                Console.WriteLine(skeleton);

                                break;

                            case "X":
                                Console.WriteLine("No one likes a quitter.");
                                exit = true;
                                break;

                            case "I":
                                //TODO : Call the Inventory method or class
                                break;


                            default:
                                #region Invalid Input
                                Console.WriteLine("You have made a grave error. Wanna try again?");
                                #endregion
                                break;

                        }

                        #endregion

                        #region Check Player Life
                        //TODO Check Player Life
                        //If you have an inventory, or a revive object, could use it at this point
                        if (player.Life <= 0)
                        {
                            Console.WriteLine("Dude...You died!\a");
                            exit = true; //end the game
                        }
                        #endregion

                    } while (!newRoom && !exit);//while both newRoom and exit are not true, keep looping.
                    #endregion
                }
                else {
                    Goblin goblin = Goblin.GetGoblin();//generates a goblin
                   Console.WriteLine("In this room..." + goblin.Name);
                    #region Encounter Loop


                    bool newRoom = false;

                    do
                    {
                        #region MENU
                        //Prompt the user
                        Console.Write("\nPlease choose an action:\n" +
                            "A) Attack\n" +
                            "R) Run away\n" +
                            "P) Player Info\n" +
                            "W) Weapon Info\n" +
                            "M) Monster Info\n" +
                            "I) Inventory\n" +
                            "X) Exit\n\n");

                        string userChoice = Console.ReadKey(true).Key.ToString();
                        Console.Clear();
                        switch (userChoice)
                        {
                            case "A":
                                Console.WriteLine("ATTACK!");
                                bool deadMonster = Combat.DoBattle(player, goblin);
                                newRoom = deadMonster;
                                break;

                            case "R":
                                Console.WriteLine("Run away!!!");
                                Console.WriteLine($"{goblin.Name} attacks you as you flee...");
                                Combat.DoAttack(goblin, player);
                                Console.WriteLine();
                                newRoom = true;
                                break;

                            case "P":
                                Console.WriteLine(player);

                                break;

                            case "W":
                                Console.WriteLine(playerWeapon);

                                break;

                            case "M":
                                Console.WriteLine(goblin);

                                break;

                            case "X":
                                Console.WriteLine("No one likes a quitter.");
                                exit = true;
                                break;

                            case "I":
                                //TODO : Call the Inventory method or class
                                break;


                            default:
                                #region Invalid Input
                                Console.WriteLine("You have made a grave error. Wanna try again?");
                                #endregion
                                break;

                        }

                        #endregion

                        #region Check Player Life
                        //TODO Check Player Life
                        //If you have an inventory, or a revive object, could use it at this point
                        if (player.Life <= 0)
                        {
                            Console.WriteLine("Dude...You died!\a");
                            exit = true; //end the game
                        }
                        #endregion

                    } while (!newRoom && !exit);//while both newRoom and exit are not true, keep looping.
                    #endregion
                }

            } while (!exit);//while exit is not true, keep looping
            #endregion

            #region Outro
            //TODO Final Score, end the story
            Console.WriteLine($"You defeated {player.Score} monster(s).");

            //Ask the player if they wanna play again, if so, use main args below
            //Main(args);//restarts the application, or main method in this case.
            Console.ReadKey(true);
            #endregion

        }

        private static string GetRoom()
        {
            string[] rooms = {

                "This room has a smoothly hewn natural stone floor that have been polished smooth.\n" +
                "A stylized eye about ten feet across has been engraved in the floor.\n", //0

                "This room has a roughly hewn stone floor that has small gravel and dirt strewn around.\n" +
                "Line traces of violet light appear and disappear randomly across the floor.\n", //1

                "This room has stone blocks that have been fitted together into tiles for the floor.\n" +
                "The floors and bottom few feet of the walls of this room are covered in a green-black paste.\n", //2

                "This room has a limestone tile floor. A light smatter of small rounded stones about the size of\n" +
                "pebbles are scattered about this room.\n", //3

                "This room has a hard-packed dirt floor. When walked on, it gives a few inches like a soft mat or sponge.\n" +
                "The ceiling is a barrel vaulted (a semi-circular ceiling running in a single direction) and that looks\n" +
                "like it was once plastered smooth and painted.\n",  //4

                "This room has a black granite tile floor. Several feet from the entryway are a group of almost\n" +
                "a dozen steel shafted spears protruding up from the floor. They are angled towards the door and\n" +
                "appear stained with old blood. Many are bent and several seem to be missing.\n", //5

                "This room has a hexagonal slate tile floor. Streaks of blood begin in the entryway\n" +
                "and continue across the room, ending at the wall on your right.\n", //6

                "This room has clay bricks that have been laid down to form a floor. The floor of this room is cracked\n" +
                "and uneven, like a brick that has been shattered and crudely put back together. Finger width cracks\n" +
                "run throughout the room, making you wonder if the floor is stable.\n", //7

                "This room has a roughly hewn stone floor that has a channel or groove cut into it. It is about a hand's\n" +
                "width wide and runs directly at the entryway. It appears to be several feet deep, and the glint of what\n" +
                "might be metal can be seen deep within it.\n", //8

                "Four sets of circles are painted crudely on the floor, each circle inscribes a different shape;\n" +
                "triangle, square, four-pointed star and a six-pointed star. Small wisps of smoke rise up from the\n" +
                "floor and dissipate after rising about a foot.\n", //9

                "This room has a colored ceramic tile floor. Crude chalk drawings adorn the floor. They appear to be\n" +
                "pictures of goblins battling humanoids, and winning.\n" //10
            };
            Random rand = new Random();

            int index = rand.Next(rooms.Length);

            string room = rooms[index];

            return room;

            //refactoring -> rewriting code
            //return rooms[new Random().Next(rooms.Length)];

        }


    }
}
