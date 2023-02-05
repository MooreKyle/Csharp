using System;
using static System.Console;
class MakeChange
{
   static void Main()
   {
       // Write your main here
       const int TWENTIES = 20;
       const int TENS = 10;
       const int FIVES = 5;
       int remainder = 0;
       int dollars = 0;
       WriteLine("Enter the dollar amount to be converted: ");
       dollars = int.Parse(ReadLine());
       int r20 = dollars / TWENTIES;
       remainder = dollars - (TWENTIES * r20);
       int r10 = remainder / TENS;
       remainder = remainder - (TENS * r10);
       int r5 = remainder / FIVES;
       int r1 = remainder - (FIVES * r5);
       WriteLine("twenties: {0} tens: {1} fives: {2} ones: {3}", r20, r10, r5, r1);
   }
}
