using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestLada5
{
    public class Calculator
    {
        public int addition(int number_one, int number_two)
        {
            return number_one + number_two;
        }

        public int subtraction(int number_one, int number_two)
        {
            return number_one - number_two;
        }

        public int division(int number_one, int number_two)
        {
            if (number_two == 0)
            {
                throw new ArgumentException("Делитель не может быть равен нулю.", nameof(number_two));
            }

            if (number_two != 0)
                return number_one / number_two;
            else
                return 0;
        }

        public int multiplication(int number_one, int number_two)
        {
            return number_one * number_two;
        }

        public int squaring(int number_one)
        {
            if (number_one == 0)
            {
                throw new ArgumentException("Делитель не может быть равен нулю.", nameof(number_one));
            }

            return number_one * number_one;
        }
    }
}
