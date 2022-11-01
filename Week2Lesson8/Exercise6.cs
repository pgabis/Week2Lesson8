using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    internal class Exercise6
    {
        public static void Run()
        {
            /*
            6.Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru:
            1 + ½ +1 / 3 + ¼ itd.
            */

            Console.WriteLine("Exercise#6\n");
            float summ = 0;
            for (float i = 1; i <= 20; i++)
            {
                summ += (1 / i);
                //summ = summ + (1 / i); - to samo co linijka przed
            }
            Console.WriteLine($"\nSuma dla liczb od 0 do 20 wedlug wzoru '1 + 1/2 +1/3 + 1/4 itd' wynosi: {summ}");

            Console.WriteLine("\n\nNacisnij dowolny klawisz aby zakonczyc biezace zadanie");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
