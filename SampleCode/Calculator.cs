using System;
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
        }

        public void MultiplyTwoNumber()
        {
            int c = a * b;
            Console.WriteLine("Multiplication of Two Numbers is : " + c);
        }
        
        public void SupractTwoNumber()
        {
            int c = a - b;
            Console.WriteLine("Supraction of Two Numbers is : "+c);
        }
    }
}
