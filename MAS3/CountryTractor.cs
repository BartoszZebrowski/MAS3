using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS3
{
    public class CountryTractor
    {
        private Tractor _tractor;
        public int GrainCapacity { get; set; }

        private CountryTractor(Tractor tractor, int grainCapacity)
        {
            GrainCapacity = grainCapacity;
            _tractor = tractor;
        }

        public static void CreateAsPartOfTractor(Tractor tractor, int grainCapacity)
        {
            if (tractor is null)
                throw new Exception("Tractor can't be null");

            var countryTractor = new CountryTractor(tractor, grainCapacity);
            tractor.AddCountryTractorPart(countryTractor);
        }
    }
}
