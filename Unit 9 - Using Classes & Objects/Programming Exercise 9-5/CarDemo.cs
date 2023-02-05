using static System.Console;
class CarDemo
{
   static void Main()
   {
      // Write your main here.
      Car c1 = new Car("Camaro", 25);
      Car c2 = new Car("Mustang");
      Display("Camaro at beginning", c1);
      ++c1;
      Display("Camaro after prefix increment", c1);
      Display("Mustang at beginning", c2);
      c2++;
      Display("Mustang after postfix increment", c2);
   }
   public static void Display(string message, Car s)
   {
       // Write your Display() method here.
       WriteLine(message);
       WriteLine("    Model: {0}  MPG: {1}.", s.Model, s.Mpg);
   }
   
}   
class Car
{
   public Car(string model, double mpg)
   {
      Model = model;
      Mpg = mpg;
   }
   public Car(string name) : this(name, 20)
   {
   }
   public string Model {get; set;}
   public double Mpg {get; set;}
   public static Car operator++(Car c)
   {
      ++c.Mpg;
      return c;
   }
}
