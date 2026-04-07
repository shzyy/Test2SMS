using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    public class Auto
    {
        public string Mudel { get; set; }
        public double KutuseKulu { get; set; } // l / 100km
        public double PaagisOnKutust { get; set; }

        public Auto(string mudel, double kutuseKulu, double paagisOnKutust)
        {
            Mudel = mudel;
            KutuseKulu = kutuseKulu;
            PaagisOnKutust = paagisOnKutust;
        }

        public double ArvutaSoiduulatus()
        {
            return (PaagisOnKutust / KutuseKulu) * 100;
        }
    }
}