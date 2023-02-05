using static System.Console;
class PaintintDemo
{
   static void Main()
   {
      // Write your main here
      Room[] rooms = new Room[8];
      int x;
      int len = 8;
      int wid = 8;
      int high = 8;
      for(x = 0; x < rooms.Length; ++x)
      {
         rooms[x] = new Room(len, wid, high);
         len += 2;
         wid += 2;
         if(x % 2 == 1)
            high += 1;
      }
      for(x = 0; x < rooms.Length; ++x)
      {
         WriteLine("For a {0} X {1} X {2} foot room",
            rooms[x].Length, rooms[x].Width, rooms[x].Height);
         WriteLine("     Two walls are {0} long and {1} high",
            rooms[x].Length, rooms[x].Height);
         WriteLine("        and the other two walls are {0} long and {1} high",
             rooms[x].Width, rooms[x].Height);
         WriteLine("     Total wall area is {0}, so you need {1} gallon(s) of paint.",
            rooms[x].Area, rooms[x].Gallons);
      }
   }
}

class Room
{
   int length, width, height, area, gallons;
   public Room(int len, int wid, int high)
   {
      length = len;
      width = wid;
      height = high;
      ComputeArea();
      ComputeGallons();
   }
   public double Length
   {
      get
      {
         return length;
      }
   }
   public int Width
   {
      get
      {
      return width;
      }
   }
   public int Height
   {
      get
      {
      return height;
      }
   }
   public int Area
   {
      get
      {
      return area;
      }
   }
   public int Gallons
   {
      get
      {
      return gallons;
      }
   }
   private void ComputeArea()
   {
      area = length * height * 2 + width * Height * 2;
   }
   private void ComputeGallons()
   {
     const int GALS_PER_SQ_FT = 350;
     gallons = area / GALS_PER_SQ_FT;
     if(area % GALS_PER_SQ_FT != 0)
        gallons++;
   }
}
