using static System.Console;
using System.Globalization;
public class TestClassifiedAd
{
   public static void Main()
   {
    // Write your main here.
       ClassifiedAd myClassifiedAd = new ClassifiedAd();
       ClassifiedAd yourClassifiedAd = new ClassifiedAd();
       myClassifiedAd.Category = "Used cars";
       myClassifiedAd.Words = 100;
       yourClassifiedAd.Category = "Help wanted";
       yourClassifiedAd.Words = 60;
       WriteLine("The classified ad with {0} words in category {1} costs ${2}", myClassifiedAd.Words, 
          myClassifiedAd.Category, myClassifiedAd.Price.ToString("F2"));
       WriteLine("The classified ad with {0} words in category {1} costs ${2}", yourClassifiedAd.Words,
          yourClassifiedAd.Category, yourClassifiedAd.Price.ToString("F2"));
   }
}
class ClassifiedAd
{
    // Write your ClassifiedAd class here.
    const double PRICE_PER_WORD = 0.09;
    public int words;
    public double price;
    public string Category {get;set;}
    public int Words
    {
      get
      {
         return words;
      }
      set
      {
         words = value;
         price = words * PRICE_PER_WORD;
      }
    }
    public double Price
    {
       get
       {
          return price;
       }
    }
}
