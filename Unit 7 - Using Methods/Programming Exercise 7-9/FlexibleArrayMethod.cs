using static System.Console;
public class FlexibleArrayMethod
{
   static void Main()
   {
       // Write your main here
        int[] array1 = {3, 4, 5};
        int[] array2 = {33, 44, 55, 66, 77};
        int[] array3 = {333, 444, 555, 666, 777, 888, 999};
        DisplayAndSum(array1);
        DisplayAndSum(array2);
        DisplayAndSum(array3);
   }
   public static void DisplayAndSum(int[] arr)
   {
        //  Write your DisplayAndSum method here.
        int total = 0;
        for(int x = 0; x < arr.Length; ++x)
        {
            Write("{0}  ", arr[x]);
            total += arr[x];
        }
        WriteLine("\nTotal is {0}\n--------------\n", total);
   }
}
