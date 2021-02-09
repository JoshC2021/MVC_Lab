using System;
using System.Collections.Generic;
using System.Text;

namespace MVC_DesignPatten
{
    public enum Continents
    {
        North_America,
        South_America,
        Austrailia,
        Antarctica,
        Europe,
        Africa,
        Asia
    }
    class Country
    {
        public String Name { get; set; }
        public Continents Continent { get; set; }
        public List<string> Colors { get; set; }
    }
}
