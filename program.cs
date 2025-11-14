using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace End_of_Term_Assesment___Jack_Marcus_Hawes
{
    class Program
    {
        static void Main(string[] args)
        {

            string Model;
            int Quantity=0;
            string deluxe;
            int laptopPrice = 0;
            int totalPrice = 0;





            Console.WriteLine("Please select your desired laptop model: ‘d’ for Dell Precision Workstation, ’l’ for Lenovo Thinkpad or ‘a’ for Apple MacBook Pro");
            Model = (Console.ReadLine());

            Console.WriteLine("Please enter required ammount");
            Quantity = int.Parse(Console.ReadLine());

            if (Model == "d")
            {

                Console.WriteLine("would you like to upgrade to the deluxe package? y for yes or n for no");
                deluxe = (Console.ReadLine());

                if (deluxe == "y")
                {
                    laptopPrice = 3000;

                    if (Quantity >= 3 && Quantity <= 10)
                    {
                        totalPrice = (laptopPrice * Quantity) * 9 / 10;
                        Console.WriteLine("Your quote will be {0:C2}", totalPrice);
                        Console.WriteLine("press any key to exit");

                    }
                    else if (Quantity > 10)
                    {

                        totalPrice = (laptopPrice * Quantity) * 85 / 100;
                        Console.WriteLine("Your quote will be {0:C2}", totalPrice);
                        Console.WriteLine("press any key to exit");

                    }

                    else
                    {

                        totalPrice = laptopPrice * Quantity;
                        Console.WriteLine("Your quote will be {0:C2}", totalPrice);
                        Console.WriteLine("press any key to exit");

                    }

                }

                else if (deluxe == "n")
                {
                    laptopPrice = 2800;

                    if (Quantity >= 3 && Quantity <= 10)
                    {
                        totalPrice = (laptopPrice * Quantity) * 9 / 10;
                        Console.WriteLine("Your quote will be {0:C2}", totalPrice);
                        Console.WriteLine("press any key to exit");

                    }
                    else if (Quantity > 10)
                    {

                        totalPrice = (laptopPrice * Quantity) * 85 / 100;
                        Console.WriteLine("Your quote will be {0:C2}", totalPrice);
                        Console.WriteLine("press any key to exit");

                    }

                    else
                    {

                        totalPrice = laptopPrice * Quantity;
                        Console.WriteLine("Your quote will be {0:C2}", totalPrice);
                        Console.WriteLine("press any key to exit");

                    }

                }


            }









            if (Model == "l")
            {

                Console.WriteLine("would you like to upgrade to the deluxe package? y for yes or n for no");
                deluxe = (Console.ReadLine());

                if (deluxe == "y")
                {
                    laptopPrice = 2000;

                    if (Quantity >= 3 && Quantity <= 10)
                    {
                        totalPrice = (laptopPrice * Quantity) * 9 / 10;
                        Console.WriteLine("Your quote will be {0:C2}", totalPrice);
                        Console.WriteLine("press any key to exit");

                    }
                    else if (Quantity > 10)
                    {

                        totalPrice = (laptopPrice * Quantity) * 85 / 100;
                        Console.WriteLine("Your quote will be {0:C2}", totalPrice);
                        Console.WriteLine("press any key to exit");

                    }

                    else
                    {

                        totalPrice = laptopPrice * Quantity;
                        Console.WriteLine("Your quote will be {0:C2}", totalPrice);
                        Console.WriteLine("press any key to exit");

                    }

                }

                else if (deluxe == "n")
                {
                    laptopPrice = 1700;

                    if (Quantity >= 3 && Quantity <= 10)
                    {
                        totalPrice = (laptopPrice * Quantity) * 9 / 10;
                        Console.WriteLine("Your quote will be {0:C2}", totalPrice);
                        Console.WriteLine("press any key to exit");

                    }
                    else if (Quantity > 10)
                    {

                        totalPrice = (laptopPrice * Quantity) * 85 / 100;
                        Console.WriteLine("Your quote will be {0:C2}", totalPrice);
                        Console.WriteLine("press any key to exit");

                    }

                    else
                    {

                        totalPrice = laptopPrice * Quantity;
                        Console.WriteLine("Your quote will be {0:C2}", totalPrice);
                        Console.WriteLine("press any key to exit");

                    }

                }


            }



            if (Model == "a")
            {

                Console.WriteLine("would you like to upgrade to the deluxe package? y for yes or n for no");
                deluxe = (Console.ReadLine());

                if (deluxe == "y")
                {
                    laptopPrice = 2500;

                    if (Quantity >= 3 && Quantity <= 10)
                    {
                        totalPrice = (laptopPrice * Quantity) * 9 / 10;
                        Console.WriteLine("Your quote will be {0:C2}", totalPrice);
                        Console.WriteLine("press any key to exit");

                    }
                    else if (Quantity > 10)
                    {

                        totalPrice = (laptopPrice * Quantity) * 85 / 100;
                        Console.WriteLine("Your quote will be {0:C2}", totalPrice);
                        Console.WriteLine("press any key to exit");

                    }

                    else
                    {

                        totalPrice = laptopPrice * Quantity;
                        Console.WriteLine("Your quote will be {0:C2}", totalPrice);
                        Console.WriteLine("press any key to exit");

                    }

                }

                else if (deluxe == "n")
                {
                    laptopPrice = 2200;

                    if (Quantity >= 3 && Quantity <= 10)
                    {
                        totalPrice = (laptopPrice * Quantity) * 9 / 10;
                        Console.WriteLine("Your quote will be {0:C2}", totalPrice);
                        Console.WriteLine("press any key to exit");

                    }
                    else if (Quantity > 10)
                    {

                        totalPrice = (laptopPrice * Quantity) * 85 / 100;
                        Console.WriteLine("Your quote will be {0:C2}", totalPrice);
                        Console.WriteLine("press any key to exit");

                    }

                    else
                    {

                        totalPrice = laptopPrice * Quantity;
                        Console.WriteLine("Your quote will be {0:C2}", totalPrice);
                        Console.WriteLine("press any key to exit");

                    }

                }


            }



            Console.ReadKey();


        }
    }
}
