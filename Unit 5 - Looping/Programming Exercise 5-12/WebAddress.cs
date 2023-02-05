using System;
using static System.Console;
class WebAddress
{
   static void Main()
   {
        // Write your main here.
        string name;
        string newName = "";
        int x;
        Write("Enter your business name >> ");
        name = ReadLine();
        for(x = 0; x < name.Length; ++x)
           if(!String.Equals(name.Substring(x, 1), " "))
                newName += name.Substring(x, 1);
        WriteLine("A good web address is {0}", "www." + newName + ".com");
   }
}
