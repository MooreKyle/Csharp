using System;
using static System.Console;
using System.Globalization;
class SalespersonDemo
{
   static void Main()
   {
     // Your code here
     RealEstateSalesperson diane = new RealEstateSalesperson("Diane", "Kendall", 0.06);
     GirlScout mandy = new GirlScout("Mandy", "Hernandez");
     diane.SalesSpeech();
     mandy.SalesSpeech();
     diane.MakeSale(100000);
     diane.MakeSale(150000);
     mandy.MakeSale(2);
     mandy.MakeSale(10);
     mandy.MakeSale(4);
     WriteLine("{0} sold {1} worth of real estate",
        diane.GetName(), diane.TotalValueSold.ToString("C0"));
     WriteLine("At {0}%, the total commission earned is {1}",
        diane.CommissionRate * 100,
        diane.TotalCommissionEarned.ToString("C"));
     WriteLine();
     WriteLine("{0} sold {1} boxes of cookie",
        mandy.GetName(), mandy.TotalBoxes);
   }
}

public interface ISellable
{
   void SalesSpeech();
   void MakeSale(int amount);
}

abstract class Salesperson
{
   protected string firstName;
   protected string lastName;
   public Salesperson(string first, string last)
   {
      FirstName = first;
      LastName = last;
   }
   public string GetName()
   {
      string fullName = FirstName + " " + LastName;
      return fullName;
   }
   public string FirstName {get; set;}
   public string LastName {get; set;}
}

class RealEstateSalesperson : Salesperson, ISellable
{
   public RealEstateSalesperson(string first, string last, double rate) : base(first, last)
   {
      CommissionRate = rate;
   }
   public void SalesSpeech()
   {
      WriteLine
       ("This property will double in value in the next ten years");
       WriteLine("Buy it now or regret it forever.");
       WriteLine();
   }
   public void MakeSale(int amt)
   {
      TotalValueSold += amt;
      TotalCommissionEarned = TotalValueSold * CommissionRate;
   }
   public int TotalValueSold {get; set;}
   public double TotalCommissionEarned {get; set;}
   public double CommissionRate {get; set;}
}

class GirlScout : Salesperson, ISellable
{
   public GirlScout(string first, string last) : base(first, last)
   {
      TotalBoxes = 0;
   }
   public void SalesSpeech()
   {
      WriteLine("Would you like to buy some cookies?");
      WriteLine("They are delicious and they help us go to camp.");
      WriteLine();
   }
   public void MakeSale(int boxes)
   {
      TotalBoxes += boxes;
   }
   public int TotalBoxes {get; set;}
}
