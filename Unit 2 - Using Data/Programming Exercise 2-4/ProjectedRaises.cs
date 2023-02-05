using System;
using static System.Console;
using System.Globalization;
class ProjectedRaises
{
   static void Main()
   {
       // Write your main here
       const double RAISE = 0.04;
       double salary1 = 25000, salary2 = 38000, salary3 = 51000;

       WriteLine("Next year's salary for the first employee will be {0}", (salary1 + salary1 * RAISE).ToString("C"));
       WriteLine("Next year's salary for the second employee will be {0}", (salary2 + salary2 * RAISE).ToString("C"));
       WriteLine("Next year's salary for the third employee will be {0}", (salary3 + salary3 * RAISE).ToString("C"));
   }
}
