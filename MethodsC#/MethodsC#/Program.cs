using System.Globalization;


namespace C_opgaverP1
{
    internal class hovedMenu
    {
        static void Main(string[] args)
        {
            while (true)
            {
                // Udskriv hovedmenuen
                Console.Clear();

                Console.WriteLine("\n\tVælg en Opgavetype (skriv tallet)");
                Console.WriteLine();
                Console.WriteLine("\t1. \tReturnering af en streng");
                Console.WriteLine("\t2. \tUdskrivning af brugerinput");
                Console.WriteLine("\t3. \tSummen af tre tal");
                Console.WriteLine("\t4. \tSubtraktion af tre tal");
                Console.WriteLine("\t5. \tMultiplikation af tre tal");
                Console.WriteLine("\t6. \tSummen af to tal divideret med et trejde");
                Console.WriteLine("\t7. \tNavn og alder med gruppeinddeling");
                Console.WriteLine("\t8. \tOpdeling af komma-separeret streng");
                Console.WriteLine("\t9. \tGæt et tal-spil");
                Console.WriteLine("\t10. \tOpgave 7.");
                Console.WriteLine("\t11. \tOpgave 7a.");
                Console.WriteLine("\t12. \tOpgave 7b.");
                Console.WriteLine("\t13. \tOpgave 7c.");
                Console.WriteLine("\t0. \tAfslut");

                // Læs brugerens valg
                string valg = Console.ReadLine();

                // Håndtere brugerens valg
                switch (valg)
                {
                    case "1":
                        Opgave1.HelloWorld();
                        break;
                    case "2":
                        Opgave2.BrugerInput();
                        break;
                    case "3":
                        Opgave3.TalInput();
                        break;
                    case "4":
                        Opgave3A.TalInputA();
                        break;
                    case "5":
                        Opgave3B.TalInputB();
                        break;
                    case "6":
                        Opgave3C.TalInputC();
                        break;
                    case "7":
                        Opgave4.AldersGruppe();
                        break;
                    case "8":
                        Opgave5.OpdelString();
                        break;
                    case "9":
                        Opgave6.GætEtTal();
                        break;
                    case "10":
                        Opgave7.HovedMenu();
                        break;
                    case "11":
                        Opgave7a.Temp();
                        break;
                    case "12":
                        Opgave7b.OmregnTal();
                        break;
                    case "13":
                        Opgave7c.HåndterInput();
                        break;
                    case "0":
                        Console.Clear();
                        Console.WriteLine("Farvel!");
                        return;
                    default:
                        Console.WriteLine("Ugyldigt valg, prøv igen.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }

    public class AflsutEllerTilbage
    {
        public static void Tilbage(Action genstartOpgave)
        {
              // Menu efter opgaver
            Console.WriteLine("");
            Console.WriteLine("Tryk enter for at gå tilbage til menuen.");
            Console.WriteLine("Tryk 1 for at køre opgaven igen.");
            Console.WriteLine("Tryk 0 for at afslutte programmet.");

            string valg = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(valg))
            {
                Console.WriteLine("Tilbage til menuen...");
                return; // Gå tilbage til hovedmenuen
            }
            else if (valg == "1")
            {
                Console.WriteLine("Kører opgaven igen...");
                genstartOpgave(); // Kald opgaven igen
            }
            else if (valg == "0")
            {
                Console.WriteLine("Programmet afsluttes.");
                Environment.Exit(0); // Luk programmet
            }
        }
    }

    // Opgave 1 klasse
    // Har valgt at kalde metoden fra HelloWorld-metoden istedet for Main-metoden 
    internal class Opgave1
    {
        // Metode til at udføre opgave 1
        public static void HelloWorld()
        {
            Console.Clear();

            // Kald metoden der returnerer "Hello World!"
            string message = GetMessage();
            Console.WriteLine(message);

            // Vent på brugerens input, før der returneres til menuen
            Console.ReadKey();
            Console.Clear();
            AflsutEllerTilbage.Tilbage(HelloWorld);
        }

        // Metode, der returnerer "Hello World!"
        private static string GetMessage()
        {
            return "Hello World!";
            
        }

        
    }

    internal class Opgave2 
    {
        public static void BrugerInput()
        {
            Console.Clear();

            // bed brugeren om input 
            Console.WriteLine("Indtast en teksstreng: ");
            string BrugerInput = Console.ReadLine();

            // Kald metoden der udksriver brugerens input
            PrintInput(BrugerInput);

            Console.ReadKey();
            Console.Clear();
            AflsutEllerTilbage.Tilbage(Opgave2.BrugerInput);

        }
        // Metode, der udskriver brugerens input
        private static void PrintInput(string input)
        {
            Console.WriteLine($"Du skrev: {input}");
        }
    }

    internal class Opgave3
    {
        public static void TalInput()
        {
            Console.Clear();

            // bed brugeren om input 
            Console.WriteLine("Indtast et tal: ");
            string input1 = Console.ReadLine();
            int tal1 = int.Parse(input1);

            // bed brugeren om input 
            Console.WriteLine("Indtast et tal: ");
            string input2 = Console.ReadLine();
            int tal2 = int.Parse(input2);

             // bed brugeren om input 
            Console.WriteLine("Indtast et tal: ");
            string input3 = Console.ReadLine();
            int tal3 = int.Parse(input3);

            // kald metoden der returnere summen af de tre tal 
            int sum = TalSum(tal1, tal2, tal3);

            // udskriv summen 
            Console.WriteLine($"Summen af de tre tal er: {sum}");
            
            Console.ReadKey();
            Console.Clear();
            AflsutEllerTilbage.Tilbage(TalInput);
        }
        private static int TalSum(int tal1, int tal2, int tal3)
        {
            return tal1 + tal2 + tal3; 
        }
    }

    internal class Opgave3A
    {
        public static void TalInputA()
        {
            Console.Clear();

            // bed brugeren om input 
            Console.WriteLine("Indtast et tal: ");
            string input1 = Console.ReadLine();
            int tal1 = int.Parse(input1);

            // bed brugeren om input 
            Console.WriteLine("Indtast et tal: ");
            string input2 = Console.ReadLine();
            int tal2 = int.Parse(input2);

             // bed brugeren om input 
            Console.WriteLine("Indtast et tal: ");
            string input3 = Console.ReadLine();
            int tal3 = int.Parse(input3);

            // kald metoden der returnere summen af de tre tal 
            int sum = TalSumMinus(tal1, tal2, tal3);

            // udskriv summen 
            Console.WriteLine($"Summen af de tre tal er: {sum}");

            Console.ReadKey();
            Console.Clear();
            AflsutEllerTilbage.Tilbage(TalInputA);
        }
        private static int TalSumMinus(int tal1, int tal2, int tal3)
        {
            return tal1 - tal2 - tal3; 
        }
    }

    internal class Opgave3B
    {
        public static void TalInputB()
        {
            Console.Clear();

            // bed brugeren om input 
            Console.WriteLine("Indtast et tal: ");
            string input1 = Console.ReadLine();
            int tal1 = int.Parse(input1);

            // bed brugeren om input 
            Console.WriteLine("Indtast et tal: ");
            string input2 = Console.ReadLine();
            int tal2 = int.Parse(input2);

             // bed brugeren om input 
            Console.WriteLine("Indtast et tal: ");
            string input3 = Console.ReadLine();
            int tal3 = int.Parse(input3);

            // kald metoden der returnere summen af de tre tal 
            int sum = TalSumGange(tal1, tal2, tal3);

            // udskriv summen 
            Console.WriteLine($"Summen af de tre tal er: {sum}");

            Console.ReadKey();
            Console.Clear();
            AflsutEllerTilbage.Tilbage(TalInputB);
        }
        private static int TalSumGange(int tal1, int tal2, int tal3)
        {
            return tal1 * tal2 * tal3; 
        }
    }

    internal class Opgave3C
    {
        public static void TalInputC()
        {
            Console.Clear();

            // bed brugeren om input 
            Console.WriteLine("Indtast et tal: ");
            string input1 = Console.ReadLine();
            int tal1 = int.Parse(input1);

            // bed brugeren om input 
            Console.WriteLine("Indtast et tal: ");
            string input2 = Console.ReadLine();
            int tal2 = int.Parse(input2);

             // bed brugeren om input 
            Console.WriteLine("Indtast et tal: ");
            string input3 = Console.ReadLine();
            int tal3 = int.Parse(input3);

            // kald metoden der returnere summen af de tre tal 
            int sum = TalSumGange(tal1, tal2, tal3);

            // udskriv summen 
            Console.WriteLine($"Summen af de tre tal er: {sum}");

            Console.ReadKey();
            Console.Clear();
            AflsutEllerTilbage.Tilbage(TalInputC);
        }
        private static int TalSumGange(int tal1, int tal2, int tal3)
        {
            return (tal1 + tal2) / tal3; 
        }
    }

    internal class Opgave4
    {
        public static void AldersGruppe()
        {
            Console.Clear();

            // bed brugeren om input (navn)
            Console.WriteLine("Indtast dit navn: ");
            string navn = Console.ReadLine();

            // bed brugeren om input (alder)
            Console.WriteLine("Indtast din alder: ");
            string input = Console.ReadLine();
            int alder = int.Parse(input);

            // kald metoden der bestemmer aldersgruppen 
            string besked = BestemAldersGruppe(navn, alder);

            // udskriv besked 
            Console.WriteLine($"Hej {navn} {besked}");

            Console.ReadKey();
            Console.Clear();
            AflsutEllerTilbage.Tilbage(AldersGruppe);
        }

        private static string BestemAldersGruppe(string navn, int alder)
        {
            string besked;

            // bestem gruppen baseret på brugerens alder
            if (alder >= 0 && alder <= 1)
            {
                besked = "Du er nyfødt";
            }
            else if (alder >= 2 && alder <= 3)
            {
                besked = "Du er i dagpleje eller vuggestue";
            }
            else if (alder >= 4 && alder <= 5)
            {
                besked = "Du er i børnehave";
            }
            else if (alder >= 6 && alder <= 18)
            {
                besked = "Du går i skole";
            }
            else 
            {
                besked = "Nu begynder livet at blive alvor";
            }
            return besked;
        }
    }

    internal class Opgave5
    {
        public static void OpdelString()
        {
            Console.Clear();

            // bed brugeren om at indtaste en komma-separeret string
            Console.WriteLine("Indtast en komma-separeret string med værdier: ");
            string input = Console.ReadLine();

            // kald metoden der splitter string og returnerer et array 
            string[] array = SplitString(input);

            // udskriv størrelsen af arrayet 
            Console.WriteLine($"Arrayets størrelse er: {array.Length}");

            // udkriv hver værdi i arrayet 
            Console.WriteLine("Værdierne i arrayet er: ");
            for(int i = 0; i < array.Length; i++)
            {
                    Console.WriteLine(array[i]);
            }

            Console.ReadKey();
            Console.Clear();
            AflsutEllerTilbage.Tilbage(OpdelString);
        }
        // metode der splitter string og returnere array 
        private static string[] SplitString(string input)
        {
            // splitter string ved komma og returnerer et array 
            return input.Split(',');
        }
    }

    internal class Opgave6 
    {
        public static void GætEtTal()
        {   
            Console.Clear();
            
            // bed bruger om at gætte det tilfældige tal 
            Console.WriteLine("Gæt et tilfældigt tal mellem 1-25. Du har 5 forsøg!");
            
            // kalder tilfældigt tal metoden 
            int tilfældigtTal = TilfældigtTal();
            
            int forsøg = 5; 
            bool harVundet = false;

            for (int i = 1; i <= forsøg; i++)
            {
                Console.Write($"Forsøg {i}: ");
                string brugerInput = Console.ReadLine();

                // tjek om inputet er et gyldigt tal 
                // out int brugerGæt: Hvis konverteringen lykkes, gemmes det konverterede heltal i variablen brugerGæt
                if (int.TryParse(brugerInput, out int brugerGæt))
                {
                    // tjek om brugeren har gættet korrekt 
                    if (TjekGæt(brugerGæt, tilfældigtTal))
                    {
                        harVundet = true;
                        Console.WriteLine("Tillykke! Du har gættet det rigtige tal og vundet spillet!");
                        break;
                    }
                    else 
                    {
                        // kald metoden til at informere brugeren om gættet er for højt eller lavt
                        InformerOmGæt(brugerGæt, tilfældigtTal);

                    }
                }
                else 
                {
                    Console.WriteLine("Ugyldigt input! indtast et tal mellem 1-25!");
                }
            }
                if (!harVundet)
            {
                Console.WriteLine($"Du løb tør for forsøg. Det rigtige tal var {tilfældigtTal}. Bedre held næste gang!");
            }

            Console.ReadKey();
            Console.Clear();
            AflsutEllerTilbage.Tilbage(GætEtTal);
            

        }

        // metode til at generer tilfædigt tak mellem 1 - 25
        private static int TilfældigtTal()
        {
           // opretter en ny instans af Random-klassen 
           Random tilfældigt = new Random();

           // genererer et tilfældigt tal mellem 1-25
           return tilfældigt.Next(1,26);
        }  

        // Metode til at tjekke, om brugerens gæt er korrekt
        private static bool TjekGæt(int gæt, int korrektTal)
        {
            return gæt == korrektTal;
        }

        // Metode til at informere brugeren, om gættet er for højt eller for lavt
        private static void InformerOmGæt(int gæt, int korrektTal)
        {
            if (gæt < korrektTal)
            {
                Console.WriteLine("Dit gæt er for lavt.");
            }
            else
            {
                Console.WriteLine("Dit gæt er for højt.");
            }
        }
    }

    internal class Opgave7 
    {
        public static void HovedMenu()
        {   
            
            Console.WriteLine("Jeg startede med at lave en menu så denne opgave er lavet");
            Console.WriteLine("Har implementeret at man kan gå tilbage til menuen eller aflutte programmet");
            
            Console.ReadKey();
            Console.Clear();
            AflsutEllerTilbage.Tilbage(HovedMenu);
        }
    }  

    internal class Opgave7a 
    {
        public static void Temp()
        {
            while (true)
            {

            Console.Clear();

            // bed brugeren om at indtaste temp i Celsius eller Fahrenheit
            Console.WriteLine("Indtast en temperatur: ");
            // læs brugerens input til temp 
            string tempInput = Console.ReadLine(); 

            // konverter til en decimaltal 
            if (double.TryParse(tempInput, System.Globalization.NumberStyles.Any, CultureInfo.InvariantCulture, out double temperatur))
            {
                Console.WriteLine("Angiv enheden for temperaturen (C for Celsius, F for Fahrenheit):");
                // læser input og konvertere til store bogstaver og fjerne eventuelle mellemrum 
                string enhedInput = Console.ReadLine()?.Trim().ToUpper();

                if (enhedInput == "C")
                {
                     // Udfør konverteringer
                    double fahrenheit = (temperatur * 9 / 5) + 32;
                    double kelvin = temperatur + 273.15;
                    double reaumur = temperatur * 4 / 5;

                    // Udskriv resultaterne
                    Console.WriteLine($"Du har indtastet {temperatur:F2} °C.");
                    Console.WriteLine($"Det er i Fahrenheit: {fahrenheit:F2} °F");
                    Console.WriteLine($"Det er i Kelvin: {kelvin:F2} K");
                    Console.WriteLine($"Det er i Réaumur: {reaumur:F2} °Re");
                }
                else if (enhedInput == "F")
                {
                    // Udfør konverteringer
                    double celsius = (temperatur - 32) * 5 / 9;
                    double kelvin = ((temperatur - 32) * 5 / 9) + 273.15;
                    double reaumur = (temperatur - 32) * 4 / 9;

                    // Udskriv resultaterne
                    Console.WriteLine($"Du har indtastet {temperatur:F2} °F.");
                    Console.WriteLine($"Det er i Celsius: {celsius:F2} °C");
                    Console.WriteLine($"Det er i Kelvin: {kelvin:F2} K");
                    Console.WriteLine($"Det er i Réaumur: {reaumur:F2} °Re");
                }
                else
                {
                    Console.WriteLine($"Ugyldig enhed. Brug venligst 'C' for Celsius eller 'F' for Fahrenheit.");
                }
            }
            else 
            {
                Console.WriteLine("Ugyldigt temperatur input. indtast venligst et gyldigt tal.");
            }

            Console.ReadKey();
            Console.Clear();
            AflsutEllerTilbage.Tilbage(Temp);

            }
        }
    }  

    internal class Opgave7b
    {
        public static void OmregnTal()
        {
            Console.Clear();

            // bed brugeren om at indtaste et tal 
            Console.WriteLine("Indtast et tal: ");
            string tal = Console.ReadLine();

            if (int.TryParse(tal, out int number))
            {
                // vis resultat af konvertering 
                Console.WriteLine($"Decimal:{DKonvertering(number)}");
                Console.WriteLine($"Hexadecimal:{HKonvertering(number)}");
                Console.WriteLine($"Binær:{BKonvertering(number)}");
            }
            else
            {
                Console.WriteLine("Ugyldigt input. Indtast venligst et heltal.");
            }

            Console.ReadKey();
            Console.Clear();
            AflsutEllerTilbage.Tilbage(OmregnTal);



        }

        public static string DKonvertering(int number)
        {
            return number.ToString();

        }

        public static string HKonvertering(int number)
        {
            return number.ToString("X");

        }

        public static string BKonvertering(int number)
        {
            return Convert.ToString(number, 2);

        }


    }  

    internal class Opgave7c
    {
        public static void HåndterInput()
        {
            while (true)
            {
                Console.Clear();

                // indtast et heltal 
                Console.WriteLine("Indtast et heltal: ");
                string inputHel = Console.ReadLine();
                if(!int.TryParse(inputHel, out int heltal))
                {
                    Console.WriteLine("Ugyldigt input. Prøv venligst igen.");
                    Console.ReadKey();
                    continue;
                } 

                // indtast decimaltal 
                Console.WriteLine("Indtast et decimaltal: ");
                string inputDecimal = Console.ReadLine();
                if (!double.TryParse(inputDecimal, out double decimaltal))
                {
                    Console.WriteLine("Ugyldigt input. Prøv venligst igen.");
                    Console.ReadKey();
                    continue;
                }

                // tjekker om tallene er positive eller negative 
                if (heltal > 0 && decimaltal > 0)
                {
                    Console.WriteLine("Begge tal er positive");
                }
                else if (heltal < 0 && decimaltal < 0)
                {
                    Console.WriteLine("Begge tal er negative");
                }
                else 
                {
                    Console.WriteLine("Et tal er positivt og det andet er negativt");
                }

                // udregner summen af de to tal 
                double sum = heltal + decimaltal;
                Console.WriteLine($"Summen af de to tal er: {sum:F2}");

                {
                break; // Afslut løkken og dermed programmet
                }

            }

            Console.ReadKey();
            Console.Clear();
            AflsutEllerTilbage.Tilbage(HåndterInput);
        }
    }
}


