using System;
using static System.Console;
class MakeChange
{
   static void Main()
   {
       // Write your main here
       const int DOZEN = 12;
       int chicken1 = 30, chicken2 = 40, chicken3 = 35, chicken4 = 22;
       int total;
       int dozens, leftOver;
       total = chicken1 + chicken2 + chicken3 + chicken4;
       dozens = total / DOZEN;
       leftOver = total % DOZEN;
       WriteLine("{0} eggs is {1} dozen and {2} eggs", total, dozens, leftOver);
   }
}
