using static System.Console;
class InchesToCentimeters
{
   static void Main()
   {
     // Write your main here
     const double convert = 2.54;
     double inches = 3;
     double calculation = inches * convert;
     WriteLine("{0} inches is {1} centimeters", inches, calculation);
   }
}
