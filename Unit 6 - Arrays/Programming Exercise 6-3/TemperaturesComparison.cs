using System;
using static System.Console;
class TemperaturesComparison
{
   static void Main()
   {
      // Write your main here
      int[] temperatures = new int[5];
      const int MIN = -30;
      const int MAX = 130;
      int maxSubscript = temperatures.Length - 1;
      int x;
      double average;
      bool ascending = true;
      bool descending = true;
      for(x = 0; x < temperatures.Length; ++x)
      {
         Write("Enter temperature {0} >> ", (x + 1));
         temperatures[x] = Convert.ToInt32(ReadLine());
         if(temperatures[x] < MIN || temperatures[x] > MAX)
         {
            Write("Out of range -- please reenter.  ");
            --x;
         }
      }
      for(x = 0; x < maxSubscript; ++x)
      {
          if(temperatures[x] >= temperatures[x + 1])
             ascending = false;
          if(temperatures[x] <= temperatures[x + 1])
             descending = false;
      }
      if(ascending)
      {
          Write("Getting warmer:  ");
          for(x = 0; x < temperatures.Length; ++x)
            Write("{0, 5}", temperatures[x]);
      }
      else
         if(descending)
         {
             Write("Getting cooler:");
             for(x = 0; x < temperatures.Length; ++x)
               Write("{0, 5}", temperatures[x]);
         }
         else
         {
             Write("It's a mixed bag: ");
             for(x = 0; x < temperatures.Length; ++x)
               Write("{0, 5}", temperatures[x]);
         }
       WriteLine();
       average = temperatures[0] + 
           temperatures[1] + 
           temperatures[2] + 
           temperatures[3] + 
           temperatures[4];
        Write("Average: {0}", average/temperatures.Length);
        WriteLine();
   }
}
