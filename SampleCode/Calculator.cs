﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class Calculator
    {
        //instance variable
        public int a, b;
        
        //instance method
        public void AddTwoNumber()
        {
            int c = a + b;
            Console.WriteLine("Adition of Two Numbers is : "+c);
            Console.WriteLine("Conflict Created");
            Console.WriteLine("Conflict Created 2 time");
        }
        
        public void SupractTwoNumber()
        {
            int c = a - b;
            Console.WriteLine("Supraction of Two Numbers is : "+c);
        }
    }
}
