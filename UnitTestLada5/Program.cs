using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestLada5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            Calculator calculator = new Calculator();
            calculator.addition(a, b);
            calculator.subtraction(a, b);
            calculator.division(a, b);
            calculator.multiplication(a, b);
            calculator.squaring(a);
        }
    }
}
