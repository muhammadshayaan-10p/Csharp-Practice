using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{


    class Bank
    {
        private string name;
        private string address;
        private List<Account> accounts = new List<Account>();
        private List<Customer> customers = new List<Customer>();
        private List<Employee> employees = new List<Employee>();

        public Bank(string name, string address)
        {

            this.name = name;
            this.address = address;

        }


        private void addAccount(string owner)
        {

            Account a = new Account(owner);
            accounts.Add(a);

        }

        public void printAccounts()
        {
            for (int i = 0; i < accounts.Count; i++)
            {
                accounts[i].print();
            }
        }


        public void addCustomer(string name, int age)
        {

            Console.WriteLine("Enter your password: ");
            string password = Console.ReadLine();

            Account a = new Account(name);
            accounts.Add(a);

           // customers.Add(new Customer(name, age, password, a.get));

        }

    }
}
