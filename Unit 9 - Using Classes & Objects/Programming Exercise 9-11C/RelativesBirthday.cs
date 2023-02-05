using System;
using static System.Console;
class RelativesList
{
   static void Main()
   {
      Relative[] relativeArray = new Relative[12];
      int x;
      int m;
      string findRel;
      bool found = false;
      for(x = 0; x < relativeArray.Length; ++x)
      {
         relativeArray[x] = new Relative();
         Write("Enter your relative's name ");
         relativeArray[x].Name = ReadLine();
         Write("Enter {0}'s relationship to you ", relativeArray[x].Name);
         relativeArray[x].Relationship = ReadLine();
         Write("Enter your relative's birth month ");
         int.TryParse(ReadLine(), out m);
         relativeArray[x].Month = m;
         Write("Enter your relative's birth day ");
         int.TryParse(ReadLine(), out m);
         relativeArray[x].Day = m;
         Write("Enter your relative's birth year ");
         int.TryParse(ReadLine(), out m);
         relativeArray[x].Year = m;
      }
      Array.Sort(relativeArray);
      WriteLine("\nSorted relatives: ");
      for(x = 0; x < relativeArray.Length; ++x)
         WriteLine("{0,-15}{1,-15}{2}/{3}/{4}",
            relativeArray[x].Name, relativeArray[x].Relationship,
            relativeArray[x].Month, relativeArray[x].Day,
            relativeArray[x].Year);
      Write("Enter the name of the relative whose birthday you want to find ");
      findRel = ReadLine();
      for(x = 0; x < relativeArray.Length; ++x)
      {
        if(relativeArray[x].Name.Equals(findRel))
        {
          WriteLine("Birthday for {0}, your {1}, is {2}/{3}/{4}",
              findRel, relativeArray[x].Relationship, relativeArray[x].Month, 
              relativeArray[x].Day, relativeArray[x].Year);
              found = true;
        }
        if(!found)
          WriteLine("Sorry - no match for {0}", findRel);
      }
   }
}
class Relative : IComparable
{
   
   public string Name {get; set;}
   public string Relationship {get; set;}
   public int Month {get; set;}
   public int Day {get; set;}
   public int Year {get; set;}
   int IComparable.CompareTo(object o)
   {
      int returnVal;
      Relative temp = (Relative)o;
      returnVal = this.Name.CompareTo(temp.Name); 
      return returnVal;
   }
}
