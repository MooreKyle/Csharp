using static System.Console;
class Movie
{
   static void Main()
   {
      // Write your main here
      DisplayMovie("The Wizard of Oz", 101);
      DisplayMovie("Casablanca");
   }

   public static void DisplayMovie(string title, int minutes = 90)
   {
      WriteLine("The movie {0} has a running time of {1} minutes.", title, minutes);
   }
}
