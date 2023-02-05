using System;
using static System.Console;
class FahrenheitToCelsius
{
   static void Main()
   {
       // Write your main here
       decimal fTemp;
       decimal cTemp;
       WriteLine("Give me a temperature in fahrenheit to convert: ");
       fTemp = decimal.Parse(ReadLine());
       cTemp = ((fTemp - 32) * 5/9);
       WriteLine("{0} F is {1} C", fTemp.ToString("F1"), cTemp.ToString("F1"));
   }
}
