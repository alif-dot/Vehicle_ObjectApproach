using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_ObjectApproach
{
    sealed class Motorcycle : TwoWheeler
    {
        public Motorcycle()
        {
            vehicleTypes = VehicleType.TwoWheeler;
            NumberOfSeat = 2;
        }
        public decimal BPH { get; set; }
        public decimal KMPL { get; set; }
        public decimal Cooling { get; set; }
    }
}
