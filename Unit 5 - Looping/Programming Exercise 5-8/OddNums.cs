using static System.Console;
class OddNums
{
   static void Main()
   {
      int num = 1;
      const int LIM = 99;
      const int END_OF_LINE = 10;
      int count = 1;
      while(num <= LIM)
      {
         Write("{0, 6}", num);
         if(count == END_OF_LINE)
         {
            WriteLine();
            count = 0;
         }
         ++count;
         num += 2;
      }   
      WriteLine();
   }

}
