using System;

namespace SingletonPlanetCore
{
    class Program
    {
        public static IPlanet thePlanet;
        static void Main(string[] args)
        {
            ReadKeyFromConsoleAndPlanet();
        }

        static void ReadKeyFromConsoleAndPlanet()
        {
            string planet = Console.ReadLine();
            if (planet.Equals(IPlanet.MOON))
                thePlanet = Moon.Instance;
            else if (planet.Equals(IPlanet.EARTH))
                thePlanet = Earth.Instance;
            else if (planet.Equals(IPlanet.SUN))
                thePlanet = Sun.Instance;
            else
                thePlanet = null;
        }
    }
}
