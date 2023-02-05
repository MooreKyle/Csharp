using static System.Console;
public class Averages
{
    public static void Main()
    {
       //Write your main here
       double[] array = {3, 4, 5, 6, 7, 8};
       Average(12, 15);
       Average(22.3, 44.5, 88.1);
       Average(array);
    }

    public static void Average(params double[] nums)
    {
        double total = 0;
        double avg;
        foreach(double number in nums)
        {
           Write("{0} ", number);
           total += number;
        }
        avg = total / nums.Length;
        WriteLine(" -- Average is {0}", avg);
    }
}