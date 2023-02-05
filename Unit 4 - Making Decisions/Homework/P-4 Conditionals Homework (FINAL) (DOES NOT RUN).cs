//Preprocessor Directives/Namespaces
using System;
using static System.Console;

//Class: MainClass
class MainClass
{
  //Function: Main
  public static void Main (string[] args)
  {
    //Declarations
    double testScore;
    char g;

    //Program Summary
    WriteLine("This program will display the letter grade of a test score value that is entered by the user. ");

    //Prompt User to input testScore and Display Grade based on Value
    WriteLine("\nPlease enter a test score: ");
    g = ReadLine();

    if(90 < testScore && testScore <= 100)
    {
      g = 'A';
      WriteLine("\nThe Letter grade for a score of ", testScore, " is ", g);
    }
    else
      if(80 < testScore && testScore <= 90)
      {
        g = 'B';
        WriteLine("\nThe Letter grade for a score of ", testScore, " is ", g);
      }
      else
        if(70 < testScore && testScore <= 80)
        {
          g = 'C';
          WriteLine("\nThe Letter grade for a score of ", testScore, " is ", g);
        }
        else
          if(60 < testScore && testScore <= 70)
          {
            g = 'D';
            WriteLine("\nThe Letter grade for a score of ", testScore, " is ", g);
          }
          else
            if(0 < testScore && testScore <= 60)
            {
              g = 'F';
              WriteLine("\nThe Letter grade for a score of ", testScore, " is ", g);
            }
            //Error Handler - Prevents Crashing if Input is Invalid
            else
            {
              WriteLine("\nInvalid test score! You have quit the program. ");
            }
  }
}