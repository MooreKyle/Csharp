using static System.Console;
class DeliveryCharges
{
   static void Main()
   {
       // Write your main here
       string[] zips = {"12789", "54012", "54481", "54982", "60007",
         "60103", "60187", "60188", "71244", "90210"};
      double[] prices = {2.40, 3.00, 3.50, 4.00, 4.50, 5.00,
         5.25, 5.75, 6.10, 10.00};
       int x;
       string entryZip;
       bool zipFound = false;
       Write("Enter a ZIP code for delivery: ");
       entryZip = ReadLine();
       for(x = 0; x < zips.Length && !zipFound; ++x)
       {
           if(entryZip == zips[x])
             {
             WriteLine("Delivery to {0} ok", entryZip);
             WriteLine("Delivery charge is {0}", prices[x].ToString("C"));
             zipFound = true;
             }
       }
       if(!zipFound)
         WriteLine("Sorry - no delivery to {0}", entryZip);
   }
}
