using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS3
{
    public class ForestTractor
    {
        private Tractor _tractor;
        public int LogCapacity { get; set; }


        private ForestTractor(Tractor tractor, int logCapacity)
        {
            _tractor = tractor;
            LogCapacity = logCapacity;
        }

        public static void CreateAsPartOfTractor(Tractor tractor, int logCapacity)
        {
            if (tractor is null)
                throw new Exception("Tractor can't be null");

            var forestTractor = new ForestTractor(tractor, logCapacity);
            tractor.AddForestTractorPart(forestTractor);
        }
    }
}
