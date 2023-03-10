using static System.Console;
class FractionDemo
{
   static void Main()
   {
     Fraction[] f = new Fraction[4];
      Fraction answer = new Fraction();
      int x, y;
      for(x = 0; x < f.Length; ++x)
      {
         f[x] = new Fraction();
         GetData(f[x]);
      }
      WriteLine("Addition");
      for(x = 0; x < f.Length; ++x)
         for(y = 0; y < f.Length; ++y)
         {
            answer = f[x] + f[y];
            WriteLine("{0} + {1} = {2}",
              f[x].FracString(), f[y].FracString(),
              answer.FracString());
         }
      WriteLine("\nMultiplication");
      for(x = 0; x < f.Length; ++x)
         for(y = 0; y < f.Length; ++y)
         {
            answer = f[x] * f[y];
            WriteLine("{0} * {1} = {2}",
              f[x].FracString(), f[y].FracString(),
              answer.FracString());
         }
   }
   static void GetData(Fraction f)
   {
      int temp;
      Write("Enter whole number portion of fraction ");
      int.TryParse(ReadLine(), out temp);
      f.WholeNum = temp;
      Write("Enter numerator ");
      int.TryParse(ReadLine(), out temp);
      f.Numerator = temp;
      Write("Enter denominator ");
      int.TryParse(ReadLine(), out temp);
      f.Denominator = temp;
   }
}   
class Fraction
{
   private int wholeNum;
   private int numerator;
   private int denominator;
   
   public Fraction(int w, int n, int d)
   {
      WholeNum = w;
      Numerator = n;
      Denominator = d;
   }
   public Fraction(int n, int d) : this(0, n, d)
   {
   }
   public Fraction() : this(0, 0, 1)
   {
   }
   public int WholeNum
   {
      get
      {
         return wholeNum;
      }
      set
      {
         wholeNum = value;
      }
   }
   public int Numerator
   {
      get
      {
         return numerator;
      }
      set
      {
         numerator = value;
      }
    }
    public int Denominator
    {
       get
       {
          return denominator;
       }
       set
       {
          if(value != 0)
             denominator = value;
          else
             denominator = 1;
       }
    }
    public static Fraction operator+(Fraction f1, Fraction f2)
    {
       int num1 = (f1.WholeNum * f1.Denominator + f1.Numerator) *            
           f2.Denominator;
       int num2 = (f2.WholeNum * f2.Denominator + f2.Numerator) *
           f1.Denominator;
       int num = num1 + num2;
       int denom = f1.Denominator * f2.Denominator;
       Fraction newFrac = new Fraction(num, denom);
       newFrac.Reduce();
       return newFrac;
    }
    public static Fraction operator*(Fraction f1, Fraction f2)
    {
       int num1 = (f1.WholeNum * f1.Denominator + f1.Numerator);
       int num2 = (f2.WholeNum * f2.Denominator + f2.Numerator);
       int num = num1 * num2;
       int denom = f1.Denominator * f2.Denominator;
       Fraction newFrac = new Fraction(num, denom);
       newFrac.Reduce();
       return newFrac;
    }
    public void Reduce()
    {
       int gcd;
       int y;
       if(numerator >= denominator)
       {
    	  wholeNum += numerator / denominator;
	  numerator = numerator % denominator;
       }
       gcd = 1;
       for(y = numerator; y > 0; --y)
       {
	  if(numerator % y == 0 && denominator % y == 0)
          {
             gcd = y;
             y = 0;
          }
       }
       numerator /= gcd;
       denominator /= gcd;
     }
     public string FracString()
     {
        string fracString;
        if(WholeNum == 0 && Numerator == 0)
             fracString = "0";
        else
          if(WholeNum == 0)
             fracString = Numerator + "/" + Denominator;
        else
          if(Numerator == 0)
             fracString = "" + WholeNum;
          else
             fracString = WholeNum + " " + Numerator +
                "/" + Denominator;
        return fracString;
     }    
}
