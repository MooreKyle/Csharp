using static System.Console;
class Reverse3
{
   static void Main()
   {
      // Write your main here
      int firstInt = 23, middleInt = 45, lastInt = 67;
      WriteLine("The numbers are {0}, {1}, {2}", firstInt, middleInt, lastInt);
      Reverse(ref firstInt, ref middleInt, ref lastInt);
      WriteLine("The numbers are {0}, {1}, {2}", firstInt, middleInt, lastInt);
   }
   
   public static void Reverse(ref int a, ref int b, ref int c)
   {
       int temp = a;
       a = c;
       c = temp;
   }
}
