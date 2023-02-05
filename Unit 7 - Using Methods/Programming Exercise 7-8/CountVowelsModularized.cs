using System;
using static System.Console;
class CountVowelsModularized
{
   public static void Main()
   {
      // Write your main here.
      string phrase;
      int count = 0;
      Write("Enter a string >> ");
      phrase = ReadLine();
      count = CountVowels(phrase);
      WriteLine("There are {0} vowels in {1}", count, phrase);
   }
   public static int CountVowels(string phrase)
   {
    // Write your CounVowels method here.
    int x, y;
    int count = 0;
    string[] vowels = {"A", "E", "I", "O", "U", "a", "e", "i", "o", "u"};
    for(x = 0; x < phrase.Length; ++x)
        for(y = 0; y < vowels.Length; ++y)
             if(String.Equals(phrase.Substring(x, 1), vowels[y])) ++count;
    return count;
   }
}
