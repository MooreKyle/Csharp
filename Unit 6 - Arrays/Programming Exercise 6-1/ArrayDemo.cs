using System;
using static System.Console;
class ArrayDemo
{
   enum Menu
   {
      IN_ORIGINAL_ORDER = 1, REVERSE_ORDER, SPECIFIC_POSITION, QUIT
   }
   static void Main()
   {
       // Write your main here
       int[] nums = {7, 6, 3, 2, 10, 8, 4, 5, 9, 1};
       int pos = 1;
       int option;
       WriteLine("Choose one:");
       foreach(string menuOption in Enum.GetNames(typeof(Menu)))
       {
          WriteLine("{0}   {1}", pos, menuOption);
          ++pos;
       }
       Write("                  >> ");
       option = Convert.ToInt32(ReadLine());
       while(option != (int)Menu.QUIT)
       {
          if(option == (int)Menu.IN_ORIGINAL_ORDER)
          {
              for(int x = 0; x < nums.Length; ++x)
                 Write("{0, 5}", nums[x]);
          }
          else
             if(option == (int)Menu.REVERSE_ORDER)
             {
                for(int x = nums.Length -1; x >= 0; --x)
                   Write("{0, 5}", nums[x]);
             }
             else
                if(option == (int)Menu.SPECIFIC_POSITION)
                {
                   Write("Enter position (starting with 0) >> ");
                   pos = Convert.ToInt32(ReadLine());
                   WriteLine("Number in position {0} is {1}", pos, nums[pos]);
                }
                else
                   WriteLine("****** Sorry -- invalid option");
              WriteLine("\nChoose one:");
          pos = 1;
          foreach(string menuOption in Enum.GetNames(typeof(Menu)))
          {
             WriteLine("{0}  {1}", pos, menuOption);
             ++pos;
          }
          Write("                 >> ");
          option = Convert.ToInt32(ReadLine());
       }
   }  
}
