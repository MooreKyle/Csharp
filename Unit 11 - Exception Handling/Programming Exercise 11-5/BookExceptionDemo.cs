using System;
using static System.Console;
using System.Globalization;
class BookExceptionDemo
{
   static void Main()
   {
       // Your code here
       Book[] book = new Book[5];
       int x;
       string title = "";
       string author = "";
       double price = 0;
       int pages = 0;
       for(x = 0; x < book.Length; ++x)
       {
          try
          {
             Write("Enter title ");
             title = ReadLine();
             Write("Enter author ");
             author = ReadLine();
             Write("Enter price ");
             price = Convert.ToDouble(ReadLine());
             Write("Enter pages ");
             pages = Convert.ToInt32(ReadLine());
             book[x] = new Book(title, author, price, pages);
          }
          catch(FormatException fe)
          {
             WriteLine(fe.Message);
             book[x] = new Book(title, author, 0, 0);
          }
          catch(BookException be)
          {
             WriteLine(be.Message);
             book[x] = new Book(title, author,
               (pages * Book.RATE), pages);
          }
       }
       for(x = 0; x < book.Length; ++x)
       {
          WriteLine(book[x].ToString());
       }
   }
}

class Book
{
   private string title;
   private string author;
   private double price;
   private int pages;
   public const double RATE = 0.10;
   public Book(string title, string author, double price,
      int pages)
   {
      Title = title;
      Author = author;
      if(price > RATE * pages)
         throw(new BookException(title, price, pages));
      Price = price;
      Pages = pages;
   }
   public string Title
   {
      get
      {
         return title;
      }
      set
      {
         title = value;
      }
   }
   public string Author
   {
      get
      {
         return author;
      }
      set
      {
         author = value;
      }
   }
   public double Price
   {
      get
      {
         return price;
      }
      set
      {
         price = value;
      }
   }
   public int Pages
   {
      get
      {
         return pages;
      }
      set
      {
         pages = value;
      }
   }
   public new string ToString()
   {
      return(title + " by " + author + " Price " +
         price.ToString("C") + " " + pages + " pages.");
   }
}

public class BookException : Exception
{
   public BookException(string title, double price, int pages) : 
      base("For " + title + ", ratio is invalid.\n...Price is " + 
      price.ToString("C") + " for " + pages + " pages.")
   {
   }
}
