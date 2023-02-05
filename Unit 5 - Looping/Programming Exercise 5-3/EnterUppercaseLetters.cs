using System;
using static System.Console;
class EnterUppercaseLetters
{
   static void Main()
   {
      // Write your main here.
      char letter;
      string inputString;
      const char QUIT = '!';
      Write("Enter an uppercase letter >> ");
      inputString = ReadLine();
      letter = Convert.ToChar(inputString);
      while(letter != '!')
      {
        if(letter >= 'A' && letter <= 'Z')
          WriteLine("OK");
        else
          WriteLine("Sorry - that was not an uppercase letter.");
        Write("Enter an uppercase letter or {0} to quit ", QUIT);
        inputString = ReadLine();
        letter = Convert.ToChar(inputString);
      }
   }
}
