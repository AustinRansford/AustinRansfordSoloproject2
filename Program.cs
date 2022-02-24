using System;

namespace AustinRansfordSoloproject2
{
    class Program
    {

        static void Main(string[] args)
        {
            Room currentRoom = new Room();
            currentRoom.description = "Some text here";

            bool isGameWon = false;
            bool isGamelost = false;

            Console.WriteLine(" Chose difficulty 'Easy', 'Medium', 'Hard'");
            string difficulty = Console.ReadLine();
            int turnsleft = DifficultyReader(difficulty);
            Console.WriteLine($"Your adventure starts now.\n \n You are playing a soccer game and need to score a goal in {turnsleft} passes or less.");
            turnsleft = GoalKickRoom(turnsleft);

            static int DifficultyReader(string difficulty)
            {
                int turns;
                if (difficulty == "Easy")
                {
                    turns = 12;
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
            static bool ProbabilityMachine(int probability)
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

            static int GoalKickRoom(int turnsleft)
            {
                Console.WriteLine("\n You have the ball on a goal kick will you pass 'Right', 'Left', or 'Center'");
                string input = Console.ReadLine();
                if (turnsleft == 0)
                {
                    bool isGamelost = true;
                }
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
                     if (input2 == "No"){
                         return GoalKickRoom(turnsleft);
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
                    return GoalKickRoom(turnsleft);

                }
                return 0;


            }
            static int MidFeildKickRoom(int turnsleft)
            {
                Console.WriteLine("\n You have the ball in the mid feild will you pass 'Right', 'Left', or 'Center'");
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
                    return GoalKickRoom(turnsleft);

                }
                return 0;


            }
            static int KickRoom(int turnsleft)
            {
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
                    return GoalKickRoom(turnsleft);

                }
                return 0;

            }
            static int KickRoom2(int turnsleft)
            {
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
                    return GoalKickRoom(turnsleft);

                }

                return 0;
            }
            static int KickRoom3(int turnsleft)
            {
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
                    return GoalKickRoom(turnsleft);

                }

                return 0;
            }




        }
    }
}
