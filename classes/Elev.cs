using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yes
{
    public class Elev
    {
        private string nume;
        private string prenume;
        private string adresa;
        private int nrMatricol;
        private char initialaTata;

        public Elev(string nume, string prenume, string adresa, int nrMatricol, char initialaTata)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.adresa = adresa;
            this.nrMatricol = nrMatricol;
            this.initialaTata = initialaTata;
        }
        public string getNume()
        {
            return this.nume;
        }
        public string getPrenume()
        {
            return this.prenume;
        }
        public string getAdresa()
        {
            return this.adresa;
        }
        public int getNrMatricol()
        {
            return this.nrMatricol;
        }
        public char getInitialaTata()
        {
            return this.initialaTata;
        }
    }
}
