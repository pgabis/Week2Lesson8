using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    internal class Exercise7
    {
        public static void Run()
        {
            /*
             7. Napisz program, który dla liczby zadanej przez użytkownika narysuje diament o krótszej
                przekątnej o długości wprowadzonej przez użytkownika i wg wzoru:
                       *
                      ***
                     *****
                    *******
                   *********
                    *******
                     *****
                      ***
                       *
            */


            Console.Write("Podaj przekatna diamenty ktory chcesz stworzyc: ");
            //int enteredValue = 0;
            bool check = Int32.TryParse(Console.ReadLine(), out int enteredValue);
            int diamond = enteredValue + 1;
            if (check)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                for (int i = 1; i <= diamond; i++)
                {
                    for (int j = 1; j <= diamond - i; j++)
                        Console.Write(" ");
                    for (int j = 1; j <= i - 1; j++)
                        Console.Write("* ");
                    Console.Write("\n");
                }

                for (int i = diamond - 1; i >= 1; i--)
                {
                    for (int j = 1; j <= diamond - i; j++)
                        Console.Write(" ");
                    for (int j = 1; j <= i - 1; j++)
                        Console.Write("* ");
                    Console.Write("\n");
                }
                Console.ResetColor();
            }
            else
                Console.WriteLine("\nPodana wartosc musi byc liczba. Sproboj ponownie.");


            Console.WriteLine("\n\nNacisnij dowolny klawisz aby zakonczyc biezace zadanie");
            Console.ReadKey();
            Console.Clear();
        }
    }
}

