using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    public class Exercise2
    {
        public static void Run()
        {
             //2. Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z zakresu 0 – 1000.

            Console.WriteLine("Exercise#2\n");
            int i = 1;
            string result = "";
            do
            {
                if (i % 2 == 0)
                {
                    result += " " + i;
                }
                i++;
            }
            while (i <= 1000);
            Console.WriteLine(result);

            Console.WriteLine("\n\nNacisnij dowolny klawisz aby zakonczyc biezace zadanie");
            Console.ReadKey();
            Console.Clear();
        }
    }
}