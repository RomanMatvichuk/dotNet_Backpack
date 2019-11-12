using System;
using System.Collections.Generic;

namespace dotNet_Backpack
{
    class Program
    {
        static void Main(string[] args)
        {
            bool run = true;
            List<string> goods= new List<string>();

            string menu()
            {
                Console.Clear();
                Console.WriteLine("Välkommen till ryggsäcken!");
                Console.WriteLine("[1] Lägg till ett föremål");
                Console.WriteLine("[2] Skriv ut innehållet");
                Console.WriteLine("[3] Ränsa innehållet");
                Console.WriteLine("[4] Avsluta");
                return Console.ReadLine();
            }

            while(run)
            {
                switch(menu())
                {
                    case "1":

                        Console.Clear();
                        Console.WriteLine("Vad som ska läggas till?");

                        goods.Add(Console.ReadLine());
                        break;

                    case "2":

                        Console.Clear();

                        if (goods.Count == 0)
                        {
                            Console.WriteLine("Ryggsäcken är tom!");
                        }

                        else
                        {
                            Console.WriteLine("Ryggsäcken innehåller:");
                            foreach(string thing in goods)
                            {
                                Console.WriteLine(thing);
                            }
                        }

                        Console.ReadLine();
                        break;

                    case "3":

                        Console.Clear();
                        goods.Clear();
                        Console.WriteLine("Ryggsäcken har blivit ränsad!");
                        Console.ReadLine();
                        break;

                    case "4":

                        run = false;
                        Console.Clear();
                        Console.WriteLine("Tack för besöket!");
                        break;
                }
            }
        }
    }
}
