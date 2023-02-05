using System;
using static System.Console;
class ConvertMilesToKilometers
{
   static void Main()
   {
      // Write your main here.
      double miles;
      Write("Enter miles >> ");
      miles = Convert.ToDouble(ReadLine());
      WriteLine("{0} miles is {1} kilometers", miles, ConvertToKilometers(miles));

   }
   public static double ConvertToKilometers(double miles)
   {
      // Write your ConvertToKilometers() method here.
      const double CONVERSION = 1.60934;
      return miles * CONVERSION;
   }
}
