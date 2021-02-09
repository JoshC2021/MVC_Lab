using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_DesignPatten
{
    class CountryController
    {
        // populating test data
        public List<Country> CountriesDB = new List<Country>(); 
        public CountryController()
        {
            List<string> usaColors = new List<string>() { "Red", "White", "Blue" };
            CountriesDB.Add(new Country() { Name = "USA", Colors = usaColors, Continent = Continents.North_America });

            List<string> MexicoColors = new List<string>() { "Red", "White", "Green" };
            CountriesDB.Add(new Country() { Name = "Mexico", Colors = MexicoColors, Continent = Continents.North_America });

            List<string> BrazilColors = new List<string>() { "Blue", "Yellow", "Green" };
            CountriesDB.Add(new Country() { Name = "Brazil", Colors = BrazilColors, Continent = Continents.South_America });

            List<string> JapanColors = new List<string>() { "Red", "White"};
            CountriesDB.Add(new Country() { Name = "Japan", Colors = JapanColors, Continent = Continents.Asia });

            List<string> GermanyColors = new List<string>() { "Red", "Yellow", "Black" };
            CountriesDB.Add(new Country() { Name = "Germany", Colors = GermanyColors, Continent = Continents.Europe });

            List<string> ChadColors = new List<string>() { "Blue", "Yellow", "Red" };
            CountriesDB.Add(new Country() { Name = "Chad", Colors = ChadColors, Continent = Continents.Africa });

        }
        public void WelcomeAction()
        {
            WelcomeView wv = new WelcomeView();
            wv.Display();
            CountryList();
        }

        public void CountryAction(Country c)
        {
            CountryView cv = new CountryView(c);
            cv.Display();
            Console.Write("Would you like to learn about another country(Y/N)?: ");
            bool needAnswer = true;
            while(needAnswer)
            {
                string yOrN = Console.ReadLine().Trim().ToUpper();
                if(yOrN == "Y")
                {
                    needAnswer = false;
                    CountryList();
                }
                if(yOrN == "N")
                {
                    Console.WriteLine("Goodbye");
                    needAnswer = false;
                }
            }
        }

        public void CountryList()
        {
            CountryListView cv = new CountryListView(CountriesDB);
            cv.Display();
            Country c = cv.GetCountry();
            CountryAction(c);
        }
    }
}