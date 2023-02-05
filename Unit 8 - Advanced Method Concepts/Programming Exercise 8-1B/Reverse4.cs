using static System.Console;
class Reverse4
{
   static void Main()
   {
       // Write your main here
       int firstInt = 23, secondInt = 45, thirdInt = 55, lastInt = 67;
       WriteLine("The numbers are {0}, {1}, {2}, {3}", firstInt, secondInt, thirdInt, lastInt);
       Reverse(ref firstInt, ref secondInt, ref thirdInt, ref lastInt);
       WriteLine("The numbers are {0}, {1}, {2}, {3}", firstInt, secondInt, thirdInt, lastInt);
   }

   public static void Reverse(ref int a, ref int b,
      ref int c, ref int d)
   {
       int temp = a;
       a = d;
       d = temp;
       temp = b;
       b = c;
       c = temp;
   }
}
