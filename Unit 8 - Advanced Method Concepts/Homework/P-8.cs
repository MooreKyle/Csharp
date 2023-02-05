//Preprocessor Directives/Using Statements
using static System.Console;
using System;

//Class: MainClass
class MainClass
{
  //Method: Main
  public static void Main (string[] args)
  {
    //Declarations
    //int length = 1, width = 2, height = 3;

    //Program Summary
    WriteLine("\nThis program will use a method to pass 3 parameters: length, width, and height. If any of these are not passed to the method, default values will be assigned.");

    //Prompt user for length, width, & height
    /*length = Convert.ToInt32(ReadLine());
    width = Convert.ToInt32(ReadLine());
    height = Convert.ToInt32(ReadLine());*/

    //Call Method: method1
    method1(1, 2, 3);
  }

  //Method: method1
  public static void method1(int length, int width, int height)
  {
    //Default Values for Parameters - if any value isn't passed to method
    length = 4;
    width = 5;
    height = 6;
    //Display current values of length, width, height to user
    WriteLine("length: {0}, width: {1}, height: {2}", length, width, height);
  }

}