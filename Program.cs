using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to 10p Banking System");
            bool choice = true;
            Menu m;


            while (choice)
            {

                Console.WriteLine("Select an option from below: ");
                Console.WriteLine("1. Login as Customer ");
                Console.WriteLine("2. Login as Employee ");
                Console.WriteLine("0. Quit");


                int option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Logged in as Customer");
                    m = new Menu(1);

                }
                else if (option == 2)
                {
                    Console.Clear();

                    Console.WriteLine("Logged in as Employee");
                    m = new Menu(2);



                }
                else if (option == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Quitting.....");
                    choice = false;

                }
            }
        }
    }
}

