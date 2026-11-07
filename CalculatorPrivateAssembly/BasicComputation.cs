using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPrivateAssembly
{
    public class BasicComputation
    {
        public static double getSum(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double getDifference(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double getProduct(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double getQuotient(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
