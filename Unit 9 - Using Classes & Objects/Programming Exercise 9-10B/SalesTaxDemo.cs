using System;
using static System.Console;
using System.Globalization;
class SalesTaxDemo
{
   static void Main()
   {
     Sale[] sales = new Sale[10];
     int x;
     string entryString = "";
     for(x = 0; x < sales.Length; ++x)
     {
       sales[x] = new Sale();
       Write("Enter inventory number #{0} >> ", x + 1);
       sales[x].InventoryNumber = ReadLine(); // input InventoryNumber
       Write("Enter amount of sale >> ");
       entryString = ReadLine();
       sales[x].Amount = Convert.ToDouble(entryString); // input amount
     }
     for(x = 0; x < sales.Length; ++x)
     { // printing details of every sale
       WriteLine("Sale # {0} Amount: {1} Sale {2}", (x + 1), 
          sales[x].InventoryNumber, sales[x].Amount.ToString("C"));
       WriteLine("     Tax is {0}", sales[x].Tax.ToString("C"));
     }
   }
}

class Sale
{ // class definition of Sale
  private double amount;
  private double tax;
  public const double LIMIT = 100;
  public const double LOWRATE = 0.08;
  public const double HIGHRATE = 0.06;
  public string InventoryNumber {get; set;}
  public double Amount
  {
    get
    {
      return amount;
    }
    set
    {
      amount = value;
      CalculateTax();
    }
  }
  public double Tax
  {
    get
    {
      return tax;
    }
  }
  private void CalculateTax()
  {
    if(Amount <= LIMIT)
      tax = Amount * LOWRATE;
    else
    {
      tax = LIMIT * LOWRATE + (Amount - LIMIT) * HIGHRATE;
    }
  }
}
