using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulačka
{
    class Program
    {
        static void Main(string[] args)
        {


            int cislo1 = int.Parse(Console.ReadLine());
            int cislo = int.Parse(Console.ReadLine());
            string operace = Console.ReadLine();
            double vysledek = 0;

            if (operace == "+")

                vysledek = cislo1 + cislo;

            else if (operace == "-")

                vysledek = cislo1 - cislo;

            else if (operace == "/")

                vysledek = cislo1 / cislo;

            else if (operace == "*")

                vysledek = cislo1 * cislo;

            else if (operace == "%")
                vysledek = cislo1 % cislo;

            else

                Console.WriteLine("Chyba, špatný znak");






        
        



            Console.WriteLine("Výsledek: " + vysledek);
            Console.ReadKey();
        }
    }
}






