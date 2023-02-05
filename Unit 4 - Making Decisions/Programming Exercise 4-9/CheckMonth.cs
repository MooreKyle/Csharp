using System;
using static System.Console;
class CheckMonth
{
   static void Main()
   {
      // Write your main here
      WriteLine("Enter your numeric Birth Month: ");
      int birthMonth = Convert.ToInt32(ReadLine());
      if (birthMonth > 12 || birthMonth < 1)
        WriteLine("Invalid month");
      else
        WriteLine("{0} is a valid month", birthMonth);
   }
}
