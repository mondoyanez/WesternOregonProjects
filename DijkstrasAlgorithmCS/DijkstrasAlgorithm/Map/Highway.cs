using System;
using System.Collections.Generic;
using System.Text;

namespace DijkstrasAlgorithm.Map
{
    class Highway
    {
        public string Name { get; set; }
        public double Distance { get; set; }
        public double AverageSpeedLimit { get; set; }

        public override bool Equals(object? obj)
        {
            var highway = obj as Highway;
            return Name.Equals(highway?.Name) &&
                   Distance.Equals(highway?.Distance) &&
                   AverageSpeedLimit.Equals(highway?.AverageSpeedLimit);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override string ToString() => $"{Name} Distance: {Distance} Average Speed Limit: {AverageSpeedLimit}.";
    }
}
