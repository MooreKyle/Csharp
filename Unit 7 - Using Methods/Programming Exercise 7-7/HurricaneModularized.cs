using System;
using static System.Console;
class Hurricane
{
   static void Main()
   {    
      // Write your main here.
      int wind;
      int category = 0;
      Write("Enter wind speed for hurricane >> ");
      wind = Convert.ToInt32(ReadLine());
      category = GetCategory(wind);
      if(category == 0)
          WriteLine("This is not a hurricane");
      else
          WriteLine("This is a category {0} hurricane", category);
   }
    public static int GetCategory(int wind)
   {
      // Write your GetCategory method here.
      int category = 0;
      int[] windLimits = {157, 130, 111, 96, 74};
      int[] categories = {5, 4, 3, 2, 1};
      for(int x = 0; x < windLimits.Length; ++x)
         if(wind >= windLimits[x])
         {
            category = categories[x];
            x = categories.Length;
         }
      return category;
   }
}
