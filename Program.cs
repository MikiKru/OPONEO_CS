using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParzenieKawy
{
    class Program
    {
        // metoda dostarczająca algorytm parzenia kawy
        public void coffeeGenerator(Boolean dodacMleko, Boolean dodacCukier, int ileCukru) {
            Console.WriteLine("START");
            Console.WriteLine("Przygotuj składniki");
            Console.WriteLine("Wsyp kawę do filiżanki");
            Console.WriteLine("Zagotuj wodę");
            Console.WriteLine("Zalej kawę gorącą wodą");
            // dodawanie mleka 
            if (dodacMleko == true)
            {
                Console.WriteLine("Dolewam 50ml mleka");
            }
            // dodawanie cukru
            if (dodacCukier)
            {
                // dodawaj sekwencyjnie cukier -> po jednej łyżeczce
                for (int i = 1; i <= ileCukru; i++)
                {
                    Console.WriteLine("Dodaję " + i + " łyżeczkę cukru");
                }
            }
            Console.WriteLine("Zamieszaj");
            Console.WriteLine("STOP");
        }
    
        static void Main(string[] args)     // od tej metody uruchamia się projekt
        {

        }
    }
}
