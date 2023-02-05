using static System.Console;
class PigLatin
{
   static void Main()
   {
       // Write your main here
       WriteLine("Enter a word to be converted: ");
       string wordIn = ReadLine();
       int wordIndex = wordIn.Length;
       string wordFront = wordIn.Substring(0,1);
       string wordBack = wordIn.Substring(1, wordIndex-1);
       string converted = wordBack + wordFront + "ay";
       WriteLine("pig latin version is " + converted);
   }
}
