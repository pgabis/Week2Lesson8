using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    internal class Exercise8
    {
        public static void Run()
        {
            /*
             8. Napisz program, który odwróci wprowadzony przez uzytkownika ciag znaków. Np.
                Testowe dane:
                Abcdefg
                Rezultat
                Gfedcba
            */

            Console.WriteLine("Exercise#8\n");
            Console.WriteLine("\nPodaj ciag znakow ktore maja byc wypisane w odwrotnej kolejnosci\n");
            string text = Console.ReadLine();
            string reverse = String.Empty;
            if (!string.IsNullOrEmpty(text))
            {
                for (int i = text.Length; i > 0; i--)
                {
                    reverse += text[i-1];
                }
                Console.WriteLine(reverse);
            }
            else
                Console.WriteLine("\nNie podano zadnego znaku");

            Console.WriteLine("\n\nNacisnij dowolny klawisz aby zakonczyc biezace zadanie");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
