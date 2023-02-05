using System;
using static System.Console;
class TippingTable3
{
   static void Main()
   {
    // write your main here.
    double dinnerPrice;
    double tipRate;
    double tip;
    double highRate;
    double lowRate;
    double highDinner;
    double lowDinner;
    string input;
    const double STEP = 0.05;
    const double DINNERSTEP = 10.00;
    const int FIELDSIZE = 8;
    Write("Enter lowest tip rate ");
    input = ReadLine();
    lowRate = Convert.ToDouble(input);
    Write("Enter highest tip rate ");
    input = ReadLine();
    highRate = Convert.ToDouble(input);
    Write("Enter lowest dinner value ");
    input = ReadLine();
    lowDinner = Convert.ToDouble(input);
    Write("Enter highest dinner value ");
    input = ReadLine();
    highDinner = Convert.ToDouble(input);
    Write("   Price");
    for(tipRate = lowRate; tipRate <= highRate; tipRate += STEP)
        Write("{0,8}", tipRate.ToString("F"));
    WriteLine();
    for(int count = 0; count < 10 + FIELDSIZE * ((highRate - lowRate) / STEP + 1); ++count)
        Write("-");
    WriteLine();
    tipRate = lowRate;
    dinnerPrice = lowDinner;
    while(dinnerPrice <= highDinner)
    {
        Write("{0,8}", dinnerPrice.ToString("C"));
        while(tipRate <= highRate)
        {
          tip = dinnerPrice * tipRate;
          Write("{0, 8}", tip.ToString("F"));
          tipRate += STEP;
        }
        dinnerPrice += DINNERSTEP;
        tipRate = lowRate;
        WriteLine();
    }
   } 
}
