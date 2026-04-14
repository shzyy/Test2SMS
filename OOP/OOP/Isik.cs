namespace OOP
{
    public class Isik
    {
        // Omadused ehk väljad
        // Privaatne väli - otse ligi ei saa
        private int sünniaasta;

        // Avalik omadus (Property) automaatse get/set logikaga
        public string Nimi { get; set; }

        // Kontrollitud omadus
        public int Sünniaasta
        {
            get { return sünniaasta; }
            set
            {
                if (value > 1900 && value <= DateTime.Now.Year)
                    sünniaasta = value;
                else
                    Console.WriteLine("Vigane sünniaasta!");
            }
        }

        // Arvutatud omadus (ainult lugemiseks / getter)
        public int Vanus => DateTime.Now.Year - sünniaasta;

        // Tegevus ehk meetod
        public void Tervita()
        {
            if (string.IsNullOrEmpty(Nimi) || sünniaasta == 0)
            {
                Console.WriteLine("Vigane sünniaasta!");
            }
            else
                Console.WriteLine($"Tere! Mina olen {Nimi} ja ma olen {Vanus} aastat vana. Olen sündinud {Sünniaasta}");
            
        }
    }
}