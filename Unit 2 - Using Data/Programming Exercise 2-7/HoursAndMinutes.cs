 using System;
using static System.Console;
class HoursAndMinutes
{
   static void Main()
   {
      // Write your main here
      int min = 197;
      if(min >= 60)
      {
          WriteLine("{0} minutes is {1} hours and {2} minutes", min, min/60, min%60);
      }
      if(min < 60)
      {
          WriteLine("{0} minutes is {1} minutes", min, min);
      }
   }
}
