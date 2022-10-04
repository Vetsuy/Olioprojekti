using System;

namespace OlioProjekti
{
    // Äitiluokka
    class AMK
    {
        // Kentät
        private string AMKnimike;
        private string kayttaja;
        private string salasana;

        // Metodit
        public void Kirjaudu()                                                                  // "Kirjaa" käyttäjän sisään järjestelmään kun käyttäjä antaa käyttäjänimen ja salasanan
        {
            Console.WriteLine("                | -Kirjaudu sisään- |");
            Console.WriteLine();
            Console.Write("Käyttäjänimi: ");
            kayttaja = Console.ReadLine();
            Console.Write("Salasana: ");
            salasana = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("Tervetuloa käyttämään järjestelmäämme {0}!", kayttaja);
        }

        // Oletuskonstruktori
        public AMK()
        {
            AMKnimike = "Keuda";
            kayttaja = "";
            salasana = "";
        }
    }
    // Lapsiluokka AMK:sta
    class Tutkinto : AMK
    {
        // Kentät
        private string tutkintoNimike;

        // Metodit
        public void TulostaOpintojaksoTiedot()
        {

        }

        // Oletuskonstruktori
        public Tutkinto()
        {
            tutkintoNimike = "";
        }

        // Setterit ja getterit
        public string TutkintoNimike
        {
            set { tutkintoNimike = value; }
            get { return tutkintoNimike; }
        }
    }
    // Lapsiluokka Tutkinnosta
    class Opintojakso : Tutkinto
    {
        // Kentät
        private string opintoNimike, tutkinto;
        private int oppilas_luku, opettaja_luku;

        // Metodit
        public void TulostaTutkintoTiedot()
        {

        }

        // Oletuskonstruktori
        public Opintojakso()
        {
            opintoNimike = "";
            tutkinto = "";
            oppilas_luku = 0;
            opettaja_luku = 0;
        }

        // Setterit ja getterit
        public string OpintoNimike
        {
            set { opintoNimike = value; }
            get { return opintoNimike; }
        }
        public string Tutkinto
        {
            set { tutkinto = value; }
            get { return tutkinto; }
        }
        public int Oppilas_luku
        {
            set { oppilas_luku = value; }
            get { return oppilas_luku; }
        }
        public int Opettaja_luku
        {
            set { opettaja_luku = value; }
            get { return opettaja_luku; }
        }
    }
    // Lapsiluokka Opintojaksosta
    class Oppilas : Opintojakso
    {
        // Kentät
        private string oppilasNimi, oppilasOpintojakso;
        public static int laskuri;

        // Oletuskonstruktori
        public Oppilas()
        {
            oppilasNimi = "";
            oppilasOpintojakso = "";
            laskuri++;
        }

        //setteri ja getterit
        public string OppilasNimi
        {
            set { oppilasNimi = value; }
            get { return oppilasNimi; }
        }
        public string OppilasOpintojakso
        {
            set { oppilasOpintojakso = value; }
            get { return oppilasOpintojakso; }
        }
    }
    // Lapsiluokka Opintojaksosta
    class Opettaja : Opintojakso
    {
        // Kentät
        private string opettajaNimi, opettajaOpintojakso;

        // Oletuskonstruktori
        public Opettaja()
        {
            opettajaNimi = "";
            opettajaOpintojakso = "";
        }

        // setteri ja getterit
        public string OpettajaNimi
        {
            set { opettajaNimi = value; }
            get { return opettajaNimi; }
        }
        public string OpettajaOpintojakso
        {
            set { opettajaOpintojakso = value; }
            get { return opettajaOpintojakso; }
        }
    }
    // Pääohjelma
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("| Veeti Eskelinen | -Olioprojekti- | Joakim Pekola |");
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();

            AMK amk = new();
            // amk.Kirjaudu();

            string[] Etunimet =                                                         // Etunimien sanapankki
            {
                "Mainio ",    "Manne ",      "Manu ",
                "Markku ",    "Marko ",      "Markus ",
                "Martti ",    "Matias ",     "Matti ",
                "Mauno ",     "Maunu ",      "Max ",
                "Mauri ",     "Mies ",       "Miika ",
                "Miikka ",    "Mika ",       "Mikael ",
                "Mikko ",     "Miko ",       "Milo ",
                "Nestori ",   "Niila ",      "Niilo ",
                "Niki ",      "Niklas ",     "Niko ",
                "Nikolai ",   "Nikodemus ",  "Nooa ",
                "Noel ",      "Nuutti ",     "Nyyrikki ",
            };

            string[] Sukunimet =                                                        // Sukunimien sanapankki
            {
                "Haanpää",    "Haapakoski",  "Haavisto",
                "Hangen",     "Haikola",     "Haka",
                "Hakamäki",   "Hakasalo",    "Hakola",
                "Halinen",    "Halkola",     "Halmela",
                "Halmesmäki", "Halttu",      "Halvari",
                "Hamanda",    "Hannus",      "Hanski",
                "harjanne",   "Harva",       "Hautakoski",
                "Kaipia",     "Kaisla",      "Kakkonen",
                "Kivelä",     "Kanala",      "Kaukanen",
                "Kaukola",    "Keinonen",    "Kerttula",
                "Kiiveri",    "Kesäniemi",   "Kitunen",
            };

            Random rnd = new Random();                                                  // Tehdään rnd olio
            int number;                                                                 // Esitellään Random muuttuja

            Oppilas[] oppilas = new Oppilas[27];                                        // Tehdään uudet oliot oppilaille
            for (int i = 0; i < 27; i++)                                                // Nimetään oppilaat ja oliot
            {
                oppilas[i] = new Oppilas();

                number = rnd.Next(0, 32);
                int etunimi = number;
                number = rnd.Next(0, 32);
                string oppnimi = Etunimet[etunimi] + Sukunimet[number];

                oppilas[i].OppilasNimi = oppnimi;
            }

            Opettaja[] opettaja = new Opettaja[18];                                     // Tehdään uudet oliot opettajille
            for (int i = 0; i < 18; i++)                                                // Nimetään opettajat ja oliot
            {
                opettaja[i] = new Opettaja();

                number = rnd.Next(0, 32);
                int etunimi = number;
                number = rnd.Next(0, 32);
                string oppnimi = Etunimet[etunimi] + Sukunimet[number];

                opettaja[i].OpettajaNimi = oppnimi;
            }

            Tutkinto tutkinto1 = new Tutkinto();                                        // Tutkintojen oliot
            Tutkinto tutkinto2 = new Tutkinto();
            Tutkinto tutkinto3 = new Tutkinto();

            tutkinto1.TutkintoNimike = "Tieto ja viestintätekniikka";                   // Tutkinotojen olioiden
            tutkinto2.TutkintoNimike = "Bioanalyytikko";
            tutkinto3.TutkintoNimike = "Hortonomi";

            Opintojakso[] opintojakso = new Opintojakso[9];                             // Tehdään uusi olio
            for (int i = 0; i < 9; i++)                                                 // Luodaan opintojaksojen oliot
            {
                opintojakso[i] = new Opettaja();
            }

            int fgg = 1;
            for (int i = 0; i <= 2; i++)                                                // Nimetään opintoNimike
            {
                opintojakso[i].OpintoNimike = "syksy" + fgg;
                opintojakso[i + 3].OpintoNimike = "talvi" + fgg;
                opintojakso[i + 6].OpintoNimike = "kevät" + fgg;
                fgg++;
            }
        }
    }
}