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
        public void coffeeGenerator(Boolean dodacMleko, Boolean dodacCukier) {
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
                Console.WriteLine("Ile chcesz cukru: ");
                int ileCukru = int.Parse(Console.ReadLine());

                // dodawaj sekwencyjnie cukier -> po jednej łyżeczce
                for (int i = 1; i <= ileCukru; i++)
                {
                    Console.WriteLine("Dodaję " + i + " łyżeczkę cukru");
                }
            }
            Console.WriteLine("Zamieszaj");
            Console.WriteLine("STOP");
        }

        // obliczenie n! -> 5 = 5*4*3*2
        // metoda zwracająca wartość 
        public int factorial(int n) {
            if (n == 0) {
                return 1;
            }
            int result = 1;
            for (int i = n; i > 1; i--) {       // i-- -> i = i - 1
                //result = result * i;
                result *= i;
            }
            return result;
        }
        // rekurencyjna matoda obliczająca silnie
        public int factorialRecurence(int n) {
            if (n == 1) {
                return 1;
            }
            return n * factorialRecurence(n - 1);
        }
        public void isEvenNumber(int n) {
            if (n == 0){
                Console.WriteLine("Podana liczba to zero");
            }
            else if (n % 2 == 0){
                Console.WriteLine("Liczba " + n + " jest parzysta");
            }
            else {
                Console.WriteLine("Liczba " + n + " jest nieparzysta");
            }
        }
        public Boolean isNegativeAndOddNumber(int n) {
            Boolean result = false;
            if ((n % 2 != 0) && (n < 0)) {        // == spr równości a != spr nierównosci
                                                  // && - AND || - OR ! - NOT
                result = !result;       // przypisanie do result wartośc przeciwną
            }
            return result;
        }
        static void Main(string[] args)     // od tej metody uruchamia się projekt
        {
            Program p = new Program();
            Console.WriteLine("Podaj liczbę naturalną");
            int value = int.Parse(Console.ReadLine());
            p.isEvenNumber(value);
            Console.WriteLine(p.isNegativeAndOddNumber(-5));
            //Console.WriteLine(value + "! = " +p.factorialRecurence(value));
           
        }
    }
}
