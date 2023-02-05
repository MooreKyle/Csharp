using static System.Console;
class TurningDemo
{
   static void Main()
   {
      // Your code here
   }
}

public interface ITurnable
{
   void Turn();
}

class Page : ITurnable
{
   public void Turn()
   {
      WriteLine("You turn a page in a book");
   }
}

class Corner : ITurnable
{
   public void Turn()
   {
      WriteLine("You turn corners to go around the block");
   }
}

class Pancake : ITurnable
{
   public void Turn()
   {
      WriteLine("You turn a pancake when it's done on one side");
   }
}

class Leaf : ITurnable
{
   public void Turn()
   {
      WriteLine("A leaf turns colors in the fall");
   }
}
