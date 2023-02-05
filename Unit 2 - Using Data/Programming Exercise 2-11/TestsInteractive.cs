using System;
using static System.Console;
class TestsInteractive
{
   static void Main()
   {
       // Write your main here
       int ttl = 0;
       WriteLine("Enter a Score: ");// entry 1
       ttl = ttl + int.Parse(ReadLine());
       WriteLine("Enter a Score: ");// entry 2
       ttl = ttl + int.Parse(ReadLine());
       WriteLine("Enter a Score: ");// entry 3
       ttl = ttl + int.Parse(ReadLine());
       WriteLine("Enter a Score: ");// entry 4
       ttl = ttl + int.Parse(ReadLine());
       WriteLine("Enter a Score: ");// entry 5
       ttl = ttl + int.Parse(ReadLine());
       WriteLine("Enter a Score: ");// entry 6
       ttl = ttl + int.Parse(ReadLine());
       WriteLine("Enter a Score: ");// entry 7
       ttl = ttl + int.Parse(ReadLine());
       WriteLine("Enter a Score: ");// entry 8
       ttl = ttl + int.Parse(ReadLine());
       double avg = ((double) ttl / 8);
       WriteLine("The average of the scores is {0}", avg.ToString("F2"));
   }
}
