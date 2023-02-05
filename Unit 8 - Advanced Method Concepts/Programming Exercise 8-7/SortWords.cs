using System;
using static System.Console;
public class SortWords
{
   public static void Main()
   {
      // Write your main here
      string[] words = {"magic", "mouse", "lemon", "lime", "monkey", "lucky", "kangaroo", "lady", "market", "left"};
      SortAndDisplayWords("money");
      SortAndDisplayWords("job", "jelly");
      SortAndDisplayWords("goose", "elephant", "frog", "dog", "horse");
      SortAndDisplayWords(words);
   }
    
   public static void SortAndDisplayWords(params string[] words)
   {
      Array.Sort(words);
      foreach(string word in words)
         Write("{0} ", word);
      WriteLine();
   }
}
