using System;
using static System.Console;
class CheckMonth2
{
   static void Main()
   {
      // Write your main here
      int birthMonth, birthDay;
      WriteLine("Enter a Birth Month: ");
      birthMonth = Convert.ToInt32(ReadLine());
      WriteLine("Enter a Birth Day: ");
      birthDay = Convert.ToInt32(ReadLine());

      if ((birthMonth >= 1 && birthMonth < 12) && (birthDay >= 1 && birthDay < 31 || birthDay < 29 || birthDay < 28))
        WriteLine("{0}/{1} is a valid birthday", birthMonth, birthDay);
      else
        WriteLine("Invalid date");
   }
}
