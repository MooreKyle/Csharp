//Using namespace: System & System.Threading
using System;
using System.Threading;

//Class: mainClass
class mainClass
  {
  //Function: Main
  public static void Main (string[] args)
    {
    //Display Info & Program Summary
    Console.WriteLine ("\n\nAuthor: Kyle Moore\nDate:January 19, 2019\n\nThis Program will display the phrase 'Hello, World!' with one word per line.");

    //Sleep for 5 seconds (5000 Milliseconds)
    Thread.Sleep(5000);

    //Display "Hello, World!" to System Console
    Console.WriteLine ("\nHello,\nWorld!");

    //Sleep for 5 seconds (5000 Milliseconds)
    Thread.Sleep(5000);

    //Explanation of Program's Functioning in C#
    Console.WriteLine ("\nThe 'System' namespace reduces repetition in the code for statements that use this specific namespace clause. 'Console.WriteLine' is the syntax for prompting output, which is string data, to the user, This displays info about the program, and the program's purpose. After these strings display on the system console, the program halts for 5 seconds with the 'Thread.Sleep' function. Then, the program displays 'Hello, World!', with one word per line.");
    }
  }
