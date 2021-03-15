using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesOefeningen
{
    enum Klassen
    {
        EA1,
        EA2,
        EA3
    }
    class Student
    {
        public string Naam { get; set; }
        public int Leeftijd { get; set; }
        public Klassen Klas  { get; set; }
        public int PuntenCommunicatie { get; set; }
        public int PuntenProgrammingPrinciples { get; set; }
        public int PuntenWebTech { get; set; }

        public double BerekenTotaalCijfer()
        {
            return (double)(PuntenCommunicatie + PuntenProgrammingPrinciples + PuntenWebTech) / 3;
        }

        public void GeefOverzicht()
        {
            Console.WriteLine($"{Naam}, {Leeftijd} jaar");
            Console.WriteLine($"Klas: {Klas}\n");
            Console.WriteLine($"Cijferrapport:");
            Console.WriteLine("**************");
            Console.WriteLine($"Communicatie:\t\t{PuntenCommunicatie}");
            Console.WriteLine($"Programming Principles:\t{PuntenProgrammingPrinciples}");
            Console.WriteLine($"Web Technologie:\t{PuntenWebTech}");
            Console.WriteLine($"Gemiddelde:\t\t{BerekenTotaalCijfer()}");
        }
    }   
}
