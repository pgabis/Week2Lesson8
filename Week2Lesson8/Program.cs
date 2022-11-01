using System;
using System.Drawing;
using System.Globalization;
using Week2Lesson8;

namespace Week2Lesson8
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Week2 Lesson8");
                Console.WriteLine("-------------");
                Console.Write("\nPodaj numer zadania ktore chcesz uruchomic lub '0' zeby przerwac\n\n" +
                    "1. Ilosc liczb pierwszych\n" +
                    "2. Liczby parzyste z zakresu 0 – 1000(do…while)\n" +
                    "3. Ciąg Fibonacciego\n" +
                    "4. Piramida liczb\n" +
                    "5. 3 potega dla liczb od 1 do 20\n" +
                    "6. Suma wedlug wzoru\n" +
                    "7. Diament\n" +
                    "8. Odwrocony ciag zankow\n" +
                    "9. Zamiana liczby dzisietnej na liczbe binarna\n" +
                    "10. Najmniejszą wspólną wielokrotność dla zadanych 2 liczb\n" +
                    "\n\n");

                int operation = 0;
                Int32.TryParse(Console.ReadLine(), out operation);
                Console.Clear();

                switch (operation)
                {
                    case 0:
                        Console.Clear();
                        return;
                    case 1:
                        Exercise1.Run();
                        break;
                    case 2:
                        Exercise2.Run();
                        break;
                    case 3:
                        Exercise3.Run();
                        break;
                    case 4:
                        Exercise4.Run();
                        break;
                    case 5:
                        Exercise5.Run();
                        break;
                    case 6:
                        Exercise6.Run();
                        break;
                    case 7:
                        Exercise7.Run();
                        break;
                    case 8:
                        Exercise8.Run();
                        break;
                    case 9:
                        Exercise9.Run();
                        break;
                    case 10:
                        Exercise10.Run();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"\n\nPodales numer zadania {operation}");
                        Console.ResetColor();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Jest to niepoprawny numer zadania. Sproboj ponownie.\n");
                        Console.ResetColor();
                        break;
                }

            }
        }
    }
}