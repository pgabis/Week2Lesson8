using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    internal class Exercise9
    {
        public static void Run()
        {
            //9.Napisz program, który zamieni liczbę dziesiętną na liczbę binarną.

            Console.WriteLine("Exercise#9\n");
            Console.Write("Podaj liczbe dziesietna, ktora chcesz przeksztalcic w binarna:\n");
            bool check = Int32.TryParse(Console.ReadLine(), out int enteredValue);
            string convertResult = String.Empty;
            string binaryResult = String.Empty;
            if (check)
            {
                if (enteredValue != 0)
                {
                    for (int i = enteredValue; i > 0;)
                    {
                        if (i % 2 == 0)
                        {
                            convertResult += "0";
                            i = i / 2;
                        }
                        else
                        {
                            convertResult += "1";
                            i = (i - 1) / 2;
                        }
                    }
                    for (int j = convertResult.Length; j > 0; j--)
                    {
                        binaryResult += convertResult[j - 1];
                    }
                    Console.Write($"\nLiczba {enteredValue} w systemie binarnym to: {binaryResult}\n");
                }
                else
                    Console.WriteLine($"\nLiczba {enteredValue} w systemie binarnym jest \"0\"");
            }
            else
                Console.WriteLine("\nWprowadzona wartosc musi byc liczba. Sproboj jeszcze raz.");

            Console.WriteLine("\n\nNacisnij dowolny klawisz aby zakonczyc biezace zadanie");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
