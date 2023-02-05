using static System.Console;
class DisplayMultiplicationTable
{
   static void Main()
   {
      int first, second;
      const int LIM = 10;
      Write("     ");
      for(first = 1; first <= LIM; ++first)
         Write("{0, 5}", first);
      WriteLine();
      for(int count = 0; count < 60; ++count)
         Write("_");
      WriteLine();
      for(first = 1; first <= LIM; ++first)
      {   
         Write("{0,5}", first);
         for(second = 1; second <= LIM; ++second)
            Write("{0, 5}", first * second);      
         WriteLine();
      }

   }
}
