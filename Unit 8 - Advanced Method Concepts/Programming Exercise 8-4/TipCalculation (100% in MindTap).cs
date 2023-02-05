using static System.Console;
class TipCalculation
{
   static void Main()
   {
      // Write your main here
      double price = 30.00;
      double tipRate = 0.20;
      int tipInDollars = 6;
      DisplayTipInfo(price, tipRate);
      DisplayTipInfo(price, tipInDollars);
   }

   public static void DisplayTipInfo(double price, double tipRate)
   {
     double tipInDollars = price * tipRate;
     double total = price + tipInDollars;
     WriteLine("Meal price: ${0}. Tip percent: {1}",
        price.ToString("F2"), tipRate.ToString("F2"));
     WriteLine("Tip in dollars: ${0}.  Total bill ${1}", 
        tipInDollars.ToString("F2"), total.ToString("F2"));
   }
   public static void DisplayTipInfo(double price, int tipInDollars)
   {
     double tipRate = tipInDollars / price;
     double total = price + tipInDollars;
     WriteLine("Meal price: ${0}. Tip percent: {1}",
        price.ToString("F2"), tipRate.ToString("F2"));
     WriteLine("Tip in dollars: ${0}.  Total bill ${1}",
        tipInDollars.ToString("F2"), total.ToString("F2"));
   }
}
