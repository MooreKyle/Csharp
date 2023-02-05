using System;
using static System.Console;
using System.Globalization;
class PhotoDemo
{
   static void Main()
   {
      // Write your main here
      Photo stdPhoto = new Photo();
      Photo customPhoto = new Photo();
      MattedPhoto mattedPhoto = new MattedPhoto();
      FramedPhoto framedPhoto = new FramedPhoto();
      stdPhoto.Width = 8;
      stdPhoto.Height = 10;
      customPhoto.Width = 8;
      customPhoto.Height = 9;
      mattedPhoto.Width = 10;
      mattedPhoto.Height = 12;
      mattedPhoto.Color = "white";
      framedPhoto.Width = 8;
      framedPhoto.Height = 10;
      framedPhoto.Material = "silver";
      framedPhoto.Style = "modern";
      WriteLine(stdPhoto.ToString());
      WriteLine(customPhoto.ToString());
      WriteLine(mattedPhoto.ToString());
      WriteLine(framedPhoto.ToString());
   }
}

class Photo
{
   private double width = 0;
   private double height = 0;
   protected double price;
   private const double STDWIDTH1 = 8;
   private const double STDHEIGHT1 = 10;
   private const double STDPRICE1 = 3.99;
   private const double STDWIDTH2 = 10;
   private const double STDHEIGHT2 = 12;
   private const double STDPRICE2 = 5.99;
   private const double CUSTOMPRICE = 9.99;
   public double Width
   {
      get
      {
          return width;
      }
      set
      {
          width = value;
          SetPrice(0);
      }
   }
   public double Height
   {
      get
      {
         return height;
      }
      set
      {
         height = value;
         SetPrice(0);
      }
   }
   public double Price
   {
      get
      {
         return price;
      }
   }
   protected void SetPrice(double premium)
   {
      if(Width == STDWIDTH1 && Height == STDHEIGHT1)
         price = STDPRICE1;
      else
         if(Width == STDWIDTH2 && Height == STDHEIGHT2)
            price = STDPRICE2;
      else
         price = CUSTOMPRICE;
      price += premium;
   }
   public override string ToString()
   {
     return(GetType() + "    " + Width + " X " + Height + "  Price: $" + Price.ToString(""));
   }
}

class MattedPhoto : Photo
{
   public const double PREMIUM = 10;
   public string Color {get; set;}
   public override string ToString()
   {
     SetPrice(PREMIUM);
     return(GetType() + "   " + Color + " matting " +
       Width + " X " + Height + "  Price: $" + Price.ToString(""));
   }
}

class FramedPhoto : Photo
{
   private const double PREMIUM = 25;
   public string Material {get; set;}
   public string Style {get; set;}
   public override string ToString()
   {
       SetPrice(PREMIUM);
       return(GetType() + "    " + Style + ", " + Material + " frame. " +
          Width + " X " + Height + "   Price: $" + Price.ToString(""));
   }
}
