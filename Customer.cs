using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Customer
    {

        string name;
        int age;
        string password;
        Account account;

        public Customer(string name, int age, string password, Account account)
        {

            this.name = name;
            this.age = age;
            this.password = password;
            this.account = account;


        }

    }
}
