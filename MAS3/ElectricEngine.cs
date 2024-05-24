using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS3
{
    public class ElectricEngine : Engine
    {
        public double MinVoltage { get; set; }
        public double MaxVoltage { get; set; }

        public ElectricEngine(int mileage, double costPerKmInPLN, string serialNumber, double minVoltage, double maxVoltage)
            : base(mileage, costPerKmInPLN, serialNumber)
        {
            MinVoltage = minVoltage;
            MaxVoltage = maxVoltage;
        }
    }
}
