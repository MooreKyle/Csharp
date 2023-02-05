using System;
using static System.Console;
using System.IO;
class DirectoryInformation
{
   static void Main()
   {
       // Your code here
       string directory;
       string[] files;
       int x;
       const string END = "end";
       Write("Enter a directory >> ");
       directory = ReadLine();
       while(directory != END)
       {
          if(Directory.Exists(directory))
          {
             files = Directory.GetFiles(directory);
             if(files.Length == 0)
                 WriteLine("There are no files in this directory: " + directory);
             else
             {
                WriteLine(directory + " contains the following files");
                for(x = 0; x < files.Length; ++x)
                   WriteLine("  " + files[x]);
             }
          }
          else
          {
             WriteLine("Directory " + directory + " does not exist");
          }
          Write("\nEnter another directory or type " + END + " to quit >> ");
          directory = ReadLine();
       }
   }
}
