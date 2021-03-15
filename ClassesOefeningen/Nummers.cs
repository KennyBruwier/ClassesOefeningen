using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesOefeningen
{
    
    // oefening 1
    class Nummers
    {
        public int Getal1 { get; set; }
        public int Getal2 { get; set; }

        public int Som()
        {
            return Getal1 + Getal2;
        }
        public int Verschil()
        {
            return Math.Abs(Getal1 - Getal2); 
        }
        public int Product()
        {
            return Getal1 * Getal2;
        }
        public double Quotient()
        {
            if (Getal2 == 0) Console.WriteLine("Error");
            else
                return (double)Getal1 / Getal2;
            return 0;
        }
    }
    


}
