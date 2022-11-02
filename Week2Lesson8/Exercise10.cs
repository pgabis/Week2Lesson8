using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    internal class Exercise10
    {
        public static void Run()
        {
            /*
            10. Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb.
            */
            Console.WriteLine("Exercise#10\n");
            Console.Write("Podaj pierwsza liczbe:\n");
            bool check1 = Int32.TryParse(Console.ReadLine(), out int val1);
            Console.Write("Podaj druga liczbe:\n");
            bool check2 = Int32.TryParse(Console.ReadLine(), out int val2);
            {
                if (check1 && check2)
                {
                    if (val1 > 0 && val2 > 0)
                    {
                        for (int i = 1; i <= int.MaxValue; i++)
                        {
                            if (i % val1 == 0 && i % val2 == 0)
                            {
                                Console.WriteLine($"\nNajmniejsza wspolna wielokrotnosc dla liczb {val1} and {val2} jest: {i}");
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nPodana wartosc nie moze byc mniejsza lub rowna \"0\"");
                    }
                }
                else
                    Console.WriteLine("\nWprowadzona wartosc musi byc liczba. Sproboj jeszcze raz.");
            }
            Console.WriteLine("\n\nNacisnij dowolny klawisz aby zakonczyc biezace zadanie");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
