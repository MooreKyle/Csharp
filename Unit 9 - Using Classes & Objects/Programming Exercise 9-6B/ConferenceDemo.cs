using System;
using static System.Console;
class ConferencesDemo
{
   static void Main()
   {
      // Write your main here
      Conference[] conferenceArray = new Conference[5];
      int x;
      for(x = 0; x < conferenceArray.Length; ++x)
      {
         conferenceArray[x] = new Conference();
         Write("Enter conference group name ");
         conferenceArray[x].Group = ReadLine();
         Write("Enter conference starting date ");
         conferenceArray[x].Date = ReadLine();
         Write("Enter attendees ");
         conferenceArray[x].Attendees = Convert.ToInt32(ReadLine());
      }
      Array.Sort(conferenceArray);
      WriteLine("Sorted conferences");
      for(x = 0; x < conferenceArray.Length; ++x)
      {
         WriteLine("{0} Conference starts on {1} and has {2} attendees",
            conferenceArray[x].Group, conferenceArray[x].Date,
conferenceArray[x].Attendees);
      }
   }
}

class Conference : IComparable
{
   private string group;
   private string date;
   private int attendees;

   public string Group
   {
      get
      {
         return group;
      }
      set
      {
         group = value;
      }
   }
   public string Date
   {
      get
      {
         return date;
      }
      set
      {
         date = value;
      }
   }
   public int Attendees
   {
      get
      {
         return attendees;
      }
      set
      {
         attendees = value;
      }
   }
   int IComparable.CompareTo(object o)
   {
     int returnVal;
     Conference temp = (Conference)o;
     if(this.attendees > temp.attendees)
        returnVal = 1;
     else
        if(this.attendees < temp.attendees)
           returnVal = -1;
        else
           returnVal = 0;
     return returnVal;
   }
}
