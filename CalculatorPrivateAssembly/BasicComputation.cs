using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPrivateAssembly
{
    public class BasicComputation
    {
        double num1;
        double num2;     

        public static double Addition(double num1, double num2)
        { 
            return  num1 + num2;
        }

        public static double Subtraction(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double Multiplication(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Division(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}
