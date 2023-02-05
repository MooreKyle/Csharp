using System;
using static System.Console;
using System.IO;
class FileComparison
{
   static void Main()
   {
      // Write your code here
      const string WORD_FILE = @"/root/sandbox/Quote.docx";
      const string NOTEPAD_FILE = @"/root/sandbox/Quote.txt";
      long wordSize;
      long notepadSize;
      double ratio;
      FileInfo wordInfo = new FileInfo(WORD_FILE);
      FileInfo notepadInfo = new FileInfo(NOTEPAD_FILE);
      wordSize = wordInfo.Length;
      notepadSize = notepadInfo.Length;
      WriteLine("The size of the Word file is " + wordSize +
          "\nand the size of the Notepad file is " + notepadSize);
      ratio = (double)notepadSize / wordSize;
      WriteLine("The Notepad file is {0} of the size of the Word file", ratio.ToString("P2"));
   }
}
