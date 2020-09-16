/*
 Datum: 17-Sep-2020
 Skriv en enklare miniräknare som en konsolapplikation. Användaren ska kunna skriva in två tal 
 som sedan adderas, subtraheras, multipliceras eller divideras med varandra.
 Resultatet av uträkningen och formeln presenteras för användaren. 
    
 */


using System;
using System.Globalization;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double tal1, tal2;
            string operation;
            double resultat;
            
            // asking for operators
            Console.Write("skriv första tal: ");
            tal1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("skriv andra tal: ");
            tal2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            // ask for operation & perform calculation. :)
            while (true)
            {
                ArithmeticMenuDisplay();
                Console.Write("Välj en av räknesätt från meny: ");
                operation = Console.ReadLine();

                if (operation == "+")
                    resultat = tal1 + tal2;
                else if (operation == "-")
                    resultat = tal1 - tal2;
                else if (operation == "*")
                    resultat = tal1 * tal2;
                else if (operation == "/")
                    resultat = tal1 / tal2;
                else
                {
                    Console.WriteLine("Du får bara välja en av (+, -, *, /) tecken!!");
                    Console.WriteLine("   Förstått??\n(Press any key)");
                    Console.ReadKey();
                    continue;
                }
                break;
            }


            // output result
            Console.WriteLine("\n*** Beräkning... ***");
            Console.WriteLine($"Formeln-> {tal1}{operation}{tal2} \n" +
                              "Resultat-> {0,3:#,##0.0}", resultat);
        }

        static void ArithmeticMenuDisplay()
        {
            Console.WriteLine("\n*** Räknesätt Meny ***");
            Console.WriteLine(
                "(+) - Addition\n" +
                "(-) - Subtraktion\n" +
                "(/) - Multiplikation\n"+
                "(*) - Division\n"); 
        }
    }
}
