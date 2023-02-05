using System;
using static System.Console;
using System.Globalization;
class SalesTaxDemo2
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
          sales[x].InventoryNumber, sales[x].Amount.ToString("C", CultureInfo.GetCultureInfo("en-US")));
       WriteLine("     Tax is {0}", sales[x].Tax.ToString("C", CultureInfo.GetCultureInfo("en-US")));
     }
     Array.Sort(sales);
     WriteLine("------------Sorted--------------");
     for(x = 0; x < sales.Length; ++x)
     {
       WriteLine("Sale # {0} Amount: {1} Sale {2}", (x + 1), sales[x].InventoryNumber,
          sales[x].Amount.ToString("C", CultureInfo.GetCultureInfo("en-US")));
       WriteLine("     Tax is {0}", sales[x].Tax.ToString("C", CultureInfo.GetCultureInfo("en-US")));
     }
   }
}

class Sale : IComparable
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
  int IComparable.CompareTo(Object o)
  {
    int returnVal;
    Sale temp = (Sale)o;
    if(this.Tax > temp.Tax)
        returnVal = 1;
    else
        if(this.Tax < temp.Tax)
            returnVal = -1;
        else
            returnVal = 0;
    return returnVal;
  }
}
