using System;
using static System.Console;
class SumInts
{
   static void Main()
   {
      // Write your main here.
      int num = 0;
      int sum = 0;
      string inputString;

      while(num != 999)
      {
        WriteLine("Enter a number or 999 to discontinue: ");
        inputString = ReadLine();
        num = int.Parse(inputString);
        sum += num;
      }
      WriteLine("The total is {0}.", sum - 999);
   }
}
