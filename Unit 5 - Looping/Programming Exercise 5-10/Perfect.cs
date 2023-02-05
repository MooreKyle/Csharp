using static System.Console;
class Perfect
{
   static void Main()
   {
      // Write your main here.
      int sum = 0, x = 0;
      for(int num = 1; num < 10000; num++)
      {
        for(int factor = 1; factor < num; factor++)
        {
            x = num % factor;
            if (x == 0)
                sum += factor;
        }
          if(sum == num)
          {
            WriteLine(num);
          }
          sum = 0;
      }
   }
}
