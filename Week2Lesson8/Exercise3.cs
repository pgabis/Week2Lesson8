using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    internal class Exercise3
    {
        public static void Run()
        {
            //3. Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.

            Console.WriteLine("Exercise#3\n");
            Console.WriteLine("\nPodaj liczbe na ktorej ma sie zatrzymac budowanie ciagu Gibonacciego");
            bool ifInt = Int32.TryParse(Console.ReadLine(), out int fib);
            Console.WriteLine("\n");
            if (ifInt)
            {
                int a = 0;
                int b = 1;
                int c = 1;
                string result = "";
                do
                {
                    if (a == c + b)
                    {
                        result += a + " ";
                    }
                    b = c;
                    c = a;
                    a = c + b;
                }
                while (a <= fib);
                Console.WriteLine(result);
            }
            else
                Console.WriteLine("\nPodana wartosci musi byc liczba");

            Console.WriteLine("\n\nNacisnij dowolny klawisz aby zakonczyc biezace zadanie");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
