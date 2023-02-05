using static System.Console;
class Twitter
{
   static void Main()
   {
      // Write your main here
      string message;
      WriteLine("Enter a Twitter message here: ");
      message = ReadLine();
      int howLong = message.Length;
      if (howLong > 140)
        WriteLine("The message is too long");
      else
        WriteLine("The message is okay");
   }
}
