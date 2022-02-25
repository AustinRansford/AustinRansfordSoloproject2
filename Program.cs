using System;

namespace AustinRansfordSoloproject2
{
    class Program
    {


        static void Main(string[] args)
        {

            if (args.Length > 0 && args[0] == "test")
            {
                 probabilitytest.RunTest();
          Console.WriteLine($" Test GetPositiveInteger(Options): {testGetPositiveInt}");
            }

            Room currentRoom = new Room();
            currentRoom.description = "Some text here";

            bool isGameWon = false;
            bool isGamelost = false;

            Console.WriteLine(" Chose difficulty 'Easy', 'Medium', 'Hard'");
            string difficulty = Console.ReadLine();
            int turnsleft = DifficultyReader(difficulty);
            Console.WriteLine($"Your adventure starts now.\n You are playing a soccer game and need to score a goal in {turnsleft - 1} passes or less.");
            GoalKickRoom(turnsleft);
        }


        /// <summary>
        /// takes an input and assigns a difficulty to the game
        /// </summary>
        /// <param name="difficulty"> is a string that is the user's input</param>
        /// <returns> an integer that is equal to the turns left dependent on the difficulty</returns>
        static int DifficultyReader(string difficulty)
        {
            // if input string == Easy set turns to 12
            // if input string == Medium set turns to 9
            // if input string == Hard set turns to 7
            // if input ! == Easy Medium Hard prompt user read the response and restart the method 
            int turns;
            if (difficulty == "Easy")
            {
                turns = 1;
                Console.WriteLine("You chose the Easy difficulty");
                return turns;
            }
            if (difficulty == "Medium")
            {
                turns = 9;
                Console.WriteLine("You chose the Medium difficulty");
                return turns;
            }
            if (difficulty == "Hard")
            {
                turns = 7;
                Console.WriteLine("You chose the Hard difficulty");
                return turns;
            }
            else
            {

                while (!difficulty.Equals("Easy") && !difficulty.Equals("Medium") && !difficulty.Equals("Easy"))
                {
                    Console.WriteLine("Error you did dont input a game difficulty\nEnter a game difficulty: 'Easy', 'Medium' 'Hard'");
                    string Hardness = Console.ReadLine();
                    return DifficultyReader(Hardness);
                }

            }
            return 0;
        }

