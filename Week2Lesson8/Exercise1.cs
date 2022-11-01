using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    internal class Exercise1
    {
        public static void Run()
        {
            //1.Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100.

            Console.WriteLine("Exercise#1\n");

            int counter = 0;
            for (int i = 0; i <= 100; i++)
            {
                int subCounter = 0;
                for (int n = 1; n <= 100; n++)
                {
                    if ((i % n) == 0)
                    {
                        subCounter++;
                    }
                }
                if (subCounter == 2)
                {
                    counter++;
                }
            }
            Console.WriteLine($"\nW zakresie od 0 do 100 jest {counter} liczb pierwszych");

            Console.WriteLine("\n\nNacisnij dowolny klawisz aby zakonczyc biezace zadanie");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
