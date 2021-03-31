using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{


    class Menu
    {

        private object user;
        private int userType;

        public Menu(int i)
        {
            userType = i;
            show();
        }

        private void authenticate()
        {


        }

        private void show()
        {



            if (userType == 1)
            {
                Console.WriteLine("Select an operation from below");
                Console.WriteLine("1. View Balance ");
                Console.WriteLine("2. Add balance ");
                Console.WriteLine("3. Withdraw Balance ");
                Console.WriteLine("0. Quit ");

                


            }
            else
            {
                Console.WriteLine("Select an operation from below");
                Console.WriteLine("1. Add Account ");
                Console.WriteLine("2. Add Customer ");
                Console.WriteLine("3. Update Account Details ");
                Console.WriteLine("4. Print all acoounts ");
                Console.WriteLine("0. Quit ");



            }

        }


    }
}
