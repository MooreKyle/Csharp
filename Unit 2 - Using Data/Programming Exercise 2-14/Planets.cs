using System;
using static System.Console;
class Planets
{
   enum Planet
    {
        Mercury = 1,
        Venus = 2,
        Earth = 3,
        Mars = 4,
        Jupiter = 5,
        Saturn = 6,
        Uranus = 7,
        Neptune = 8
    }

    static void Main()
    {
        // Write your main here
        int planetIndex = 0;
        Planet PlanetName;
        WriteLine("Enter the planet position number: ");
        planetIndex = int.Parse(ReadLine());
        PlanetName = (Planet)planetIndex;
        WriteLine("{0} is {1} planet(s) from the sun ", PlanetName, planetIndex);
    }
}
