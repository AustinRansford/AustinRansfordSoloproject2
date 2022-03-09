using System;
using System.Collections.Generic;

namespace AustinRansfordSoloproject2
{
    class Program
    {
        public static List<string> PassingPath = new List<string>() ;


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

           

            Console.WriteLine(" Chose difficulty 'Easy', 'Medium', 'Hard'");
            string difficulty = Console.ReadLine();
            int turnsleft = DifficultyReader(difficulty);
            Console.WriteLine($"Your adventure starts now.\n You are playing a soccer game and need to score a goal in {turnsleft-1} passes or less.");            GoalKickRoom(turnsleft);
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
                turns = 12;
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
        public static string GoalKickRoom(int turnsleft)
        {
            if (turnsleft == 0)
            {
                return GameLost();
            }
            Console.WriteLine("\n You have the ball on a goal kick will you pass 'Right', 'Left', or 'Center'");
            string input = Console.ReadLine();
            if (input.ToLower().Trim() == "right")
            {
                Console.WriteLine(" You passed the ball right and the Midfeild recieved the ball.");
                turnsleft = turnsleft - 1;
                PassingPath.Add("Goal Kick");
               return MidFeildKickRoom(turnsleft);

            }
            if (input.ToLower().Trim() == "center")
            {
                Console.WriteLine("Before you pass the ball to the Center you should know that there is a low probablity of a successfully passing the ball\nto your teamate without losing possession of the ball.\nThere is a 55% success rate.\n \n Will you still attempt to pass it to the center?\n'Yes' or 'No'");
                string input2 = Console.ReadLine();
                if (input2.ToLower().Trim() == "yes")
                {
                    turnsleft = turnsleft - 1;
                    bool success = ProbabilityMachine(55);


                    if (success == true)
                    {
                        Console.WriteLine("You successfully made the pass to the midfeild");
                        PassingPath.Add("Goal Kick");

                        return MidFeildKickRoom(turnsleft);

                    }
                    if (success == false)
                    {

                        Console.WriteLine("You lost the ball in the midfeild. The Counter attack is over.");
                        PassingPath.Add("Goal Kick");
                        return GameLost();
                    }



                }
                if (input2.ToLower().Trim() == "no")
                {
                    return GoalKickRoom(turnsleft);
                }


            }
            if (input.ToLower().Trim() == "left")
            {
                Console.WriteLine("You passed the Ball left successfully and your midfeild now has the ball");
                turnsleft = turnsleft - 1;

                PassingPath.Add("Goal Kick");
               return  MidFeildKickRoom(turnsleft);
                // maybe if time allows add a quick left mid position. 



            }
            else
            {
                Console.WriteLine("error you did not input the a possible passing direction");
                return GoalKickRoom(turnsleft);

            }



        }
        public static string MidFeildKickRoom(int turnsleft)
        {
            if (turnsleft == 0)
            {
                return GameLost();
            }
            Console.WriteLine("\n You have the ball in the mid feild. The there are four guys in the center and right of the feild. will you pass 'Right', 'Left', 'Back' or 'Center'?");
            string input = Console.ReadLine();

            if (input.ToLower().Trim() == "right")
            {
                Console.WriteLine("You passed the ball to the right and it was immediately intercepted");
                turnsleft = turnsleft - 1;
                PassingPath.Add("Midfeild");
                return GameLost();

            }
            if (input.ToLower().Trim() == "center")
            {
                Console.WriteLine("You passed the ball to the Center and barely spilt the defenders.");
                turnsleft = turnsleft - 1;
                PassingPath.Add("Midfeild");
                return CenterAttackingMid(turnsleft);

            }
            if (input.ToLower().Trim() == "left")
            {
                Console.WriteLine("You passed the ball to the left. \n the Left Midfeilder who recieved the ball Immediately passed the ball to the center attacking mid.\n ");
                turnsleft = turnsleft - 2;
                PassingPath.Add("Midfeild");
                PassingPath.Add("Left Mid");
                return CenterAttackingMid(turnsleft);


            }
            if (input.ToLower().Trim() == "back")
            {
                Console.WriteLine("You passed the ball back to your center defensive mid who can kick super far!");
                turnsleft = turnsleft - 1;
                PassingPath.Add("Midfeild");
                return CDM(turnsleft);


            }
            else
            {
                Console.WriteLine("You did not input the a valid passing direction");
                return MidFeildKickRoom(turnsleft);

            }



        }
        public static string CenterAttackingMid(int turnsleft)
        {
            if (turnsleft == 0)
            {
                return GameLost();
            }

            Console.WriteLine("\n You have the ball on a goal kick will you pass to your players 'feet' or play a 'through' ball. '");
            string input = Console.ReadLine();

            if (input.ToLower().Trim() == "feet")
            {
                Console.WriteLine(" You played to the strikers feet. His only choie left is to drible. This action takes two turns");
                turnsleft = turnsleft - 2;
                PassingPath.Add("Center Attacking Mid");
                PassingPath.Add("Striker dribbling");
                return Finalthird(turnsleft);

            }
            if (input.ToLower().Trim() == "through ball")
            {
                Console.WriteLine("you played a beautiful ");
                turnsleft = turnsleft - 1;
                PassingPath.Add("Center Attacking Mid");
                return Finalthird(turnsleft);


            }
            else
            {
                Console.WriteLine("error you did not input the a possible passing direction");
                return CenterAttackingMid(turnsleft);

            }


        }
        public static string CDM(int turnsleft)
        {
            if (turnsleft == 0)
            {
                return GameLost();
            }
            Console.WriteLine("\n You have passed the ball back to the center defensive mid will you pass the ball 'over' the top or forward to the mid feild. \n there is a 90% chance of the pass over. ");
            string input = Console.ReadLine();

            if (input.ToLower().Trim() == "over" | input.ToLower().Trim() == "over the top")
            {
                turnsleft = turnsleft - 1;
                Console.WriteLine("You have passed the ball over the top. Will the ball be intercepted?");
                bool Intercepted = ProbabilityMachine(90);
                if (Intercepted)
                {
                    Console.WriteLine("The ball has fallen to your player in front of the goal!!!\nGet ready to SCORE!");
                    PassingPath.Add("Center defensive Mid");
                    return Finalthird(turnsleft);
                }
                if (Intercepted == false ){
                    Console.WriteLine("The defense has intercepted the ball");
                    return GameLost();
                }



            }
            if (input.ToLower().Trim() == "foward")
            {
                Console.WriteLine("You passed the ball to the midfeild once again");
                turnsleft = turnsleft - 1;
                PassingPath.Add("Center defensive Mid");
               return  MidFeildKickRoom(turnsleft);

            }

            else
            {
                Console.WriteLine("error you did not input the a possible passing direction");
                 return CDM(turnsleft);

            }


        }
        public static string Finalthird(int turnsleft)
        {
            if (turnsleft == 0)
            {
                return GameLost();
            }
            Console.WriteLine("\n You have the ball in front of the opposing goal will you shoot 'Right', 'Left', or 'Center'");
            string input = Console.ReadLine();

            if (input.ToLower().Trim() == "right")
            {
                PassingPath.Add("Striker");
                Console.WriteLine("You turn your hips to thr right and line up the shot\n ...\n ...\n... \nYOU SCORED!");
                return GameWon();
            }
            if (input.ToLower().Trim() == "center")
            {
                PassingPath.Add("Striker");
                Console.WriteLine("Before you Shoot the ball to the Center\n ...\n ...\n... \nThe Goalie saved the Ball\n the counter attack is over .");
                return GameLost();

            }
            if (input.ToLower().Trim() == "left")
            {
                PassingPath.Add("Striker");
                Console.WriteLine("You turn your hips to the left and line up the shot\n ...\n ...\n... \nYOU SCORED!");
                return GameWon();


            }
            else
            {
                Console.WriteLine("error you did not input the a possible passing direction");
                return Finalthird(turnsleft);

            }


        }

        public static string GameLost()
        {
            Console.WriteLine("You took too long to score a goal on the counter attack, and the ball got stolen. \nGame over.");
            string locationlist = string.Empty;
            foreach (string places in PassingPath)
            {

                locationlist = locationlist + places +", ";

            }
            int turnsUsed = PassingPath.Count;
             Console.WriteLine($"You used {turnsUsed} turns. \nThis is your passing path. {locationlist}");
            return ($"This is your passing path. {locationlist}");
        }
        public static string  GameWon()
        {
            Console.WriteLine("YOU WON!!!\n You scored a goal on the counter attack.");
            string locationlist = string.Empty;
            foreach (string places in PassingPath)
            {

                locationlist = locationlist + places +", ";

            }
            int turnsUsed = PassingPath.Count;
        Console.WriteLine($"You used {turnsUsed} turns. \nThis is your passing path. {locationlist}");
            return ($"This is you passing path. {locationlist}");
           
        }



    }

}
