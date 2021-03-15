using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesOefeningen
{
    class Driehoek
    {
        private int basis = 1;

        public int Basis
        {
            get { return basis; }
            set
            {
                if (value > 0)
                    basis = value;
            }
        }
        private int hoogte = 1;

        public int Hoogte
        {
            get { return hoogte; }
            set { if (value > 0) hoogte = value; }
        }
        public double ToonOppervlakte()
        {
            return basis * hoogte / 2.0;
        }
    }
}
