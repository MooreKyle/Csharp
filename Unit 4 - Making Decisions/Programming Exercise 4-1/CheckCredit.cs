using System;
using static System.Console;
class CheckCredit
{
   static void Main()
   {
      // Write your main here
      double price;
      WriteLine("enter a purchase price for an item: ");
      price = double.Parse(ReadLine());
      if (price > 8000)
        WriteLine("You have exceeded the credit limit");
      else
        WriteLine("Approved");
   }
}
