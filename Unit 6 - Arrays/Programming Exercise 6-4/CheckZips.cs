using static System.Console;
class CheckZips
{
   static void Main()
   {
      // Write your main here
      string[] zips = {"12789", "54012", "54481", "54982", "60007",
         "60103", "60187", "60188", "71244", "90210"};
      int x;
      string entryZip;
      bool zipFound = false;
      Write("Enter a ZIP code for delivery: ");
      entryZip = ReadLine();
      for(x = 0; x < zips.Length && !zipFound; ++x)
      {
          if(entryZip == zips[x])
          {
             Write("Delivery to {0} ok", entryZip);
             zipFound = true;
          }
      }
       if(!zipFound)
          WriteLine("Sorry - no delivery to {0}", entryZip);
   }
}
