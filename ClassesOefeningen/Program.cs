using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesOefeningen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Oefening6();

            Console.ReadKey();
        }

        static void Oefening1()
        {
            Nummers nummers = new Nummers();

            nummers.Getal1 = 12;
            nummers.Getal2 = 34;

            Console.WriteLine($"Paar: {nummers.Getal1}, {nummers.Getal2}");
            Console.WriteLine($"Som = {nummers.Som()}");
            Console.WriteLine($"Verschil = {nummers.Verschil()}");
            Console.WriteLine($"Product = {nummers.Product()}");
            Console.WriteLine($"Quotient = {nummers.Quotient()}");

            Console.ReadLine();
        }

        static void Oefening2()
        {
            Student student = new Student();

            student.Naam = "Joske vermeulen";
            student.Klas = Klassen.EA2;
            student.Leeftijd = 21;
            student.PuntenCommunicatie = 12;
            student.PuntenProgrammingPrinciples = 15;
            student.PuntenWebTech = 13;

            student.GeefOverzicht();
        }

        static void Oefening3()
        {
            Pizza Hawai = new Pizza();

            Console.WriteLine("Pizza hawai:");
            Hawai.Toppings = "";
            Console.WriteLine($"Zonder topping: {Hawai.Toppings}");
            Hawai.Toppings = "Ananas,tomaat,ham";
            Console.WriteLine($"Met topping: {Hawai.Toppings}");
            Hawai.Diameter = -10;
            Console.WriteLine($"Diameter = -10: {Hawai.Diameter}");
            Hawai.Diameter = 40;
            Console.WriteLine($"Diameter = 40: {Hawai.Diameter}");
            Hawai.Prijs = -10;
            Console.WriteLine($"Prijs = -10: {Hawai.Prijs}");
            Hawai.Prijs = 15;
            Console.WriteLine($"Prijs = 15: {Hawai.Prijs}");
        }
        static void Oefening4()
        {
            Rechthoek rechthoek = new Rechthoek();
            Driehoek driehoek = new Driehoek();

            rechthoek.Breedte = -10;
            Console.WriteLine($"Rechthoek met breedte -10: {rechthoek.Breedte}");
            rechthoek.Breedte = 10;
            Console.WriteLine($"Rechthoek met breedte 10: {rechthoek.Breedte}");
            rechthoek.Lengte = -10;
            Console.WriteLine($"Rechthoek met lengte -10: {rechthoek.Lengte}");
            rechthoek.Lengte = 10;
            Console.WriteLine($"Rechthoek met lengte 10: {rechthoek.Lengte}");
            driehoek.Basis = -10;
            Console.WriteLine($"Rechthoek met basis -10: {driehoek.Basis}");
            driehoek.Basis = 10;
            Console.WriteLine($"Rechthoek met basis 10: {driehoek.Basis}");
            driehoek.Hoogte = -10;
            Console.WriteLine($"Rechthoek met hoogte -10: {driehoek.Hoogte}");
            driehoek.Hoogte = 10;
            Console.WriteLine($"Rechthoek met hoogte 10: {driehoek.Hoogte}");
            Console.WriteLine($"\nRechthoek oppervlakte: {rechthoek.ToonOppervlakte()}");
            Console.WriteLine($"Driehoek oppervlakte: {driehoek.ToonOppervlakte()}");

        }

        static void Oefening5()
        {
            Waterpolospeler waterpolospeler = new Waterpolospeler();

            waterpolospeler.StelIn("Tim", 5, false, true, "tweedeklas");
            string mutsNummer = (waterpolospeler.MutsNummer == 0 ? "ongeldige nummer" : waterpolospeler.MutsNummer.ToString());
            Console.WriteLine($"Naam: {waterpolospeler.SpelerNaam} MutsNr: {mutsNummer} Doelman: {(waterpolospeler.IsDoelman?"ja":"nee")} Reserver: {(waterpolospeler.IsReserve ? "ja" : "nee") }");
            waterpolospeler.StelIn("Jef", 15, true, false, "eersteklas");

            mutsNummer = (waterpolospeler.MutsNummer == 0 ? "ongeldige nummer" : waterpolospeler.MutsNummer.ToString());
            
            Console.WriteLine($"Naam: {waterpolospeler.SpelerNaam} MutsNr: {mutsNummer} Doelman: {(waterpolospeler.IsDoelman ? "ja" : "nee")} Reserver: {(waterpolospeler.IsReserve ? "ja" : "nee") }");
        }

        static void Oefening6()
        {
            Account[] rekeningen = new Account[10];

            rekeningen[0] = new Account();
            rekeningen[0].CreateAccount("Kenny Bruwier", "04546 12315 4564 546465", 1000);
            rekeningen[1] = new Account();
            rekeningen[1].CreateAccount("Ken", "04546 14515 4784 544535", 5000);
            rekeningen[2] = new Account();
            rekeningen[2].CreateAccount("Joske", "45546 54555 54564 65465", 1000);
            Console.WriteLine();
            rekeningen[2].ChangeState(StatusAccount.Geblokkeerd);
            Console.WriteLine($"Opdracht: rekening {rekeningen[2].naam} Huidige stand: {rekeningen[2].bedrag} waarvan 500 euro af te halen");
            rekeningen[2].WithDrawFunds(500);
            Console.WriteLine();
            Console.WriteLine($"Opdracht: rekening {rekeningen[0].naam} Huidige stand: {rekeningen[0].bedrag} waarvan 2000 euro af te halen");
            rekeningen[0].WithDrawFunds(2000);
            Console.WriteLine();
            Console.WriteLine($"Opdracht: rekening {rekeningen[1].naam} Huidige stand: {rekeningen[1].bedrag} waarvan 100 euro naar {rekeningen[0].naam}");

            rekeningen[0].PayInFunds(rekeningen[1].WithDrawFunds(100));
            Console.WriteLine();
            

        }
    }
}
