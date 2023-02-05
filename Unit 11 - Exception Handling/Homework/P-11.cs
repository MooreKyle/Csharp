//Preprocessor Directives/using Statements
using System;
using static System.Console;
using System.Globalization;

//class: MainClass
class MainClass
{

  //Function: Main
  public static void Main (string[] args)
  {
    //Declarations
    int dividend, divisor, quotient, num, newNum;

    //Assignment/Execution Statements

    //Program Summary
    WriteLine("\nThis program will demonstrate the use of 4 exception classes in C#: System.ArithmeticException, System.FormatException, System.InvalidCastException, and System.NullReferenceException.\n\n");

    //System.ArithmeticException Handler - Invokes DivideByZeroException
    try
    {
      WriteLine("Please enter a dividend (number to be divided by another number): ");
      dividend = Convert.ToInt32(ReadLine());
      WriteLine("\nPlease enter a divisor (number to divide into the dividend) (or enter zero (0) to trigger an ArithmeticException): ");
      divisor = Convert.ToInt32(ReadLine());
      quotient = dividend / divisor;
      WriteLine("The quotient is {0}.", quotient);
    }
    catch(ArithmeticException ae)
    {
      WriteLine(ae.Message);
      WriteLine("Error Code 1001: You have attempted to divide by 0. The world has come to an end! ");
    }

    //System.FormatException Handler - Number Doubler
    try
    {
      WriteLine("\n\nPlease enter a number to be doubled (or enter a non-numeric value (such as a string or character) to trigger a FormatException): ");
      num = Convert.ToInt32(ReadLine());
      newNum = num * 2;
      WriteLine("The new number is {0}.", newNum);
    }
    catch(FormatException fe)
    {
      WriteLine(fe.Message);
      WriteLine("Error Code 2002: A non-numeric value was entered! Foolish mortal.");
    }

    //System.InvalidCastException Handler - Data Type Converter (Does not work?)
    object obj = new Object();
    int i;

    WriteLine("\n\nPlease enter an integer for conversion (Entering an integer will trigger the Invalid Cast Exception): ");
    i = Convert.ToInt32(ReadLine());

    try
    {
      i = (int)obj;
      WriteLine("The value is {0}.", i);
    }
    catch (InvalidCastException ice)
    {
      WriteLine(ice.Message);
      WriteLine("Error Code 3003: The Invalid Cast Exception has occurred. This is blasphemy! This is madness!");
    }

    //System.NullReferenceException Handler - Convert a Person's name to Uppercase Letters
    string name = null;
    WriteLine("\n\nPlease enter your entire name in lowercase letters Mr./Ms. Exceptional: ");
    name = ReadLine();
  
    try
    {
      string newName;
      newName = name;
      newName = null;
      newName.ToUpper();
    }
    catch(NullReferenceException nre)
    {
      WriteLine(nre.Message);
      WriteLine("Error Code 4004: A Null Reference Exception occurred. You messed up big time hooman!");
    }
  }
}





//**********Notes & Unused Code**********

//System.ArithmeticException - "Thrown for errors in an arithmetic, casting, or conversion operation."
//System.FormatException - "Thrown when the format of an argument does not meet the parameter specifications of the invoked method."
//System.InvalidCastException - "Thrown for an invalid casting or explicit conversion"
//System.NullReferenceException - "Thrown when there is an attempt to dereference a null object reference"

      //name.ToUpper();
      //WriteLine("{0} is a nice name!", name);