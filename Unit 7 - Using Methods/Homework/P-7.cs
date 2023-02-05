//Preprocessor Directives/using Statements
using System;
using static System.Console;
//class: main
class main
{
  //Main
  public static void Main (string[] args)
  {
    //Declarations
    int arg;

    //Program Summary
    Console.WriteLine("\nThis program will receive an integer value and return the index of that value for it's Fibonacci series.");
    //Prompt User for Integer & Convert Value
    Write("\nPlease enter an integer value: ");
    arg = Convert.ToInt32(ReadLine());
    //Call Function: Fibonnaci: return n & 
    WriteLine("\nThe index value of {0} is {1}.", arg, Fibonacci(arg).ToString());
  }

  //Function: Fibonacci
  public static int Fibonacci(int n)
  {
    WriteLine("Successfully accessed the Fibonacci Function!");

    //Nested if-else Structure - return -1 if n = 12
    /*if(n == 12)
    {
      n = -1;
      return n;
    }
    else
      if(n < 12 || n > 12)
      {
        //Placeholder text - Perform all tasks in Fibonacci Function here & place the code here when fully complete
        return 0;
      }
      else
      {
        //Error Handler - return -1 for invalid values
        return -1;
      }*/

    //Scope Variable Declarations
    int previousNum = 0;
    int currentNum = 1;
    int newNum = 0;

    for(int i = 0; i < n; ++i)
    {
      //Sum previous + current numbers = new number
      newNum = previousNum + currentNum;
      //Setter - set current number value to be previous number value
      previousNum = currentNum;
      //Setter - set new number value to be current number value
      currentNum = newNum;
    }

    //newNum = currentNum;
    n = newNum;
    return n;
    
  }
}


//WriteLine("\nThe index value of {0} is {1}", arg, Fibonacci(arg).ToString("C"));