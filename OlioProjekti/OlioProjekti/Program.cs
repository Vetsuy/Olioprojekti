using System;
using System.Reflection;

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
        public void Kirjaudu()                                                                               // "Kirjaa" käyttäjän sisään järjestelmään kun käyttäjä antaa käyttäjänimen ja salasanan
        {
            Console.WriteLine("                | -Luo uusi käyttäjä- |");
            Console.WriteLine();
            Console.Write("Käyttäjänimi: ");
            kayttaja = Console.ReadLine();
            Console.Write("Salasana: ");
            salasana = Console.ReadLine();
            Console.WriteLine();

        alku:
            Console.WriteLine("                 | -Kirjaudu sisään- |");
            Console.WriteLine();
            Console.Write("Käyttäjänimi: ");
            string annettu_kayttajanimi = Console.ReadLine();
            Console.Write("Salasana: ");
            string annettu_salasana = Console.ReadLine();

            if (kayttaja != annettu_kayttajanimi || salasana != annettu_salasana)
            {
                Console.WriteLine();
                Console.WriteLine("!!! Käyttäjänimi tai salasana on väärin, yritä uudestaan. !!!");
                Console.WriteLine();
                goto alku;
            }

            Console.WriteLine();
            Console.WriteLine("Tervetuloa käyttämään {0}n järjestelmää {1}!", AMKnimike, kayttaja);
            Console.WriteLine();
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

        

        // Oletuskonstruktori
        public Opintojakso()
        {
            opintoNimike = "";
            tutkinto = "";
            oppilas_luku = 3;
            opettaja_luku = 2;
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

        // setteri ja getterit
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
            amk.Kirjaudu();

            string[] Etunimet =                                                                 // Etunimien sanapankki
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

            string[] Sukunimet =                                                                // Sukunimien sanapankki
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

            Random rnd = new Random();                                                         // Tehdään rnd olio
            int number;                                                                        // Esitellään Random muuttuja

            Oppilas[] oppilas = new Oppilas[27];                                               // Tehdään uudet oliot oppilaille
            for (int i = 0; i < 27; i++)                                                       // Luodaan sekä nimetään oppilaat ja oliot
            {
                oppilas[i] = new Oppilas();

                number = rnd.Next(0, 32);
                int etunimi = number;
                number = rnd.Next(0, 32);
                string oppnimi = Etunimet[etunimi] + Sukunimet[number];

                oppilas[i].OppilasNimi = oppnimi;
            }

            Opettaja[] opettaja = new Opettaja[18];                                            // Tehdään uudet oliot opettajille
            for (int i = 0; i < 18; i++)                                                       // Luodaan sekä nimetään opettajat ja oliot
            {
                opettaja[i] = new Opettaja();

                number = rnd.Next(0, 32);
                int etunimi = number;
                number = rnd.Next(0, 32);
                string openimi = Etunimet[etunimi] + Sukunimet[number];

                opettaja[i].OpettajaNimi = openimi;
            }

            Tutkinto tutkinto1 = new Tutkinto();                                               // Luodaan Tutkintojen oliot
            Tutkinto tutkinto2 = new Tutkinto();
            Tutkinto tutkinto3 = new Tutkinto();

            tutkinto1.TutkintoNimike = "Tieto ja viestintätekniikka";                          // Annetaan TutkintoNimikkeiden arvot
            tutkinto2.TutkintoNimike = "Bioanalyytikko";
            tutkinto3.TutkintoNimike = "Hortonomi";

            Opintojakso[] opintojakso = new Opintojakso[9];                                    // Tehdään uusi olio
            for (int i = 0; i < 9; i++)                                                        // Luodaan opintojaksojen oliot
            {
                opintojakso[i] = new Opettaja();
            }

            int plus = 1;
            for (int i = 0; i <= 2; i++)                                                       // Nimetään opintoNimike
            {
                opintojakso[i].OpintoNimike = "Syksy " + plus;
                opintojakso[i + 3].OpintoNimike = "Talvi " + plus;
                opintojakso[i + 6].OpintoNimike = "Kevät " + plus;
                plus++;
            }

            opintojakso[0].Tutkinto = "Tieto ja viestintätekniikka";                           // OpintoJakson tutkinta kentän arvot
            opintojakso[1].Tutkinto = "Bioanalyytikko";
            opintojakso[2].Tutkinto = "Hortonomi";
            opintojakso[3].Tutkinto = "Tieto ja viestintätekniikka";
            opintojakso[4].Tutkinto = "Bioanalyytikko";
            opintojakso[5].Tutkinto = "Hortonomi";
            opintojakso[6].Tutkinto = "Tieto ja viestintätekniikka";
            opintojakso[7].Tutkinto = "Bioanalyytikko";
            opintojakso[8].Tutkinto = "Hortonomi";                                            // OpintoJakson tutkinta kentän arvot



            for (int i = 0; i < 27; i++)                                                      // Antaa oppilas olioden oppilasopintojakso kentälle arvon
            {
                if (i < 0 || i > 26)
                {
                    Console.WriteLine("Jokin meni pieleen.");
                    return;
                }
                if (i < 3)
                {
                    oppilas[i].OppilasOpintojakso = "Syksy 1";
                }
                else if (i < 6)
                {
                    oppilas[i].OppilasOpintojakso = "Syksy 2";
                }
                else if (i < 9)
                {
                    oppilas[i].OppilasOpintojakso = "Syksy 3";
                }
                else if (i < 12)
                {
                    oppilas[i].OppilasOpintojakso = "Talvi 1";
                }
                else if (i < 15)
                {
                    oppilas[i].OppilasOpintojakso = "Talvi 2";
                }
                else if (i < 18)
                {
                    oppilas[i].OppilasOpintojakso = "Talvi 3";
                }
                else if (i < 21)
                {
                    oppilas[i].OppilasOpintojakso = "Kevät 1";
                }
                else if (i < 24)
                {
                    oppilas[i].OppilasOpintojakso = "Kevät 2";
                }
                else if (i < 27)
                {
                    oppilas[i].OppilasOpintojakso = "Kevät 3";
                }
            }

            for (int i = 0; i < 18; i++)                                                   // antaa opettaja olilioden opettajaOpintojakso kentälle arvon
            {
                if (i < 0 || i > 17)
                {
                    Console.WriteLine("Jokin meni pieleen.");
                    return;
                }
                if (i < 2)
                {
                    opettaja[i].OpettajaOpintojakso = "Syksy 1";
                }
                else if (i < 4)
                {
                    opettaja[i].OpettajaOpintojakso = "Syksy 2";
                }
                else if (i < 6)
                {
                    opettaja[i].OpettajaOpintojakso = "Syksy 3";
                }
                else if (i < 8)
                {
                    opettaja[i].OpettajaOpintojakso = "Talvi 1";
                }
                else if (i < 10)
                {
                    opettaja[i].OpettajaOpintojakso = "Talvi 2";
                }
                else if (i < 12)
                {
                    opettaja[i].OpettajaOpintojakso = "Talvi 3";
                }
                else if (i < 14)
                {
                    opettaja[i].OpettajaOpintojakso = "Kevät 1";
                }
                else if (i < 16)
                {
                    opettaja[i].OpettajaOpintojakso = "Kevät 2";
                }
                else if (i < 18)
                {
                    opettaja[i].OpettajaOpintojakso = "Kevät 3";
                }
            }

            opintoAlku:
            Console.WriteLine("Valitse tutkinto alla olevista vaihtoehdoista");                                   // kysymis taulukko
            Console.WriteLine("------------------------------------------");
            Console.WriteLine(" Tieto ja viestintätekniikka..........[1]");
            Console.WriteLine(" Bioanalyytikko.......................[2]");
            Console.WriteLine(" Hortonomi............................[3]");
            Console.WriteLine("------------------------------------------");
            Console.Write(">> ");
            int valinta = int.Parse(Console.ReadLine());
            Console.WriteLine();

            string[] OpintojaksoTaulukko = new string[3];                                                         // luodaan uusi aray

            int laskuri = 0;        
            switch (valinta)                                                                                      // laitetaan arayhin opintojaksot jotka ovat osana valittua tutkintoa
            {
                case 1:
                    for (int i = 0; i < 9; i++)
                    {
                        if (opintojakso[i].Tutkinto == "Tieto ja viestintätekniikka")
                        {
                            OpintojaksoTaulukko[laskuri] = opintojakso[i].OpintoNimike;
                            laskuri++;
                        }
                    }
                    break;

                case 2:
                    for (int i = 0; i < 9; i++)
                    {
                        if (opintojakso[i].Tutkinto == "Bioanalyytikko")
                        {
                            OpintojaksoTaulukko[laskuri] = opintojakso[i].OpintoNimike;
                            laskuri++;
                        }
                    }
                    break;

                case 3:
                    for (int i = 0; i < 9; i++)
                    {
                        if (opintojakso[i].Tutkinto == "Hortonomi")
                        {
                            OpintojaksoTaulukko[laskuri] = opintojakso[i].OpintoNimike;
                            laskuri++;
                        }
                    }
                    break;

                default:
                    Console.WriteLine("!!! Annoit väärän arvon, yritä uudelleen. !!!");
                    Console.WriteLine();
                    goto opintoAlku;
            }

            Alku:
            Console.WriteLine("Valitse opintojakso alla olevista vaihtoehdoista");                               // kysyntä taulukko
            Console.WriteLine("----------------------");
            Console.WriteLine(" {0}..........[1]", OpintojaksoTaulukko[0]);
            Console.WriteLine(" {0}..........[2]", OpintojaksoTaulukko[1]);
            Console.WriteLine(" {0}..........[3]", OpintojaksoTaulukko[2]);
            Console.WriteLine("----------------------");
            Console.Write(">> ");
            int valinta1 = int.Parse(Console.ReadLine());
            Console.WriteLine();

            string[] OppilasTaulukko = new string[3];                                                            // tehdään uusi aray
            string[] OpettajaTaulukko = new string[2];                                                           // tehdäänt uusi aray

            laskuri = 0;
            switch (valinta1)                                                                                    // tallenetaan opilaiten nimet arayhin jotka ovat osana valittua opintojaksoa
            {
                case 1:
                    for (int i = 0; i < 27; i++)
                    {
                        if (oppilas[i].OppilasOpintojakso == OpintojaksoTaulukko[0])
                        {
                            OppilasTaulukko[laskuri] = oppilas[i].OppilasNimi;
                            laskuri++;
                        }
                    }

                    laskuri = 0;

                    for (int i = 0; i < 18; i++)
                    {
                        if (opettaja[i].OpettajaOpintojakso == OpintojaksoTaulukko[0])
                        {
                            OpettajaTaulukko[laskuri] = opettaja[i].OpettajaNimi;
                            laskuri++;
                        }
                    }
                    break;

                case 2:
                    for (int i = 0; i < 27; i++)
                    {
                        if (oppilas[i].OppilasOpintojakso == OpintojaksoTaulukko[1])
                        {
                            OppilasTaulukko[laskuri] = oppilas[i].OppilasNimi;
                            laskuri++;
                        }
                    }

                    laskuri = 0;

                    for (int i = 0; i < 18; i++)                                                                 // tallenetaan opettaijien nimet arayhin jotka ovat osana valittua opintojaksoa
                    {
                        if (opettaja[i].OpettajaOpintojakso == OpintojaksoTaulukko[0])
                        {
                            OpettajaTaulukko[laskuri] = opettaja[i].OpettajaNimi;
                            laskuri++;
                        }
                    }
                    break;

                case 3:
                    for (int i = 0; i < 27; i++)
                    {
                        if (oppilas[i].OppilasOpintojakso == OpintojaksoTaulukko[2])
                        {
                            OppilasTaulukko[laskuri] = oppilas[i].OppilasNimi;
                            laskuri++;
                        }
                    }

                    laskuri = 0;

                    for (int i = 0; i < 18; i++)
                    {
                        if (opettaja[i].OpettajaOpintojakso == OpintojaksoTaulukko[0])
                        {
                            OpettajaTaulukko[laskuri] = opettaja[i].OpettajaNimi;
                            laskuri++;
                        }
                    }
                    break;

                default:
                    Console.WriteLine("!!! Annoit väärän arvon, yritä uudelleen. !!!");
                    Console.WriteLine();
                    goto Alku;
            }

            Console.WriteLine("Tässä on {0} osallistujat:", OpintojaksoTaulukko[valinta1 - 1]);                                                                                         //tulostetaan mikä opintoajakso on ja monta opetajaa ja oppilasta on kursilla ja niiden nimet
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine(" Osallistuvia oppilaita on {0}. Oppilaat ovat: {1}, {2}, {3}", OppilasTaulukko.Length, OppilasTaulukko[0], OppilasTaulukko[1], OppilasTaulukko[2]);
            Console.WriteLine(" Osallistuvia opettajia on {0}. Opettajat ovat: {1}, {2}", OpettajaTaulukko.Length, OpettajaTaulukko[0], OpettajaTaulukko[1]);
            Console.WriteLine("-----------------------------------------------------------------------------------------");

            Console.WriteLine("Luotujen Oppilas olioiden määrä: {0}", Oppilas.laskuri);
        }
    }
}