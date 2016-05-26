using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Tenta_1_1.Models
{
    public class CalculateEnergy
    {
        private readonly double _speedOfLight = Math.Pow(299792458, 2);

        public double CalculateMass(double mass)
        {
            if(mass < 0)
                throw new Exception("Invalid input, input > 0");
            if(mass > double.MaxValue / _speedOfLight)
                throw new ArgumentOutOfRangeException();

            return mass*_speedOfLight;
        }

    }
}
