//Using Namespace Statements/Preprocessor Directives
using System;
using static System.Console;

//Class: MainClass
class MainClass
{
  //Function: Main
  public static void Main (string[] args)
  {
    //Declarations
    const int MAX = 9;
    int[] playerNum = {1, 2, 3, 4, 5, 6, 7, 8, 9};
    int numAtBats;
    int numHits;

    //Get Team Name via User Input
    Console.WriteLine ("Enter the Team name:(one time entry)");
    string name = Console.ReadLine();

    for(int counter = 1; counter <= MAX; ++counter)
    {
      WriteLine("Please enter the # of at bats: ");
      numAtBats = ReadLine();
      
      WriteLine("Please enter the # of hits: ");
      numHits = ReadLine();
    }
  }
}