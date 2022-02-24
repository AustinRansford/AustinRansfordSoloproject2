using System;

namespace Austin_Ransford_Personal_Project_1
{
    class Program
    {

        static void Main12()
        {

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
                    Console.WriteLine("You chose the hard difficulty. you get 9 turns to");
                    return turns;
                }
                if (difficulty == "Medium")
                {
                    turns = 9;
                    Console.WriteLine("You chose the hard difficulty. You get 9 turns to score");
                    return turns;
                }
                if (difficulty == "Hard")
                {
                    turns = 7;
                    Console.WriteLine("You chose the hard difficulty. You get 7 turns to score");
                    return turns;
                }
                else
                {
                    Console.WriteLine("Error you did dont input a game difficulty\n Enter a game difficulty:");
                    string Hardness = Console.ReadLine();
                    return DifficultyReader(Hardness);

                }
                


            }




        }
        // public void Difficulty(string[] args)
        // {
        //     // if(input ='Easy'){

        //     // }
        //     Console.WriteLine("Hello World!");
        // }
    }
}
