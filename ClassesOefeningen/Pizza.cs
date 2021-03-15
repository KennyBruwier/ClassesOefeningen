using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesOefeningen
{
    class Pizza
    {
        private string toppings;

        public string Toppings
        {
            get { return toppings; }
            set 
            {
                if (value == "") Console.WriteLine("Geen toppings meegegeven");
                else toppings = value; 
            }
        }
        private int diameter = 0;

        public int Diameter
        {
            get { return diameter; }
            set 
            {
                if (value <= 0) Console.WriteLine("Diameter kan niet 0 of kleiner zijn");
                else diameter = value; 
            }
             
        }

        private double prijs = 0;

        public double Prijs
        {
            get { return prijs; }
            set 
            {
                if (value < 0) Console.WriteLine("Prijs kan niet minder dan 0 zijn");
                else prijs = value; 
            }
        }


    }
}
