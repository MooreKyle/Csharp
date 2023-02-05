using System;
using static System.Console;
using System.Globalization;
public class FineForOverdueBooks
{
   public static void Main()
   {
      // Write your main here.
      int books;
      int days = 0;
      Write("Enter number of books that are overdue >> ");
      books = Convert.ToInt32(ReadLine());
      Write("Enter number of days that the {0} books are overdue >> ", books);
      days = Convert.ToInt32(ReadLine());
      DisplayFine(books, days);
   }
   public static void DisplayFine(int books, int days)
   {
      // Write your DisplayFine method here.
      const double FINE1 = 0.10;
      const double FINE2 = 0.20;
      const int DAY_FINE_INCREASES = 7;
      double fine;
      if(days <= DAY_FINE_INCREASES)
         fine = books * days * FINE1;
      else
         fine = books * FINE1 * DAY_FINE_INCREASES + books * FINE2 * (days - DAY_FINE_INCREASES);
      WriteLine("The fine for {0} book(s) for {1} day(s) is {2}", books, days, fine.ToString("C"));
   }
}
