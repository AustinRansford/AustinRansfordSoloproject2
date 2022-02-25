using System;
using System.Collections.Generic;
namespace AustinRansfordSoloproject2
{
 class probabilitytest
 {

     public static void RunTest()
     {
         Console.WriteLine("enter a value between 1-100 this should be able to return a true or a false value ");
         int testprobability;
        string testprobabilitystr = Console.ReadLine();
        testprobability = int.Parse(testprobabilitystr);
         bool randomNumber = Program.ProbabilityMachine(testprobability);
         Console.WriteLine($"{randomNumber}");

         Console.WriteLine("enter a value over 100 this should always to return a true value");
       
         testprobabilitystr = Console.ReadLine();
        testprobability = int.Parse(testprobabilitystr);
         randomNumber = Program.ProbabilityMachine(testprobability);
         Console.WriteLine($"{randomNumber}");

         Console.WriteLine("enter a value under 0 this should always to return a false value");
        testprobabilitystr = Console.ReadLine();
        testprobability = int.Parse(testprobabilitystr);
         randomNumber = Program.ProbabilityMachine(testprobability);
         Console.WriteLine($"{randomNumber}");




     }

 }

}