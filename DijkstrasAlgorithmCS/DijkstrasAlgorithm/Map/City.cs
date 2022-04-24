using System;
using System.Collections.Generic;
using System.Text;

namespace DijkstrasAlgorithm.Map
{
    class City
    {
        public string Name { get; set; }

        public override bool Equals(object? obj)
        {
            var city = obj as City;
            return Name.Equals(city?.Name);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }
    }
}
