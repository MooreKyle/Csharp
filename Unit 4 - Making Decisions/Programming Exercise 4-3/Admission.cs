using System;
using static System.Console;
class Admission
{
   static void Main()
   {
      // Write your main here
      double gpa;
      int testScore;
      const double MINGPA = 3.0;
      const int ADMIN1 = 60, ADMIN2 = 80;
      string inputString;
      WriteLine("Enter your Grade Point Average: ");
      inputString = ReadLine();
      gpa = Convert.ToDouble(inputString);
      WriteLine("Enter your Test Score: ");
      inputString = ReadLine();
      testScore = Convert.ToInt32(inputString);
      if (gpa >= MINGPA)
        if (testScore >= ADMIN1)
          WriteLine("Accept");
        else
          WriteLine("Reject");
      else
        if (testScore >= ADMIN2)
          WriteLine("Accept");
        else
          WriteLine("Reject");
   }
}
