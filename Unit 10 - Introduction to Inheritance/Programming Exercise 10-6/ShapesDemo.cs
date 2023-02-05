using static System.Console;
class ShapesDemo
{
   static void Main()
   {
      // Your code here
      Rectangle r1 = new Rectangle(3, 4);
      DisplayShapeStatistics(r1);
      Square s1 = new Square(3, 4);
      DisplayShapeStatistics(s1);
      s1.Height = 20;
      DisplayShapeStatistics(s1);
      Square s2 = new Square(6);
      DisplayShapeStatistics(s2);
      s2.Height = 20;
      DisplayShapeStatistics(s2);
      Triangle t1 = new Triangle(3, 4);
      DisplayShapeStatistics(t1);
      t1.Height = 20;
      DisplayShapeStatistics(t1);
   }
   static void DisplayShapeStatistics(GeometricFigure g)
   {
      WriteLine(g.GetType() + " Height: " + g.Height +
         " Width: " + g. Width + " Area: " + g.Area);
   }
}

abstract class GeometricFigure
{
   protected int height;
   protected int width;
   protected int area;
   public GeometricFigure(int h, int w)
   {
      Height = h;
      Width = w;
   }
   public abstract void ComputeArea();
   public int Height
   {
      get
      {
         return height;
      }
      set
      {
         height = value;
         ComputeArea();
      }
   }
   public int Width
   {
      get
      {
         return width;
      }
      set
      {
         width = value;
         ComputeArea();
      }
   }
   public int Area
   {
      get
      {
         return area;
      }
   }
}

class Rectangle : GeometricFigure
{
   public Rectangle(int h, int w) : base(h, w)
   {
   }
   public override void ComputeArea()
   {
      area = Width * Height;
   }
}

class Square : Rectangle
{
   public Square(int w, int h) : base(w, w)
   {
   }
   public Square(int w) : base(w,w)
   {
   }
   public new int Height
   {
      get
      {
         return height;
      }
      set
      {
         height = value;
         width = height;
         ComputeArea();
      }
   }
   public new int Width
   {
      get
      {
         return width;
      }
      set
      {
         width = value;
         height = width;
         WriteLine("XXX");
         ComputeArea();
      }
   }
}

class Triangle : GeometricFigure
{
   public Triangle(int h, int w) : base(h, w)
   {
   }
   public override void ComputeArea()
   {
      area = Width * Height / 2;
   }
}

