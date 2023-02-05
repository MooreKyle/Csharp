using System;
using static System.Console;
class StudentGradeDemo
{
   static void Main()
   {
       // Your code here
       try
       {
          ReportCard card1 = new ReportCard("Adams", 80, 85);
       }
       catch(ArgumentException e)
       {
          WriteLine("{0} {1}", "card1", e.Message);
       }
       try
       {
          ReportCard card2 = new ReportCard("Brown", 20, 75);
       }
       catch(ArgumentException e)
       {
          WriteLine("{0} {1}", "card2", e.Message);
       }
       try
       {
          ReportCard card3 = new ReportCard("Cook", 100, 99);
       }
       catch(ArgumentException e)
       {
          WriteLine("{0} {1}", "card3", e.Message);
       }
       try
       {
          ReportCard card4 = new ReportCard("Dee", -1, 85);
       }
       catch(ArgumentException e)
       {
          WriteLine("{0} {1}", "card4", e.Message);
       }
       try
       {
          ReportCard card5 = new ReportCard("Edwards", 80, 101);
       }
       catch(ArgumentException e)
       {
          WriteLine("{0} {1}", "card5", e.Message);
       }
   }
}

class ReportCard
{
   private string name;
   private int midterm;
   private int final;
   private double average;
   private char grade = 'F';
   public const int LOWVALID = 0;
   public const int HIGHVALID = 100;
   public int[] CUTOFFS = {90, 80, 70, 60};
   public char[] GRADES = {'A', 'B', 'C', 'D'};
   public ReportCard(string student, int mid, int fin)
   {
      if(mid < LOWVALID || mid > HIGHVALID)
         throw(new ArgumentException());
      if(fin < LOWVALID || fin > HIGHVALID)
         throw(new ArgumentException());
      average = (mid + fin) / 2.0;
      for(int x = CUTOFFS.Length - 1; x >= 0; --x)
      {
         if(average > CUTOFFS[x])
            grade = GRADES[x];
      }
      name = student;
      midterm = mid;
      final = fin;
      WriteLine("{0} report card created.", name);
      WriteLine("   Midterm: {0}  Final: {1}", midterm, final);
      WriteLine("   Average: {0}  Grade: {1}", average, grade);
    }
}
