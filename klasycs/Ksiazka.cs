using System;
using System.Collections.Generic;
using System.Text;

namespace klasycs
{
    public class Ksiazka
    {
        public string Tytul { get; set; }
        public string Autor { get; set; }
        public int Regal { get; set; }
        public int Polka { get; set; }
        public int Miejsce { get; set; }

        public Ksiazka(string tytul,string autor,int regal,int polka,int miejsce)
        {
            Tytul = tytul;
            Autor = autor;
            Regal = regal;
            Polka = polka;
            Miejsce = miejsce;
        }
       
    }
}
