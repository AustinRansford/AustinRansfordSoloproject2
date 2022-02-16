using System;

namespace AustinRansfordSoloproject2
{
    class Program
    {
        
        static void Main()
        {
            Room currentRoom = new Room();
            currentRoom.description = "Some text here";

            bool isGameWon = false;
            bool isGamelost = false;

            Console.WriteLine(" Chose difficulty 'Easy', 'Medium', 'Hard'");
            string difficulty = Console.ReadLine();
            int turnsleft = DifficultyReader(difficulty);

            Console.WriteLine($"Your adventure starts now.\n \n You are playing a soccer game and need to score a goal in {turnsleft} passes or less. \n You have the ball on a goal kick will you pass 'Right', 'Left', or 'Center'");

            static int DifficultyReader(string difficulty)
            {
                int turns;
                if (difficulty == "Easy")
                {
                    turns = 12;
                    Console.WriteLine("You chose the hard difficulty");
                    return turns;
                }
                if (difficulty == "Medium")
                {
                    turns = 9;
                    Console.WriteLine("You chose the hard difficulty");
                    return turns;
                }
                if (difficulty == "Hard")
                {
                    turns = 7;
                    Console.WriteLine("You chose the hard difficulty");
                    return turns;
                }
                else
                {
                    Console.WriteLine("Error you did dont input a game difficulty\n Enter a game difficulty:");
                    string Hardness = Console.ReadLine();
                    return DifficultyReader(Hardness);

                }
                static bool ProbabilityMachine( int probability)
                {
                    if (probability < 0 ){
                        throw new Exception("The chance to succed can not be negative.");
                    }
                    else {
                        Random Generator = new Random();
                        int chance = Generator.Next(0,100);
                        if (chance <= probability){
                            return true;
                        }
                        else return false;

                    }
            
                }
                


            }
        }
    }
}
