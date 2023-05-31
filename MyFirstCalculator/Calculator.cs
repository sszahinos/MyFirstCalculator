using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstCalculator
{
    public class Calculator
    {
        public int Sum(int num, int num2)
        {
            return num + num2;
        }

        public int Subtract(int num, int num2)
        {
            return num - num2;
        }

        public int Multiply(int num, int num2)
        {
            return num * num2;
        }

        public int Divide(int num, int num2)
        {
            return num / num2;
        }
    }
}
