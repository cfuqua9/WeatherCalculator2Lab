using System;

namespace WeatherCalculator2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Weather Calculator 2");
            Console.WriteLine("Enter the Temperature  in Fahrenheit");

            int temperature = int.Parse(Console.ReadLine());
            if (temperature <= 50)
            {
                Console.WriteLine("Enter the Windspeed in mph");
                int windspeed = int.Parse(Console.ReadLine());
                double windchill = 37.74
                    + (.6125 * temperature)
                    - 35.75 * Math.Pow(windspeed, .16)
                    + .4275 * temperature * Math.Pow(windspeed, .16);
                Console.WriteLine("The windchill is" + windchill);
            }
            else _ = (temperature > 50);
            {
                Console.WriteLine("Enter the Relative Humidity");
                int relativeHumidity = int.Parse(Console.ReadLine());
                double heatIndex = .5 * (temperature + 61 + ((temperature - 68) * 1.2) + (relativeHumidity * .094));
                Console.WriteLine("The Heat Index is" + heatIndex);
            }

        }
    }
}
            