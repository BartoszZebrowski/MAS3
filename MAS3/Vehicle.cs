using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS3
{
    public interface IVehicle
    {
        public DateOnly ProductionDate { get; set; }
        public string Brand { get; set; }
        public void MakeSound() => Console.WriteLine("Wrrrrr");
    }
}
