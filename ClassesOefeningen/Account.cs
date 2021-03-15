using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesOefeningen
{
    enum StatusAccount
    {
        Geldig,
        Geblokkeerd
    }
    class Account
    {
        public string naam { get; set; }
        const char c = '€';
        public int bedrag { get; set; }
        public string rekeningNummer { get; set; }

        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        private StatusAccount status 
        { get; set; } = StatusAccount.Geldig;
        public string Status 
        { get
            {
                if (status == StatusAccount.Geldig) return "Geldig";
                else return "Ongeldig";
            }
                 }
        public int WithDrawFunds(int nieuwBedrag)
        {
            if (status == StatusAccount.Geblokkeerd) Console.WriteLine($"Rekening {rekeningNummer} is geblokkeerd");
            else
            if (nieuwBedrag > bedrag)
            {
                Console.WriteLine($"Slechts {bedrag}{c} gevonden.{nieuwBedrag - bedrag}{c} niet gevonden.");
                return bedrag = 0;
            }
            else
            {
                Console.WriteLine($"{nieuwBedrag}{c} van rekening {rekeningNummer} afgehaald.");
                return bedrag -= nieuwBedrag;
            }
            return 0;
        }
        public void PayInFunds(int bepaaldBedrag, bool create = false)
        {
            if (status == StatusAccount.Geblokkeerd) Console.WriteLine($"Rekening {rekeningNummer} is geblokkeerd");
            else
            if (bepaaldBedrag > 0)
            {
                bedrag += bepaaldBedrag;
                if (!create)
                Console.WriteLine($"Bedrag {bepaaldBedrag}{c} is gestort op rekening: {rekeningNummer}");
            }
            else
                Console.WriteLine($"{bepaaldBedrag}{c} moet groter dan 0 zijn");
        }
        public void ChangeState(StatusAccount accountState)
        {
            status = accountState;
        }
        public void CreateAccount(string nieuwNaam, string nieuweRekeningnr, int huidigBedrag)
        {
            naam = nieuwNaam;
            rekeningNummer = nieuweRekeningnr;
            PayInFunds(huidigBedrag,true);
            Console.WriteLine("\nVolgende account is aangemaakt:");
            Console.WriteLine($"Naam: {naam} Rekening: {rekeningNummer} Bedrag: {bedrag}{c} Status: {Status}");
        }
    }
}
