﻿using System;
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

            Bank b = new Bank("HBL", "Parsa Tower");

            b.addAccount("Shayaan");
        }
    }
}
