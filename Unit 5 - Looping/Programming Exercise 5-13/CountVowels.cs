using System;
using static System.Console;
class CountVowels
{
   static void Main()
   {
      // Write your main here.
      string phrase;
      string[] vowels = {"A", "E", "I", "O", "U", "a", "e", "i", "o", "u"};
      int x, y;
      int count = 0;
      Write("Enter a phrase >> ");
      phrase = ReadLine();
      for(x = 0; x < phrase.Length; ++x)
         for(y = 0; y < vowels.Length; ++y)
           if(String.Equals(phrase.Substring(x,1), vowels[y]))
              ++count;
      WriteLine("There are {0} vowels in {1}", count, phrase);
   }
}
