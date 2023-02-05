using static System.Console;
class Flights
{
   static void Main()
   {
      // Write your main here
      int[] flightNumbers = {201, 321, 510, 633};
      string[] airportCodes = { "AUS", "CRP", "DFW", "HOU"};
      string[] airportNames = {"Austin", "Corpus Christi", "Dallas Fort Worth", "Houston"};
      string[] times = {"0710", "0830", "0915", "1140"};
      string request;
      int flightNum;
      string output;
      Write("Please enter flight number or airport code >> ");
      request = ReadLine();
      if(int.TryParse(request, out flightNum))
         output = GetFlightInfo(flightNum, flightNumbers, airportCodes, airportNames, times);
      else
         output = GetFlightInfo(request, flightNumbers, airportCodes, airportNames, times);
      WriteLine(output);
   }
    
   public static string GetFlightInfo(int flight, int[] flightNumbers, string[] codes, string[] names, string[] times)
   {
      int x;
      string output = "Flight #" + flight + " was not found";
      for(x = 0; x < flightNumbers.Length; ++x)
         if(flight == flightNumbers[x])
             output = "Flight #" + flight + " " + codes[x] + " " + names[x] + "  Scheduled at: " + times[x];
      return output;
   }   
   public static string GetFlightInfo(string code, int[] flightNumbers, string[] codes, string[] names, string[] times)
   {
      int x;
      string output = "Flight to " + code + " was not found";
      for(x = 0; x < flightNumbers.Length; ++x)
         if(code.Equals(codes[x]))
             output = "Flight #" + flightNumbers[x] + " " + codes[x] + " " + names[x] + "  Scheduled at: " + times[x];
      return output;
   }
}
