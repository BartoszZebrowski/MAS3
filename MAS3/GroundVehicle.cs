using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS3
{
    public class GroundVehicle : IVehicle
    {
        public GroundVehicleType GroundVehicleType { get; private set; }

        public Engine Engine;

        private DateOnly _productionDate;
        public DateOnly ProductionDate 
        { 
            get => _productionDate; 
            set => _productionDate = value; 
        }

        private string _brand; 
        public string Brand 
        { 
            get => _brand; 
            set => _brand = value; 
        }

        private int? _carrierCapacity;
        public int? CarrierCapacity
        {
            get
            {
                if (GroundVehicleType is not GroundVehicleType.CasualCar)
                    throw new Exception("Wrong car type");

                return _carrierCapacity;
            }

            set
            {
                if (GroundVehicleType is not GroundVehicleType.CasualCar)
                    throw new Exception("Wrong car type");

                _carrierCapacity = value;
            }
        }

        private int? _maxSpeedIntDrift;
        public int? MaxSpeedIntDrift
        {
            get
            {
                if (GroundVehicleType is not GroundVehicleType.SportCar)
                    throw new Exception("Wrong car type");

                return _maxSpeedIntDrift;
            }

            set
            {
                if (GroundVehicleType is not GroundVehicleType.SportCar)
                    throw new Exception("Wrong car type");

                _maxSpeedIntDrift = value;
            }
        }


        public GroundVehicle(GroundVehicleType groundVehicleType, Engine engine, DateOnly productionDate, string brand)
        {
            GroundVehicleType = groundVehicleType;
            Engine = engine;
            ProductionDate = productionDate;
            Brand = brand;
        }

        public void ChangeGroundVehicleTypeToCasualCar(int carrierCapacity)
        {
            if (GroundVehicleType is not GroundVehicleType.SportCar)
                throw new Exception("This car is Casual Car or Other!");

            GroundVehicleType = GroundVehicleType.CasualCar;
            CarrierCapacity = carrierCapacity;
        }

        public void ChangeGroundVehicleTypeToSportcar(int maxSpeedIntDrift)
        {
            if (GroundVehicleType is not GroundVehicleType.CasualCar)
                throw new Exception("This car is Casual Car or Other!");

            GroundVehicleType = GroundVehicleType.SportCar;
            MaxSpeedIntDrift = maxSpeedIntDrift;
        }

        public void OpenCarrier() // dla CasualCar
        {
            if (GroundVehicleType is not GroundVehicleType.CasualCar)
                throw new Exception("Wrong car type");

            Console.WriteLine("Carrier opened");
        }

        public void Drift() // dla SportCar
        {
            if (GroundVehicleType is not GroundVehicleType.SportCar)
                throw new Exception("Wrong car type");

            Console.WriteLine("Drifting....");
        }
    }
}
