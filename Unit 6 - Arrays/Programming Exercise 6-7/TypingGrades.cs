using System;
using static System.Console;
class TypingGrades
{
   static void Main()
   {
      // Write your main here
      int[] wordLimits = {0, 16, 31, 51, 76};
      char[] grades = {'F', 'D', 'C', 'B', 'A'};
      int x, speed;
      string entrySpeed;
      Write("How fast does the student type in words per minute? ");
      entrySpeed = ReadLine();
      speed = Convert.ToInt32(entrySpeed);
      for(x = wordLimits.Length - 1; x >= 0; --x)
        {
          if(speed >= wordLimits[x])
            {
              WriteLine("Typing {0} words per minute: Grade {1}", entrySpeed, grades[x].ToString());
              x = 0;
            }
        }
   }
}
