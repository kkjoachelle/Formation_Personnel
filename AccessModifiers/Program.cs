﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Personn();
            person.SetbirthDate(new DateTime(2019, 1, 1));
            Console.WriteLine("''''''''''''''''''"+ person.GetbirthDate());
            
            Console.ReadKey();
        }
    }

}
