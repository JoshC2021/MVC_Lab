using System;

namespace MVC_DesignPatten
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryController countryPresenter = new CountryController();
            countryPresenter.WelcomeAction();
        }
    }
}
