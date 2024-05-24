using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS3
{
    public class PetrolEngine : Engine
    {
        public double Capacity { get; set; }
        public double NoumberOfCylinder { get; set; }

        public PetrolEngine(int mileage, double costPerKmInPLN, string serialNumber, double capacity, double noumberOfCylinder) 
            : base(mileage, costPerKmInPLN, serialNumber)
        {
            Capacity = capacity;
            NoumberOfCylinder = noumberOfCylinder;
        }


    }
}
