using System;
using static System.Console;
class PaintingEstimate
{
   static void Main()
   {
       // Write your main here.
       int length;
       int width;
       Write("Enter length of the room in feet >> ");
       length = Convert.ToInt32(ReadLine());
       Write("Enter width of room in feet >> ");
       width = Convert.ToInt32(Console.ReadLine());
       WriteLine("Cost of job for {0} X {1} foot room is {2}", length, width, ComputeCost(length, width).ToString("C"));
   }
    
   public static double ComputeCost(int length, int width)
   {
       // Write your DisplayContactInfo()
       const int HEIGHT = 9;
       double PRICE = 6;
       double cost = ((length * HEIGHT * 2) + (width * HEIGHT * 2)) * PRICE;
       return cost;
   }
}
