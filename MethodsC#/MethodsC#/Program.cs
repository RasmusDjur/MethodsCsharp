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


        }

        // metode der splitter string og returnere array 
        private static string[] SplitString(string input)
        {
            // splitter string ved komma og returnerer et array 
            return input.Split(',');
        }
    }
}


