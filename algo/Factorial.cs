using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algo
{
    class Factorial
    {
        public int interativeFactorial(int n)
        {
            int result = 1;
            for (int i = n; i >= 1; i--)
            {
                result = result * i;
            }

            return result;
        }

        public int recursiveFactorial(int n)
        {
     
            if (n == 0)
            {
                return 1;
            }

            int smallerResult = recursiveFactorial(n - 1);

            return n * smallerResult;

        }
    }


   
}
