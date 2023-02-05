using System;
using static System.Console;
class SumFiveints
{
   static void Main()
   {
      // Write your main here
      WriteLine("Please enter the first integer: ");
      int number1 = int.Parse(ReadLine());
      WriteLine("Please enter the second integer: ");
      int number2 = int.Parse(ReadLine());
      WriteLine("Please enter the third integer: ");
      int number3 = int.Parse(ReadLine());
      WriteLine("Please enter the fourth integer: ");
      int number4 = int.Parse(ReadLine());
      WriteLine("Please enter the fifth integer: ");
      int number5 = int.Parse(ReadLine());
      int sumOfNumbers = (number1 + number2 + number3 + number4 + number5);
      WriteLine("The sum of the numbers is {0}", sumOfNumbers);
   }
}
