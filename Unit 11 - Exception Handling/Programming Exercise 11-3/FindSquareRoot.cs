using System;
using static System.Console;
class FindSquareRoot
{
   static void Main()
   {
       // Your code here
       double number, sqrt;
       try
       {
          Write("Enter a number ");
          if(!double.TryParse(ReadLine(), out number))
             WriteLine("Entered number is not a double");
          if(number < 0)
             throw(new ApplicationException("Number can't be negative."));
          sqrt = Math.Sqrt(number);
       }
       catch(ApplicationException e)
       {
          WriteLine("Error: {0}", e.Message);
          sqrt = 0;
       }
       WriteLine("Square root is {0}", sqrt);
   }
}
