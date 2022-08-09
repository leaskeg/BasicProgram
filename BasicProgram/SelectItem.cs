using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgram
{
    public class SelectItem
    {
        public static int amount { get; set; }

        public static void Select()
        {
            
            bool repeat = true;
            //Make basic program e.g. Make a menu, where you can add stuff to a basket.
            do
            {
                Menu.MenuList();
                try
                {
                    int userInput = Convert.ToInt32(Console.ReadLine());
                    int capacity = 1000;

                    switch (userInput)
                    {
                        case 1: // Apple
                            if (amount < capacity)
                            {
                                Console.Clear();
                                Console.WriteLine("An apple was added to your basket");
                                amount++;
                                Clear.Clean();
                            }
                            else
                                Console.WriteLine("Database is full");
                            break;
                        case 2:
                            if (amount < capacity)
                            {
                                Console.Clear();
                                Console.WriteLine("A banana was added to your basket");
                                amount++;
                                Clear.Clean();

                            }
                            else
                            {
                                Console.WriteLine("Database is full");
                            }
                            break;
                        case 3:
                            if (amount < capacity)
                            {
                                Console.Clear();
                                Console.WriteLine("A Kiwi was added to your basket");
                                amount++;
                                Clear.Clean();
                            }
                            else
                            {
                                Console.WriteLine("Database is full");
                            }
                            break;
                        case 4:
                            if (amount < capacity)
                            {
                                Console.Clear();
                                Console.WriteLine("A Carrot was added to your basket");
                                amount++;
                                Clear.Clean();
                            }
                            else
                            {
                                Console.WriteLine("Database is full");
                            }
                            break;
                        case 5:
                            if (amount < capacity)
                            {
                                Console.Clear();
                                Console.WriteLine("A Blueberry was added to your basket");
                                amount++;
                                Clear.Clean();
                            }
                            else
                            {
                                Console.WriteLine("Database is full");
                            }
                            break;
                        case 6:
                            {
                                Console.WriteLine($"Your basket contains {amount} items ");
                                Clear.Clean();
                            }
                            break;
                        default:
                            Console.WriteLine("Try again\n");
                            break;
                        case 7:
                            {
                                Environment.Exit(0);
                            }
                            break;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("Wrong Input - Try again");
                    Clear.Clean();
                }

            } while (repeat);
        }
    }
}
