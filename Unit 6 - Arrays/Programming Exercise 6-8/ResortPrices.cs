using System;
using static System.Console;
class ResortPrices
{
   static void Main()
   {
      // Write your main here
      int[] nights = {0, 3, 5, 8};
      double[] prices = {200, 180, 160, 145};
      int x;
      string entry;
      int nightsEntry;
      double perNight = 0;
      Write("How many nights is your stay? ");
      entry = ReadLine();
      nightsEntry = Convert.ToInt32(entry);
      x = nights.Length - 1;
      while(x >= 0)
      {
         if(nightsEntry >= nights[x])
         {
            perNight = prices[x];
            x = 0;
         }
         --x;
      }
      if(nightsEntry > 0)
         WriteLine("Price per night is {0}", perNight.ToString("C"));
         WriteLine("Total for {0} night(s) is {1}", nightsEntry, (nightsEntry * perNight).ToString("C"));
   }
}
