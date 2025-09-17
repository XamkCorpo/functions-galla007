namespace Calculator
{
    internal class Program
    {
        /// <summary>
        /// Kysyy laskutoimituksen
        /// </summary>
        /// <returns>valitun laskitoimituksen</returns>
        static int ValitseLaskuToimitus()
        {
            while (true)
            {
                int valinta = 0;
                Console.WriteLine("Valitse laskutoimitus (1: Yhteenlasku, 2: Vähennyslasku, 3: Kertolasku, 4: Jakolasku)");
                string laskuToimitus = Console.ReadLine();

                
                if (int.TryParse(laskuToimitus, out valinta) && valinta >= 1 && valinta <= 4)
                    return valinta;

                    Console.WriteLine("Valitse oikea ohjelma");
            }
        }
        /// <summary>
        /// Kysyy ensimmäisen luvun
        /// </summary>
        /// <returns>luvun</returns>
        static decimal EnsimmäinenLuku()
        {
            while (true)
            {
                Console.WriteLine("Valitse ensimmäinen lukusi");
                string ekaLuku = Console.ReadLine();

                decimal eka;
                if (decimal.TryParse(ekaLuku, out eka))
                    return eka;

                    Console.WriteLine("Syötä numero");
            }
        }
        /// <summary>
        /// Kysyy toisen luvun
        /// </summary>
        /// <returns>luvun</returns>
        static decimal ToinenLuku()
        {
            while (true)
            {
                Console.WriteLine("Valitse toinen lukusi");
                string tokaLuku = Console.ReadLine();

                decimal toka;
                if (decimal.TryParse(tokaLuku, out toka))
                    return toka;

                    Console.WriteLine("Syötä numero");
            }
        }
        static void MolemmatLuvut(decimal eka, decimal toka)
        {
        }

        static decimal YhteenLasku()
        {
            decimal laskettuYhteen = Math.Round(eka + toka, 3);
            return laskettuYhteen;
        }

        static void Main(string[] args)
        {
            int testi = ValitseLaskuToimitus();
            //Console.WriteLine($"{testi}");

            decimal testi2 = EnsimmäinenLuku();
            //Console.WriteLine($"{testi2}");

            decimal testi3 = ToinenLuku();
            //Console.WriteLine($"{testi3}");

            decimal testi4 = YhteenLasku();
            Console.WriteLine(testi4);
        }
    }
}
