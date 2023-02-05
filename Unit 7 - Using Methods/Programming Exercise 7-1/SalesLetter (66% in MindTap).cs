using static System.Console;
public class SalesLetter
{
   public static void Main()
    {
        // Write your main here.
        WriteLine("From");
        DisplayContactInfo();
        WriteLine("____________________________\n");
        WriteLine("Dear Client,");
        WriteLine("We want to provide you good service.");
        WriteLine("Feel free to contact us at any time.");
        DisplayContactInfo();
        WriteLine("     *********\n");
        WriteLine("Looking forward to a long relationship.");
        DisplayContactInfo();
        DisplayContactInfo();
    }
   public static void DisplayContactInfo()
    {
     // Write your DisplayContactInfo()
        WriteLine("C# Company");
        WriteLine("Phone: 555-1234     Cell: 555-0912");
        WriteLine("Email: csharpcompany@csharp.com");
        WriteLine("On the Web at www.csharpcompanyforyou.com");
    }
}
