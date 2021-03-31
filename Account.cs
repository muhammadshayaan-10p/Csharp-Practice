using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Account
    {

        private string owner { 
            
            get {

                return this.owner;
            }

            set { 
            
            
            } }

        private int number { get; }

        private int balance { get; set; }

        private static int accountSeed = 123457542;

        private List<Transaction> transactions = new List<Transaction>();

        private DateTime openingDate;

        private string description;

        public Account(string owner)
        {

            this.owner = owner;
            this.number = accountSeed + 1;
            balance = 0;
            openingDate = DateTime.Now;

        }

        public void addBalance(int amount)
        {

            balance += amount;

        }

        public void withdrawBalance(int amount)
        {

            if((balance - amount) >= 0)
            {
                balance -= amount;
                Console.WriteLine("Withdraw Successful");

            }
            else
            {
                Console.WriteLine("Low balance");

            }

        }

        public void editAccount(string owner, string description) {

            this.owner = owner;
            this.description = description;
        }

        public void print()
        {

            Console.WriteLine($"Account {number} owned by {owner} has the balance {balance}");
            Console.Write($" opening date for the account was {openingDate.ToString("yyyy-MM-dd HH-MM")}");
            Console.WriteLine();
        }




    }
}
