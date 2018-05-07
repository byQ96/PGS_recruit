using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Parameters
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Ulica { get; set; }
        public string NrDomu { get; set; }
        public string KodPocz { get; set; }
        public string Miejscowosc { get; set; }
        public string Numer { get; set; }

        public override string ToString()
        {
            return "Imię: " + Imie + System.Environment.NewLine + "Nazwisko: " + Nazwisko + System.Environment.NewLine + "Adres zamieszkania: " + System.Environment.NewLine + Ulica + " " + NrDomu + System.Environment.NewLine + Miejscowosc + " " + KodPocz + System.Environment.NewLine + "Numer telefonu: " + Numer + System.Environment.NewLine;
        }
    }
}
