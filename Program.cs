using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int read;
                read = ReadInt("Skriv in antalet löner:");
                if (read < 2) //Om det är mindre än två stycken löner så skrivs det ut ett felmeddelande.
                {
                    Console.WriteLine("Det måste vara minst två stycken löner för att programmet ska köras.");
                }
                else
                {
                    ProcessSalaries(read); // Värdet read skickas ner i metoden ProcessSalaries.
                }
                if (Console.ReadKey(true).Key != ConsoleKey.Escape) // När man inte trycker escape så 
                {
                    continue;


                }
                else
                {
                    return;
                }
            }
        }

        static void ProcessSalaries(int count) // Count får värdet som Read har.
        {
            int[] salaries = new int[count]; // Här görs en array med antalet löner som vi skrivit in.

            for (int i = 0; i < count; i++) // for loopen räknar upp antalet löner.
            {
                // varje lön ska skrivas ut i värde.
                salaries[i] = ReadInt("Skriv in lön numer " + (i + 1) + ": ");

            }
            int[] unsortSalaries = (int[])salaries.Clone();


            int averageSalary = (int)salaries.Average();
            int salareySpread = (int)salaries.Max() - salaries.Min();

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Medellönen: {0, 10:c0}", averageSalary);
            Console.WriteLine("Lönespridning: {0, 10:c0}", salareySpread);
            Console.WriteLine("-----------------------------------");

            







        }



            static int ReadInt(string prompt)
            {
                while (true)
                {
                    Console.Write(prompt);
                    string input;
                    input = Console.ReadLine();
                    try
                    {
                        int number = int.Parse(input);
                        return number;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Fel! Kan inte tolka {0} som ett heltal.", input);
                    }

                }
                


        }
    }
}
