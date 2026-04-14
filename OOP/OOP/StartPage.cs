using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    internal class StartPage
    {
        public static void Main(string[] args)
        {
            Isik inimene1 = new Isik();
            inimene1.Nimi = "Mati";
            inimene1.Sünniaasta = 28;
            inimene1.Tervita();
            // Väljund: Tere! Mina olen Mati...
        }
    }
}
