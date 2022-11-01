using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    internal class Exercise4
    {
        public static void Run()
        {
            /*
            4.Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej
            liczby w formie jak poniżej:
            1
            2 3
            4 5 6
            7 8 9 10
            */

            //PROSZE O RADE!!!
            //na koncu dodaje mi sporo pustych linijek, nie wiem jak temu zapobiec prosze o rade

            Console.WriteLine("Exercise#4\n");
            Console.WriteLine("\nPodaj liczbe na ktorej ma sie zatrzymac budowanie piramidy");
            bool check = Int32.TryParse(Console.ReadLine(), out int triangle);
            int count = 1;
            if (check)
            {
                for (int i = 1; i <= triangle; i++)
                {
                    for (int j = 1; j <= i; j++)
                        if (count <= triangle)
                        {
                            Console.Write($"{count}" + " ", count++);
                        }
                    Console.WriteLine("\r");
                }
            }
            else
                Console.WriteLine("\nPodana wartosc musi byc liczba");

            Console.WriteLine("\n\nNacisnij dowolny klawisz aby zakonczyc biezace zadanie");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
