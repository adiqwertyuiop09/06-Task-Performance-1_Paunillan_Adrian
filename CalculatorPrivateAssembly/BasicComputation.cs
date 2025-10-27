using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPrivateAssembly
{
    public class BasicComputation
    {
        float num1;
        float num2;
        float ans;

        public float Addition(float num1, float num2, float ans)
        { 
            ans = ans + num1;
            return ans;
        }

        public float Subtraction(float num1, float num2, float ans)
        {
            ans = ans - num1;
            return ans;
        }

        public float Multiplication(float num1, float num2, float ans)
        {
            ans = ans * num1;
            return ans;
        }

        public float Division(float num1, float num2, float ans)
        {
            ans = ans / num1;
            return ans;
        }
    }
}
