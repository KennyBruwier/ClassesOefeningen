using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesOefeningen
{
    class Rechthoek
    {
        private int lengte = 1;

        public int Lengte
        {
            get { return lengte; }
            set 
            { 
                if (value > 0)
                lengte = value; 
            }
        }
        private int breedte = 1;

        public int Breedte
        {
            get { return breedte; }
            set { if (value > 0) breedte = value; }
        }
        public int ToonOppervlakte()
        {
            return lengte * breedte;
        }

    }
}
