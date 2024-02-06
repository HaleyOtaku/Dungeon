namespace DungeonApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Title/Introduction
            Console.WriteLine("Your Journey Begins!\n");
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

                Console.WriteLine("Welcome to room..." + room);

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

                "1", //0
                "2", //1
                "3", //2
                "4", //3
                "5"  //4
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
