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
        public string Adres { get; set; }
        public string Numer { get; set; }

        public override string ToString()
        {
            return "Imię: " + Imie + System.Environment.NewLine + "Nazwisko: " + Nazwisko + System.Environment.NewLine + "Adre zamieszkania: " + Adres + System.Environment.NewLine + "Numer telefonu " + Numer + System.Environment.NewLine;
        }
    }
}
