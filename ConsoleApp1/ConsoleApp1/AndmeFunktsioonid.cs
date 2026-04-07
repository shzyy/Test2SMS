using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{

public static class AndmeFunktsioonid
    {
        // Ülesanne 1
        public static void KirjutaLogi(string teade)
        {
            using (StreamWriter sw = new StreamWriter("logi.txt", true))
            {
                sw.WriteLine($"[{DateTime.Now}] - {teade}");
            }
        }

        // Ülesanne 2
        public static void RiigiOtsing()
        {
            Dictionary<string, string> riigid = new Dictionary<string, string>()
        {
            {"EE", "Eesti"},
            {"FI", "Soome"},
            {"DE", "Saksamaa"}
        };

            Console.Write("Sisesta riigi kood: ");
            string kood = Console.ReadLine().ToUpper();

            if (riigid.ContainsKey(kood))
            {
                Console.WriteLine("Riik: " + riigid[kood]);
            }
            else
            {
                Console.Write("Tundmatu kood. Mis riik see on? ");
                string nimi = Console.ReadLine();
                riigid.Add(kood, nimi);
            }

            Console.WriteLine("\nKõik riigid:");
            foreach (KeyValuePair<string, string> paar in riigid)
            {
                Console.WriteLine($"{paar.Key} - {paar.Value}");
            }
        }

        // Ülesanne 3
        public static Tuple<int, double> LoeJaArvuta()
        {
            try
            {
                string tekst = File.ReadAllText("arvud.txt");
                string[] osad = tekst.Split(',');

                int summa = 0;

                foreach (string s in osad)
                {
                    summa += int.Parse(s.Trim());
                }

                double keskmine = (double)summa / osad.Length;

                return new Tuple<int, double>(summa, keskmine);
            }
            catch (Exception)
            {
                Console.WriteLine("Viga faili lugemisel!");
                return new Tuple<int, double>(0, 0);
            }
        }

        // Ülesanne 4-5
        public static void HaldaAutosid()
        {
            List<Auto> autod = new List<Auto>()
    {
        new Auto("Toyota", 5.5, 40),
        new Auto("BMW", 8.0, 15),
        new Auto("Audi", 6.5, 8)
    };

            Console.WriteLine("Kõik autod:");
            foreach (Auto auto in autod)
            {
                Console.WriteLine($"Mudel: {auto.Mudel}, " +
                                  $"Kütusekulu: {auto.KutuseKulu:F2}, " +
                                  $"Paagis: {auto.PaagisOnKutust:F2}, " +
                                  $"Sõiduulatus: {auto.ArvutaSoiduulatus():F2} km");
            }

            Auto parim = autod[0];

            foreach (Auto auto in autod)
            {
                if (auto.ArvutaSoiduulatus() > parim.ArvutaSoiduulatus())
                {
                    parim = auto;
                }
            }

            Console.WriteLine($"\nSuurima ulatusega auto: {parim.Mudel} ({parim.ArvutaSoiduulatus():F2} km)");

            Console.WriteLine("\nAutod, mis vajavad tankimist:");
            foreach (Auto auto in autod)
            {
                if (auto.PaagisOnKutust < 10)
                {
                    Console.WriteLine($"{auto.Mudel} ({auto.PaagisOnKutust:F2} L)");
                }
            }

            double koguKutus = 0;
            foreach (Auto auto in autod)
            {
                koguKutus += auto.PaagisOnKutust;
            }

            double keskmine = koguKutus / autod.Count;

            File.WriteAllText("autod_tulemus.txt", $"Keskmine kütus paagis: {keskmine:F2}");
        }
    }

}


