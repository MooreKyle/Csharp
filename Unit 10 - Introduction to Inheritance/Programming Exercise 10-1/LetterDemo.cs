using static System.Console;
class LetterDemo
{
   static void Main()
   {
     // Write your code here
     Letter letter1 = new Letter();
     CertifiedLetter letter2 = new CertifiedLetter();
     letter1.Name = "Electric Company";
     letter1.Date = "02/14/18";
     letter2.Name = "Howe and Morris, LLC";
     letter2.Date = "04/01/2019";
     letter2.TrackingNumber = "i2YD45";
     WriteLine(letter1.ToString());
     WriteLine(letter2.ToString() +
        " Tracking number: " + letter2.TrackingNumber);
   }
}

// Write your classes here
class Letter
{
   public string Name {get; set;}
   public string Date {get; set;}
   public new string ToString()
   {
      return(GetType() + " To: " + Name +
         " Date mailed : " + Date); 
   }
}

class CertifiedLetter : Letter
{
   public string TrackingNumber {get; set;}
}
