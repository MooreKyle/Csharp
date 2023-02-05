using System;
using static System.Console;
class MonthNames
{
   enum Month
      {
          January = 1,
          February = 2,
          March = 3,
          April = 4,
          May = 5,
          June = 6,
          July = 7,
          August = 8,
          September = 9,
          October = 10,
          November = 11,
          December = 12
      }
      
   static void Main()
   {
       // Write your main here
       int monthIndex = 0;
       Month MonthName;
       WriteLine("Enter the month #: ");
       monthIndex = int.Parse(ReadLine());
       MonthName = (Month)monthIndex;
       WriteLine(MonthName);
   }
}
