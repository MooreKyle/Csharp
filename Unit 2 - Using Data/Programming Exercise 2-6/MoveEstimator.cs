using System;
using static System.Console;
using System.Globalization;
class MoveEstimator
{
   static void Main()
   {
       // Write your main here
       double baseRate = 200;
       double hourlyrate = 150;
       double milerate = 2;
       double hours, miles, moveEstimate;
       string inputValue;
       WriteLine("Enter the hours for the job: ");
       inputValue = ReadLine();
       hours = double.Parse(inputValue);

       WriteLine("Enter the number of miles for the job: ");
       inputValue = ReadLine();
       miles = double.Parse(inputValue);
       moveEstimate = baseRate + (hours * hourlyrate) + (miles * milerate);
       WriteLine("For a move taking {0} hours and going {1} miles the estimate is {2:C}", hours, miles, moveEstimate);
   }
}
