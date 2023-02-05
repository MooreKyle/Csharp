using System;
using static System.Console;
class HomeSales
{
   static void Main()
   {
      char letter;
      string inputString;
      double sale, dTotal = 0, eTotal = 0, fTotal = 0, grandTotal;
      WriteLine("Enter a saleperson initials: ");
      inputString = ReadLine();
      letter = Convert.ToChar(inputString);
      while (letter != 'Z' && letter != 'z')
      {
          if (letter != 'd' && letter != 'D' && letter != 'e' && letter != 'E' && letter != 'f' && letter != 'F')
          {
              WriteLine("Sorry - invalid salesperson");
          }
          else
          {
              WriteLine("Enter amount of the sale: ");
              inputString = ReadLine();
              sale = Convert.ToDouble(inputString);
              if (letter == 'd' || letter == 'D')
                  dTotal += sale;
              else if (letter == 'e' || letter == 'E')
                  eTotal += sale;
              else 
                  fTotal += sale;
          }
          WriteLine("Enter the next salesperson initial or Z to quit >>");
          inputString = ReadLine();
          letter = Convert.ToChar(inputString);
              
      }
       WriteLine("Danielle sold $"+ dTotal.ToString()+".00");
       WriteLine("Edward sold $"+ eTotal.ToString()+".00");
       WriteLine("Francis sold $"+ fTotal.ToString()+".00");
       grandTotal = eTotal + dTotal + fTotal;
       WriteLine("The Total sales were {0,5}", grandTotal.ToString("C"));
       if(dTotal > eTotal && dTotal > fTotal)
         WriteLine("Danielle sold the most");
      else if(eTotal > dTotal && eTotal > fTotal)
         WriteLine("Edward sold the most");
       else if(fTotal > dTotal && fTotal > eTotal)
         WriteLine("Francis sold the most");
       else
           WriteLine("There was a tie");

    
   }
}