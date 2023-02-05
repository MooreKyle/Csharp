using System;
using static System.Console;
using System.Globalization;
class ChatAWhile
{
   static void Main()
   {
      // Write your main here
      string[] area = {"262", "414", "608", "715", "815", "920"};
      double[] price = {0.07, 0.10, 0.05, 0.16, 0.24, 0.14};
      int x, minutes;
      double total = 0;
      string entryArea, entryMin;
      bool found = false;
      Write("What area code are you calling? ");
      entryArea = ReadLine();
      for(x = 0; x < area.Length && !found; ++x)
      {
          if(entryArea == area[x])
          {
            Write("How many minutes is your call? ");
            entryMin = ReadLine();
            minutes = Convert.ToInt32(entryMin);
            total = price[x] * minutes;
              WriteLine("Your phone call to area {0} costs {1} per minute", entryArea, price[x].ToString("C"));
            WriteLine("For {0} minutes the total is {1}", minutes, total.ToString("C"));
            found = true;
          }
      }
      if(!found)
        WriteLine("Sorry - no calls allowed to area {0}", entryArea);
   }
}
