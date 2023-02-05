using static System.Console;
class Sum200
{
   static void Main()
   {
     // Write your main here.
     int sum = 0;
     for(int x = 1; x <= 200; x++)
     {
       sum += x;
       if(x == 100)
          Write("Sum of the first 100 numbers is: {0}\n", sum);
       else
          continue;
     }
     Write("Sum of 200 numbers is: {0}\n", sum);
   }
}
