using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesOefeningen
{
    class Waterpolospeler
    {
        private string spelerNaam;

        public string SpelerNaam
        {
            get { return spelerNaam; }
            set { spelerNaam = value; }
        }
        private int mutsNummer = 0;

        public int MutsNummer 
        {
            get { return mutsNummer; }
            set { mutsNummer = value; }
        }
        private bool isDoelman;

        public bool IsDoelman
        {
            get { return isDoelman; }
            set { isDoelman = value; }
        }
        private bool isReserve;

        public bool IsReserve
        {
            get { return isReserve; }
            set { isReserve = value; }
        }
        private string reeks;

        public string Reeks
        {
            get { return reeks; }
            set { reeks = value; }
        }
        public void StelIn(string naam ,int mutsNr, bool doel, bool reserve, string huidigeReeks)
        {
            SpelerNaam = naam;
            if (mutsNr > 0 && mutsNr < 14)
                MutsNummer = mutsNr;
            else
                MutsNummer = 0;
            IsDoelman = doel;
            IsReserve = reserve;
            Reeks = huidigeReeks;
            Console.WriteLine($"Ik ({spelerNaam}) gooi de bal.");
        }
    }
}
