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

        public Bank(string name, string address)
        {

            this.name = name;
            this.address = address;

        }


        public void addAccount(string owner)
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


    }
}
