using System;
using static System.Console;
class DailyTemps
{
   static void Main()
   {
      // Write your main here.
      int temperature;
      string inputString;
      int count = 0;
      int total = 0;
      double average;
      const int LOW = -20;
      const int HIGH = 130;
      const int QUIT = 999;
      Write("Enter temperature >> ");
      inputString = ReadLine();
      temperature = Convert.ToInt32(inputString);
      while(temperature != QUIT)
      {
        if(temperature < LOW || temperature > HIGH)
          WriteLine("Valid temperatures range from {0} to {1}. Please reenter temperature.", LOW, HIGH);
        else
        {
          total += temperature;
          ++count;
        }
        Write("Enter another temperature or {0} to quit >> ", QUIT);
        inputString = ReadLine();
        temperature = Convert.ToInt32(inputString);
      }
      average = total * 1.0 / count;
      WriteLine("The average of the {0} valid temperatures entered is {1}", count, average);
   }
}
