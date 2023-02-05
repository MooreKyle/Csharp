using System;
using static System.Console;
class SubscriptExceptionTest
{
   static void Main()
   {
       double[] array = {20.3, 44.6, 32.5, 46.7, 89.6,
                        67.5, 12.3, 14.6, 22.1, 13.6};
       int sub;
       const int QUIT = 99;
       Write("Enter a subscript value or {0} to quit >> ", QUIT);
       int.TryParse(ReadLine(), out sub);
       while(sub != QUIT)
       {
          try
          {
             WriteLine("The value is {0}", array[sub]);
          }
          catch(IndexOutOfRangeException e)
          {
             WriteLine(e.Message);
          }
          Write("Enter a subscript value or {0} to quit >> ", QUIT);
          int.TryParse(ReadLine(), out sub);
       }
   }
}
