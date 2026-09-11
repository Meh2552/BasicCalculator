using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorApplication
{
    public delegate T Information<T>(T arg1, T arg2);
    internal class CalculatorClass
    {
        public Information<double> info;

        public event Information<double> CalculateEvent
        {
            add
            {
                info += value;
                Console.WriteLine("Added the Delegate");
            }
            remove
            {
                info -= value;
                Console.WriteLine("Removed the Delegate");
            }
        }

        public double getSum(double num1, double num2)
        {
            return num1 + num2;
        }

        public double getDifference(double num1, double num2)
        {
            return num1 - num2;
        }

        public double getProduct(double num1, double num2)
        {
            return num1 * num2;
        }

        public double getQuotient(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
