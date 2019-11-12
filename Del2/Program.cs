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
                Console.WriteLine($"[1] Lägg till ett föremål {goods.Count}/6");
                Console.WriteLine("[2] Skriv ut innehållet");
                Console.WriteLine("[3] Ta bort det senaste objektet");
                Console.WriteLine("[4] Ränsa innehållet");
                Console.WriteLine("[5] Avsluta");
                return Console.ReadLine();
            }

            while(run)
            {
                switch(menu())
                {
                    case "1":
                    
                        Console.Clear();

                        if (goods.Count == 6)
                        {
                            Console.WriteLine("Ryggsäcken är full!");
                            Console.ReadKey();
                        }

                        else
                        {
                        Console.WriteLine($"Vad som ska läggas till? {goods.Count}/6");
                        goods.Add(Console.ReadLine());
                        }

                        
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

                        Console.ReadKey();
                        break;

                    case "3":

                        Console.Clear();
                        if (goods.Count == 0)
                        {
                            Console.WriteLine("Ryggsäcken är tom!");
                            Console.ReadKey();
                        }
                        else
                        {
                            goods.RemoveAt(goods.Count - 1);
                            Console.WriteLine("Det senaste objektet har blivit borttagen!");
                            Console.ReadKey();
                        }
                        
                        break;

                    case "4":

                        Console.Clear();
                        goods.Clear();
                        Console.WriteLine("Ryggsäcken har blivit ränsad!");
                        Console.ReadKey();
                        break;

                    case "5":

                        run = false;
                        Console.Clear();
                        Console.WriteLine("Tack för besöket!");
                        break;
                }
            }
        }
    }
}
