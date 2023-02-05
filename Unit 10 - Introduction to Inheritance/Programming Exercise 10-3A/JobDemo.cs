using System;
using static System.Console;
using System.Globalization;
class JobDemo
{
   static void Main()
   {
     // Your code here
     Job job1 = new Job(111, "Smith", "exterior paint", 20);
     Job job2 = new Job(222, "Vega", "gutter clean", 4);
     Job job3 = new Job(111, "Land", "blacktop drive", 10);
     WriteLine(job1.ToString());
     WriteLine(job2.ToString());
     WriteLine(job3.ToString());
     CompareNumbers(job1, job2);
     CompareNumbers(job1, job3);
   }
   internal static void CompareNumbers(Job job1, Job job2)
   {
       if(job1.Equals(job2))
         WriteLine("{0} for {1} has the same job " +
         "number as " + "{2} for {3}",
         job1.JobNumber, job1.Customer,
         job2.JobNumber, job2.Customer);
   }
    
}

class Job
{
   private double hours;
   private double price;
   public const double RATE = 45.00;
   public Job(int num, string cust, string desc, double hrs)
   {
      JobNumber = num;
      Customer = cust;
      Description = desc;
      Hours = hrs;
   }
   public int JobNumber {get; set;}
   public string Customer {get; set;}
   public string Description {get; set;}
   public double Hours
   {
      get
      {
         return hours;
      }
      set
      {
         hours = value;
         price = hours * RATE;
      }
   }
   public double Price
   {
      get
      {
         return price;
      }
   }
   public override string ToString()
   {
      return(GetType() + " " + JobNumber + " " + Customer + " " +
        Description + " " + Hours + " hours @$" + RATE.ToString("F2") +
        " per hour. Total price is $" + Price.ToString("F2"));
   }
   public override bool Equals(Object e)
   {
      bool equal;
      Job temp = (Job)e;
      if(JobNumber == temp.JobNumber)
        equal = true;
      else
        equal = false;
      return equal;
   }
   public override int GetHashCode()
   {
      return JobNumber;
   }
}
