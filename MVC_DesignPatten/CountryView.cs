using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_DesignPatten
{
    class CountryView
    {
        public Country DisplayCountry { get; set; }

        public CountryView(Country DisplayCountry)
        {
            this.DisplayCountry = DisplayCountry;
        }

        public void Display()
        {
            Console.WriteLine($"Country: {DisplayCountry.Name}");
            Console.WriteLine($"Country: {DisplayCountry.Continent}");

            Type type = typeof(ConsoleColor);

            foreach (string color in DisplayCountry.Colors)
            {
                if(color == "Black")
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine(color);
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = Enum.Parse<ConsoleColor>(color); // adjust ccolor on console to flag color
                    Console.WriteLine(color);
                    Console.ResetColor();
                }
            }

        }
    }
}
