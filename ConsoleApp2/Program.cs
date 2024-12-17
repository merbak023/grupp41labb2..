using System;


namespace Grupp41Labb2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string val = "";
            while (val != "2")
            {
                Console.WriteLine("Välj ett av alternativen");
                Console.WriteLine("1. Beräkna windchillsfaktor");
                Console.WriteLine("2. Avsluta programmet");
                Console.WriteLine("Välj ett alternativ");

                val = Console.ReadLine();

                if (val == "1")
                {
                    Console.WriteLine("Ange vind i km/h");
                    float wind = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ange temperatur i Celsius");
                    float temperature = float.Parse(Console.ReadLine());
                    while (temperature > 0)
                    {
                        Console.WriteLine("Tempraturen måste vara mindre än 0");
                        temperature = float.Parse(Console.ReadLine());
                    }
                    double windchill = 13.12 + 0.6215 * temperature - 11.37 * Math.Pow(wind, 0.16) +
                                       0.3965 * temperature * Math.Pow(wind, 0.16);

                    Console.WriteLine($"Windchill är {windchill.ToString("0.0")}");

                    if (windchill > -25)
                    {
                        Console.WriteLine("kallt");

                    }
                    else if (windchill <= -25 && windchill >= -35)
                    {
                        Console.WriteLine("Mycket kallt");
                    }
                    else if (windchill <= -35 && windchill >= -60)
                    {
                        Console.WriteLine("Risk för frostskada");
                    }
                    else if (windchill < -60)
                    {
                        Console.WriteLine("Stor risk för frostskada");
                    }
                }

                else if (val == "2")
                {
                    Console.WriteLine("Avslutar programmet. Tack så mycket.");
                }
                else
                {
                    Console.WriteLine("Det valet finns inte. Försök igen.");
                }
            }
        }
    }
}
