using System;
using static System.Console;
class Eggs
{
   static void Main()
   {
     // Your code here
     const int DOZEN = 12;
     WriteLine("Enter four numbers to display the total of eggs");
     int egg1 = int.Parse(ReadLine());
     int egg2 = int.Parse(ReadLine());
     int egg3 = int.Parse(ReadLine());
     int egg4 = int.Parse(ReadLine());
     int total;
     int dozens, leftOver;
     total = (egg1 + egg2 + egg3 + egg4);
     dozens = total / DOZEN;
     leftOver = total % DOZEN;
     WriteLine("{0} eggs is {1} dozen and {2} eggs",
       total, dozens, leftOver);
   }
}
