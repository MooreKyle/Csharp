using System;
using System.IO;
using static System.Console;
using System.Globalization;
class ReadPatientRecords
{
   static void Main()
   {
      // Your code here
      const char DELIM = ',';
      const string FILENAME = "Patients.txt";
      Patient patient = new Patient();
      FileStream inFile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
      StreamReader reader = new StreamReader(inFile);
      string recordIn;
      string[] fields;
      WriteLine("\n{0,-10}{1,-18}{2,10}\n", "IdNumber", "Name", "Balance");
      recordIn = reader.ReadLine();
      while(recordIn != null)
      {
         fields = recordIn.Split(DELIM);
         patient.IdNum = fields[0];
         patient.Name = fields[1];
         patient.Balance = Convert.ToDouble(fields[2]);
         WriteLine("{0,-10}{1,-18}{2, 10}", patient.IdNum, patient.Name, patient.Balance.ToString("C", CultureInfo.GetCultureInfo("en-US")));
         recordIn = reader.ReadLine();
      }

      reader.Close();
      inFile.Close();
   }
}

class Patient
{
   public string IdNum {get; set;}
   public string Name  {get; set;}
   public double Balance {get; set;}
   public new string ToString()
   {
      return("#" + IdNum + ',' + Name + ',' + Balance);
   }
}
