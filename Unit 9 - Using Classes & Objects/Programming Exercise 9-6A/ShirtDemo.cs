using static System.Console;
class ShirtDemo
{
   static void Main()
   {
      // Write your main here
      Shirt shirt1, shirt2, shirt3, shirt4, shirt5;
      shirt1 = new Shirt();
      shirt2 = new Shirt();
      shirt3 = new Shirt();
      shirt4 = new Shirt();
      shirt5 = new Shirt();
      shirt1.Material = "cotton";
      shirt1.Color = "white";
      shirt1.Size = "L";
      shirt2.Material = "cotton";
      shirt2.Color = "blue";
      shirt2.Size = "XL";
      shirt3.Material = "polyester";
      shirt3.Color = "pink";
      shirt3.Size = "M";
      shirt4.Material = "silk";
      shirt4.Color = "yellow";
      shirt4.Size = "S";
      shirt5.Material = "silk";
      shirt5.Color = "white";
      shirt5.Size = "XXL";
      Display(shirt1, shirt2, shirt3);
      WriteLine();
      Display(shirt1, shirt2, shirt3, shirt4);
      WriteLine();
      Display(shirt1, shirt2, shirt3, shirt4, shirt5);
   }
   public static void Display(params Shirt[] shirts)
   {
      WriteLine("{0, -12}{1, -10}{2, -6}",
         "Material", "Color", "Size");
      foreach(Shirt shirt in shirts)
      {
         WriteLine(" {0, -11}{1, -10}{2, -6}",
            shirt.Material, shirt.Color, shirt.Size);
      }
   }
}

class Shirt
{
   public string Material {get; set;}
   public string Color {get; set;}
   public string Size {get; set;}
}
