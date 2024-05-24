using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAS3
{
    public interface IWeaterVehicle : IVehicle
    {
        public double DisplacementInTons { get; set; }
        public void MakeSound() => Console.WriteLine("Szzzzzzzzzz");
    }
}
