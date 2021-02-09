using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_DesignPatten
{
    class CountryListView
    {
        public List<Country> Countries { get; set; }

        public CountryListView(List<Country> Countries)
        {
            this.Countries = Countries;
        }

        public void Display()
        {
            for (int i = 0; i < Countries.Count; i++)
            {
                string name = Countries[i].Name;
                Console.WriteLine($"{i} : {name}");
            }
        }


        // gets a valid id of country from list
        public Country GetCountry()
        {
            Console.WriteLine($"Please input a number between 0 to {Countries.Count - 1}");
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    int pick = int.Parse(input);
                    return Countries[pick];
                }
                catch (FormatException)
                {
                    Console.WriteLine("The input was a valid integer");
                    Console.WriteLine("Let's try that again");

                }
                catch (ArgumentOutOfRangeException) // not supposed to be index out of range
                {
                    Console.WriteLine($"The inputted number was not between 0 to {Countries.Count - 1}");
                    Console.WriteLine("Let's try that again");
                }
            }



        }
    }
}

