namespace DungeonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Title/Introduction
            Console.WriteLine("Your Journey Begins!\n");
            Console.WriteLine
                   ("      | _______________________\n" +
                    "() ===| _______________________ >\n" +
                    "      |\n");
            #endregion

            #region Player Set Up
           //TODO Player Object Creation
            #endregion

            #region Main Game Loop
           bool exit = false;//if true, quit the whole game
            do {
                //TODO generate a monster
                //TODONE generate a room
                string room = GetRoom();
                Console.WriteLine(room); 

                #region Encounter Loop
                bool newRoom = false;
                do {
                    #region MENU
                    //Prompt the user
                    Console.Write("\nPlease choose an action:\n" +
                        "A) Attack\n" +
                        "R) Run away\n" +
                        "P) Player Info\n" +
                        "M) Monster Info\n" +
                        "X) Exit\n");

                    string userChoice = Console.ReadKey(true).Key.ToString();
                    Console.Clear();
                    switch (userChoice)
                    {
                        case "A":
                            Console.WriteLine("ATTACK!");
                            //TODO Combat functionality
                            break;

                        case "R":
                            //TODO monster free attack chance
                            Console.WriteLine("Run away!!!");
                            newRoom = true;
                            break;

                        case "P":
                            Console.WriteLine("Behold, a gamer...");
                            //TODO show player info
                            break;


                        case "M":
                            Console.WriteLine("Monster Stuff");
                            //TODO show monster info
                            break;

                        case "X":
                            Console.WriteLine("No one likes a quitter.");
                            exit = true;
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
                    #endregion

                } while (!newRoom && !exit);//while both newRoom and exit are not true, keep looping.
                #endregion

            } while (!exit);//while exit is not true, keep looping
            #endregion

            #region Outro
            //TODO Final Score, end the story
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
