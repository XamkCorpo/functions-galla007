using System;

namespace Calculator
{
    internal class Program
    {
        /// <summary>
        /// Kysyy laskutoimituksen
        /// </summary>
        /// <returns>valitun laskitoimituksen</returns>
        static decimal ValitseLaskuToimitus()
        {
            while (true)
            {
                Console.WriteLine("Valitse laskutoimitus (1: Yhteenlasku, 2: Vähennyslasku, 3: Kertolasku, 4: Jakolasku)");
                string laskuToimitus = Console.ReadLine();

                if (int.TryParse(laskuToimitus, out int valinta) && valinta >= 1 && valinta <= 4)
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
        static decimal ToinenLuku(decimal valinta)
        {
            while (true)
            {
                Console.WriteLine("Valitse toinen lukusi");
                string tokaLuku = Console.ReadLine();
                decimal toka;

                if (decimal.TryParse(tokaLuku, out toka))
                    {
                    if (valinta == 4 && toka == 0)
                    {
                        Console.WriteLine("Nollalla ei voi jakaa, syötä eri numero");
                    }
                    else
                    { return toka;
                    }
                }
                else
                {
                    Console.WriteLine("Syötä numero");
                }

            }
        }
        /// <summary>
        /// yhteenlasku
        /// </summary>
        /// <returns>yhteenlaskun tuloksen</returns>
        static decimal YhteenLasku(decimal eka, decimal toka)
        {
            decimal laskettuYhteen = Math.Round(eka + toka, 3);
            return laskettuYhteen;
        }
        /// <summary>
        /// miinuslasku
        /// </summary>
        /// <returns>miinuslaskun tuloksen</returns>
        static decimal Vähennyslasku(decimal eka, decimal toka)
        {
            decimal vähennetty = Math.Round(eka - toka, 3);
            return vähennetty;
        }
        /// <summary>
        /// kertolasku
        /// </summary>
        /// <returns>kertolaskun tuloksen</returns>
        static decimal KertoLasku(decimal eka, decimal toka)
        {
            decimal kerrottu = Math.Round(eka * toka, 3);
            return kerrottu;
        }
        /// <summary>
        /// jakolasku
        /// </summary>
        /// <returns>jakolaskun tuloksen</returns>
        static decimal JakoLasku(decimal eka, decimal toka)
        {
            decimal jaettu = Math.Round(eka / toka, 3);
            return jaettu;
        }
        /// <summary>
        /// Tarkistaa mikä on jokaisen mahdollisen laskun tulos
        /// </summary>
        /// <returns>valitun laskutoimituksen tuloksen</returns>
        static decimal TulostaTulos(decimal valinta, decimal laskettuYhteen, decimal vähennetty, decimal kerrottu, decimal jaettu)
        {
            decimal tulos = 0;
            {
                if (valinta == 1)
                    tulos = laskettuYhteen;
                else if (valinta == 2)
                    tulos = vähennetty;
                else if (valinta == 3)
                    tulos = kerrottu;
                else if (valinta == 4)
                    tulos = jaettu;                    
            }
            return tulos; //
        }
        /// <summary>
        /// Valitsee sopivan merkin
        /// </summary>
        /// <returns>riippuen + - * / </returns>
        static string Merkki(decimal valinta)
        {
            string merkki = "";
            {
                if (valinta == 1)
                    merkki = "+";
                else if (valinta == 2)
                    merkki = "-";
                else if (valinta == 3)
                    merkki = "*";
                else if (valinta == 4)
                    merkki = "/";
            }
            return merkki;
        }
        static void Main(string[] args)
        {
            decimal printLaskuToimitus = ValitseLaskuToimitus();

            decimal numero1 = EnsimmäinenLuku();
            decimal numero2 = ToinenLuku(printLaskuToimitus);

            decimal laskettuYhteen = YhteenLasku(numero1, numero2);
            decimal vähennetty = Vähennyslasku(numero1, numero2);
            decimal kerrottu = KertoLasku(numero1, numero2);
            decimal jaettu = JakoLasku(numero1, numero2);

            string merkkiOutput = Merkki(printLaskuToimitus);
            decimal vastaus = TulostaTulos(printLaskuToimitus, laskettuYhteen, vähennetty, kerrottu, jaettu);

            Console.WriteLine($"Tulos: {numero1} {merkkiOutput} {numero2} = {vastaus}");           
        }
    }
}