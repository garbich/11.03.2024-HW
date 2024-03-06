using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class CalculatorModel
    {

        public static double CalculateSum(double num1, double num2)
        {
            return num1 + num2;
        }
        public static double CalculateSubtraction(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double CalculateMultiplication(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double CalculateDivision(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
