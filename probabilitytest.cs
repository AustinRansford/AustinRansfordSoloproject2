using System;
using System.Collections.Generic;
namespace AustinRansfordSoloproject2
{
 class probabilitytest
 {

     public static bool RunTest()
     {
         Console.WriteLine("enter a value between 1-100 this should be able to return a true or a false value ");
         int testprobability;
        string testprobabilitystr = Console.ReadLine();
        testprobability = int.Parse(testprobabilitystr);
         bool randomNumber = Program.ProbabilityMachine(testprobability);
         while (randomNumber != true )
         {
             Console.WriteLine($"the probaility returned {randomNumber}");
             Console.WriteLine("enter a value between 1-100 this should be able to return a true or a false value ");
             testprobabilitystr = Console.ReadLine();
        testprobability = int.Parse(testprobabilitystr);
         randomNumber = Program.ProbabilityMachine(testprobability);

         }
         Console.WriteLine($"the probaility returned {randomNumber}");

         Console.WriteLine("enter a value over 100 this should always to return a true value");
       
         testprobabilitystr = Console.ReadLine();
        testprobability = int.Parse(testprobabilitystr);
         randomNumber = Program.ProbabilityMachine(testprobability);
         if (randomNumber != true )
         {
             return false;
         }
         Console.WriteLine($"the probaility returned {randomNumber}");

        // TODO(jcollard 2022-03-04): The code you've written actually throws an exception if the value is less than 0.
        // Should this be a try / catch (exception) test?
         Console.WriteLine("enter a value under 0 this should always to return a an exception");
        testprobabilitystr = Console.ReadLine();
        testprobability = int.Parse(testprobabilitystr);
         try 
         {
             randomNumber = Program.ProbabilityMachine(testprobability);

         
         Console.WriteLine($"the probaility failed by returning a nonerror message");
         return false;
         }
         catch (Exception e)
         {
         Console.WriteLine("The program successfully returned a error message.");
         }

         return true;



        

     }

 }

}