        /// <summary>
        /// This method takes an generates a number between 0 and 100 if the randomly generated number is less or equal to the integer parameter then the method returns true else returns false. 
        /// </summary>
        /// <param name="probability"> The probabilty for something to return true</param>
        /// <returns> a true of false value </returns>
        public static bool ProbabilityMachine(int probability)
        {
            if (probability < 0)
            {
                throw new Exception("The chance to succed can not be negative.");
            }
            else
            {
                Random Generator = new Random();
                int chance = Generator.Next(0, 100);
                while (chance > 100 | chance <= 0)
                {
                    chance = Generator.Next(0, 100);
                }
                if (chance <= probability)
                {
                    return true;
                }
                else return false;

            }

        }
        /// <summary>
        /// This is the first room in my word adventure 
        /// </summary>
        /// <param name="turnsleft"> How many 'passes' you can make with before scoring, if == 0 game ends</param>
        /// <returns></returns>
        static void GoalKickRoom(int turnsleft)
        {
            if (turnsleft == 0)
            {
                throw new Exception("You took too long to score a goal on the counter attack, and the ball got stolen. \nGame over.");
            }
            Console.WriteLine("\n You have the ball on a goal kick will you pass 'Right', 'Left', or 'Center'");
            string input = Console.ReadLine();
            if (input == "Right")
            {
                Console.WriteLine("");
                turnsleft = turnsleft - 1;

            }
            if (input == "Center")
            {
                Console.WriteLine("Before you pass the ball to the Center you should know that there is a low probablity of a successfully passing the ball\nto your teamate without losing possession of the ball.\nThere is a 55% success rate.\n \n Will you still attempt to pass it to the center?\n'Yes' or 'No'");
                string input2 = Console.ReadLine();
                if (input2 == "Yes")
                {
                    turnsleft = turnsleft - 1;
                    bool success = ProbabilityMachine(55);
                    bool retrevial = ProbabilityMachine(30);
                    if (success == true)
                    {
                        Console.WriteLine("You successfully made the pass to the midfeild");

                        MidFeildKickRoom(turnsleft);

                    }
                    if (success == false && retrevial == false)
                    {
                        turnsleft = 0;
                        Console.WriteLine("You lost the ball in the midfeild. The Counter attack is over.");
                        GoalKickRoom(turnsleft);
                    }
                    else
                    {
                        Console.WriteLine("The pass was unsuccessful but you won the ball back.");
                        GoalKickRoom(turnsleft);

                    }


                }
                if (input2 == "No")
                {
                    GoalKickRoom(turnsleft);
                }


            }
            if (input == "Left")
            {
                Console.WriteLine("");
                turnsleft = turnsleft - 1;


            }
            else
            {
                Console.WriteLine("error you did not input the a possible passing direction");
                GoalKickRoom(turnsleft);

            }



        }
        static void MidFeildKickRoom(int turnsleft)
        {
            if (turnsleft == 0)
            {
                throw new Exception("You took too long to score a goal on the counter attack, and the ball got stolen. \nGame over.");
            }
            Console.WriteLine("\n You have the ball in the mid feild. The there are four guys in the center and right of the feild. will you pass 'Right', 'Left', or 'Center'?");
            string input = Console.ReadLine();

            if (input == "Right")
            {
                Console.WriteLine("");
                turnsleft = turnsleft - 1;

            }
            if (input == "Center")
            {
                Console.WriteLine("Before you pass the ball to the Center you should know that there is a low probablity of a successfully passing the ball\nto your teamate without losing possession of the ball.\nThere is a 55% success rate.");
                turnsleft = turnsleft - 1;

            }
            if (input == "Left")
            {
                Console.WriteLine("");
                turnsleft = turnsleft - 1;


            }
            else
            {
                Console.WriteLine("You did not input the a valid passing direction");
                GoalKickRoom(turnsleft);

            }



        }
        static void KickRoom(int turnsleft)
        {
            if (turnsleft == 0)
            {
                throw new Exception("You took too long to score a goal on the counter attack, and the ball got stolen. \nGame over.");
            }
            Console.WriteLine("\n You have the ball on a goal kick will you pass 'Right', 'Left', or 'Center'");
            string input = Console.ReadLine();

            if (input == "Right")
            {
                Console.WriteLine("");
                turnsleft = turnsleft - 1;

            }
            if (input == "Center")
            {
                Console.WriteLine("Before you pass the ball to the Center you should know that there is a low probablity of a successfully passing the ball\nto your teamate without losing possession of the ball.\nThere is a 55% success rate.");
                turnsleft = turnsleft - 1;

            }
            if (input == "Left")
            {
                Console.WriteLine("");
                turnsleft = turnsleft - 1;


            }
            else
            {
                Console.WriteLine("error you did not input the a possible passing direction");
                GoalKickRoom(turnsleft);

            }


        }
        static void KickRoom2(int turnsleft)
        {
            if (turnsleft == 0)
            {
                throw new Exception("You took too long to score a goal on the counter attack, and the ball got stolen. \nGame over.");
            }
            Console.WriteLine("\n You have the ball on a goal kick will you pass 'Right', 'Left', or 'Center'");
            string input = Console.ReadLine();

            if (input == "Right")
            {
                Console.WriteLine("");
                turnsleft = turnsleft - 1;

            }
            if (input == "Center")
            {
                Console.WriteLine("Before you pass the ball to the Center you should know that there is a low probablity of a successfully passing the ball\nto your teamate without losing possession of the ball.\nThere is a 55% success rate.");
                turnsleft = turnsleft - 1;

            }
            if (input == "Left")
            {
                Console.WriteLine("");
                turnsleft = turnsleft - 1;


            }
            else
            {
                Console.WriteLine("error you did not input the a possible passing direction");
                GoalKickRoom(turnsleft);

            }


        }
        static void KickRoom3(int turnsleft)
        {
            if (turnsleft == 0)
            {
                throw new Exception("You took too long to score a goal on the counter attack, and the ball got stolen. \nGame over.");
            }
            Console.WriteLine("\n You have the ball in the goal will you pass 'Right', 'Left', or 'Center'");
            string input = Console.ReadLine();

            if (input == "Right")
            {
                Console.WriteLine("");
                turnsleft = turnsleft - 1;

            }
            if (input == "Center")
            {
                Console.WriteLine("Before you pass the ball to the Center you should know that there is a low probablity of a successfully passing the ball\nto your teamate without losing possession of the ball.\nThere is a 55% success rate.");
                turnsleft = turnsleft - 1;

            }
            if (input == "Left")
            {
                Console.WriteLine("");
                turnsleft = turnsleft - 1;


            }
            else
            {
                Console.WriteLine("error you did not input the a possible passing direction");
                GoalKickRoom(turnsleft);

            }


        }





    }
}
