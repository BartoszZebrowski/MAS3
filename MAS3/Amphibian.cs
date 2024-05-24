using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS3
{
    public class Amphibian : GroundVehicle, IWeaterVehicle
    {
        private double _displacementInTons;
        public double DisplacementInTons 
        { 
            get => _displacementInTons; 
            set => _displacementInTons = value; 
        }
        public Amphibian(double displacementInTons, Engine engine, DateOnly productionDate, string brand) 
            : base(GroundVehicleType.Other, engine, productionDate, brand)
        {
            DisplacementInTons = displacementInTons;
        }
    }
}
