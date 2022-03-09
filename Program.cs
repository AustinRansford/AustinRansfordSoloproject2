using System;
using System.Collections.Generic;

namespace AustinRansfordSoloproject2
{
    class Program
    {
        public List<string> PassingPath;


        static void Main(string[] args)
        {

            if (args.Length > 0 && args[0] == "test")
            {
                 bool probabilitytestBool = probabilitytest.RunTest();
          Console.WriteLine($" Test ProbabilityMachine(Options): {probabilitytestBool}");
          return;

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
            // Feedback(jcollard 2022-03-04): If you change this to
            // if (difficulty.ToLower().Trim() == "easy")
            // You will be able to accept inputs like "easy", "EASY", and "   eaSy   "
            if (difficulty.ToLower().Trim() == "easy")
            {
                turns = 1;
                Console.WriteLine("You chose the Easy difficulty");
                return turns;
            }
            if (difficulty.ToLower().Trim() == "medium")
            {
                turns = 9;
                Console.WriteLine("You chose the Medium difficulty");
                return turns;
            }
            if (difficulty.ToLower().Trim() == "hard")
            {
                turns = 7;
                Console.WriteLine("You chose the Hard difficulty");
                return turns;
            }
           
        
                // Feedback(jcollard 2022-03-04): This loop is superfluous, the
                // call to `DifficultyReader` inside will exit the loop. The
                // "loop" you have here is actually coming from simply calling
                // `DifficultyReader`.
            else
             {
                    Console.WriteLine("Error you did dont input a game difficulty\nEnter a game difficulty: 'Easy', 'Medium' 'Hard'");
                    string Hardness = Console.ReadLine();
                    return DifficultyReader(Hardness);
             }
                

        
           
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
                throw new Exception("The chance to succeed can not be negative.");
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
        private void GoalKickRoom(int turnsleft)
        {
            if (turnsleft == 0)
            {
                GameLost();
            }
            Console.WriteLine("\n You have the ball on a goal kick will you pass 'Right', 'Left', or 'Center'");
            string input = Console.ReadLine();
            if (input == "Right")
            {
                Console.WriteLine(" You passed the ball right and the Midfeild recieved the ball.");
                turnsleft = turnsleft - 1;
                this.PassingPath.Add("Goal Kick");
                MidFeildKickRoom(turnsleft);

            }
            if (input == "Center")
            {
                Console.WriteLine("Before you pass the ball to the Center you should know that there is a low probablity of a successfully passing the ball\nto your teamate without losing possession of the ball.\nThere is a 55% success rate.\n \n Will you still attempt to pass it to the center?\n'Yes' or 'No'");
                string input2 = Console.ReadLine();
                if (input2 == "Yes")
                {
                    turnsleft = turnsleft - 1;
                    bool success = ProbabilityMachine(55);
                    
                
                    if (success == true)
                    {
                        Console.WriteLine("You successfully made the pass to the midfeild");
                        this.PassingPath.Add("Goal Kick");

                        MidFeildKickRoom(turnsleft);

                    }
                    if (success == false)
                    {
                        turnsleft = 0;
                        Console.WriteLine("You lost the ball in the midfeild. The Counter attack is over.");
                        this.PassingPath.Add("Goal Kick");
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
                Console.WriteLine("You passed the Ball left successfully and your midfeild now has the ball");
                turnsleft = turnsleft - 1;

                this.PassingPath.Add("Goal Kick");
                MidFeildKickRoom(turnsleft);
            // maybe if time allows add a quick left mid position. 



            }
            else
            {
                Console.WriteLine("error you did not input the a possible passing direction");
                GoalKickRoom(turnsleft);

            }



        }
        public void MidFeildKickRoom(int turnsleft)
        {
            if (turnsleft == 0)
            {
                GameLost();
            }
            Console.WriteLine("\n You have the ball in the mid feild. The there are four guys in the center and right of the feild. will you pass 'Right', 'Left', or 'Center'?");
            string input = Console.ReadLine();

            if (input == "Right")
            {
                Console.WriteLine("You passed the ball to the right and it was immediately intercepted");
                turnsleft = turnsleft - 1;
                this.PassingPath.Add("Midfeild");
                 GameLost();

            }
            if (input == "Center")
            {
                Console.WriteLine("You passed the ball to the Center and barely spilt the defenders.");
                turnsleft = turnsleft - 1;
                this.PassingPath.Add("Midfeild");
                CenterAttackingMid(turnsleft);

            }
            if (input == "Left")
            {
                Console.WriteLine("");
                turnsleft = turnsleft - 1;
                this.PassingPath.Add("Midfeild");


            }
            else
            {
                Console.WriteLine("You did not input the a valid passing direction");
                MidFeildKickRoom(turnsleft);

            }



        }
        static void CenterAttackingMid(int turnsleft)
        {
            if (turnsleft == 0)
            {
                 GameLost();
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
                 GameLost();
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
                 GameLost();
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

        static void GameLost(){
            Console.WriteLine("You took too long to score a goal on the counter attack, and the ball got stolen. \nGame over.");
            return;
        }



    }

}
