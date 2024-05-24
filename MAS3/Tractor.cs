using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS3
{
    public class Tractor : GroundVehicle
    {
        public ForestTractor ForestTractor { get; private set; }
        public CountryTractor CountryTractor { get; private set; }



        public Tractor( Engine engine, DateOnly productionDate, string brand) : base(GroundVehicleType.Other, engine, productionDate, brand)
        {
        }

        internal void AddCountryTractorPart(CountryTractor countryTractor)
        {
            CountryTractor = countryTractor;
        }

        internal void AddForestTractorPart(ForestTractor forestTractor)
        {
            ForestTractor = forestTractor;
        }
    }
}
