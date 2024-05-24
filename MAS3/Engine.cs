using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS3
{
    public abstract class Engine
    {
        public int Mileage { get; set; }
        public double CostPerKmInPLN { get; set; }
        public string SerialNumber { get; set; }

        public Engine(int mileage, double costPerKmInPLN, string serialNumber)
        {
            Mileage = mileage;
            CostPerKmInPLN = costPerKmInPLN;
            SerialNumber = serialNumber;
        }
    }
}
