﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person person2 = new Person(1, "Kamil");
            Person person3 = new Person(2, "Kamil", "Marciniak");
            Person person4 = new Person(2, "Kamil", "Marciniak", "Katowice", 19, "mężczyzna");
                                          
        }
    }
}
