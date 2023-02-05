using static System.Console;
public class Auction
{
   static void Main()
   {
       // Write your main here
       string bid;
       int intBid;
       double doubleBid;
       const int MIN = 10;
       Write("Please enter your bid >> ");
       bid = ReadLine();
       if(int.TryParse(bid, out intBid))
          AcceptBid(intBid, MIN);
       else
          if(double.TryParse(bid, out doubleBid))
             AcceptBid(doubleBid, MIN);
          else
             AcceptBid(bid, MIN);
   }
    
   public static void AcceptBid(int bid, int min)
   {
     if(bid >= min)
        WriteLine("Bid accepted");
     else
        WriteLine("Bid not high enough");
   }
   public static void AcceptBid(double bid, int min)
   {
     if(bid >= min)
        WriteLine("Bid accepted");
     else
        WriteLine("Bid not high enough");
   }
   public static void AcceptBid(string bid, int min)
   {
     double doubleBid;
     string dollarString = " dollars";
     if(bid.Substring(0,1).Equals("$"))
        if(double.TryParse(bid.Substring(1, bid.Length - 1), out doubleBid))
           AcceptBid(doubleBid, min);
        else
           WriteLine("Bid was not in correct format");
     else
     {
         if(bid.Substring(bid.Length - dollarString.Length, dollarString.Length).Equals(dollarString))
         {
            if(double.TryParse(bid.Substring(0, bid.Length - 8), out doubleBid))
               AcceptBid(doubleBid, min);
            else
               WriteLine("Bid was not in correct format");
         }
        else
            WriteLine("Bid was not in correct format");
     }
   }
}
