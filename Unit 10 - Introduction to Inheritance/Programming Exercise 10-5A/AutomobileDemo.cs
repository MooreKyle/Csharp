using System;
using static System.Console; 
using System.Globalization;
class AutomobileDemo
{
   static void Main()
   {
     Automobile[] automobiles = new Automobile[8];
     int x, y;
     double grandTotal = 0;
     bool goodNum;
     for(x = 0; x < automobiles.Length; ++x)
     {
       automobiles[x] = new Automobile();
       Write("Enter automobile ID number ");
       automobiles[x].IdNumber = Convert.ToInt32(ReadLine());
       goodNum = true;
       for(y = 0; y < x; ++y)
       {
         if(automobiles[x].Equals(automobiles[y]))
            goodNum = false;
       }
       while(!goodNum)
       {
         Write("Sorry, the ID number " + 
            automobiles[x].IdNumber + " is a duplicate. " + 
            "\nPlease reenter ");
         automobiles[x].IdNumber = Convert.ToInt32(ReadLine());
         goodNum = true;
         for(y = 0; y < x; ++y)
         {
           if(automobiles[x].Equals(automobiles[y]))
              goodNum = false;
         }
       }
       Write("Enter make ");
       automobiles[x].Make = ReadLine();
       Write("Enter year ");
       automobiles[x].Year = Convert.ToInt32(ReadLine());
       Write("Enter price ");
       automobiles[x].Price = Convert.ToDouble(ReadLine());
     }
     Array.Sort(automobiles);
     WriteLine("\nSummary:\n");
     for(x = 0; x < automobiles.Length; ++x)
     {
       WriteLine(automobiles[x].ToString());
       grandTotal += automobiles[x].Price;
     }
     WriteLine("\nTotal for all Automobiles is " + grandTotal.ToString("C",
      CultureInfo.GetCultureInfo("en-US")));
   }
}
class Automobile : IComparable
{
  public Automobile(int num, string make, int year, double price)
  {
    IdNumber = num;
    Make = make;
    Year = year;
    Price = price;
  }
  public Automobile() : this(999, "zzz", 0, 0)
  {
  }
  public int IdNumber {get; set;}
  public string Make {get; set;}
  public int Year {get; set;}
  public double Price {get; set;}
  public override string ToString()
  {
    return(GetType() + " " + IdNumber + " " + Year + 
      " " + Make + " Price is " + Price.ToString("C", 
      CultureInfo.GetCultureInfo("en-US")));
  }

  public override bool Equals(Object e)
  {
    bool isEqual;
    Automobile temp = (Automobile)e;
    if(IdNumber == temp.IdNumber)
      isEqual = true;
    else
      isEqual = false;
    return isEqual;
  }

  public override int GetHashCode()
  {
    return IdNumber;
  }

  int IComparable.CompareTo(Object o)
  {
    int returnVal;
    Automobile temp = (Automobile)o;
    if(this.IdNumber > temp.IdNumber)
      returnVal = 1;
    else
      if(this.IdNumber < temp.IdNumber)
        returnVal = -1;
      else
        returnVal = 0;
    return returnVal;
  }
}
