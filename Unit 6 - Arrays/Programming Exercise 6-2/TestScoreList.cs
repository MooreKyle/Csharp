using System;
using static System.Console;
class TestScoreList
{
   static void Main()
   {
       // Write your main here
       int[] scores = new int[8];
       int testNum;
       double total = 0;
       double avg;

       for(testNum = 0; testNum < scores.Length; ++testNum)
       {
          Write("Please enter score for test number {0} >> ", (testNum + 1));
          scores[testNum] = Convert.ToInt32(ReadLine());
          total += scores[testNum];
       }
       avg = total / scores.Length;
       WriteLine("Scores for the test are: ");
       for(testNum = 0; testNum < scores.Length; ++testNum)
           WriteLine("Test # {0}: {1,5} From Average: {2, 5}", testNum, scores[testNum].ToString(), (scores[testNum]-avg).ToString());
       WriteLine("\n  Total is {0, 5}", total.ToString());
       WriteLine("Average is {0, 5}", avg.ToString());
   }
}
