using System;
using static System.Console;
class MultiplicationTable
{
   static void Main()
   {
       // Write your main here.
       int num, prod;
       string inputString;
       Write("Enter a number: ");
       inputString = ReadLine();
       num = int.Parse(inputString);

          for(int x = 1; x <= 10; ++x)
          {
            prod = num * x;
            Write("{0} x {1}" + " = " + "{2}\n", x, num, prod);
          }
   }
}