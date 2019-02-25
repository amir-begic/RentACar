using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentACar.Models
{
    public class Car
    {
        private int LicenseNumber { get; set; }
        private string Manufacturer { get; set; }
        private string Type { get; set; }
        private DateTime Manufactured { get; set; }
        private int PricePerDay { get; set; }
        private bool Available { get; set; }
    }
}
