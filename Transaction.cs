using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Transaction
    {

        private int amount { get; set; }
        private string Note;

        public Transaction(int amount, string Note)
        {

            this.amount = amount;
            this.Note = Note;

        }
    }
}
