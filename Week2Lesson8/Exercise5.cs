using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    internal class Exercise5
    {
        public static void Run()
        {
            //5. Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.

            Console.WriteLine("Exercise#5\n");
            Console.WriteLine("Trzecia potega dla liczb od 1 do 20:\n");

                for (double i = 1; i <= 20; i++)
                {
                Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)}\r");
                }

            Console.WriteLine("\n\nNacisnij dowolny klawisz aby zakonczyc biezace zadanie");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
