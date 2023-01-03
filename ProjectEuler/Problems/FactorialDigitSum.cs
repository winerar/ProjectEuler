using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    public class FactorialDigitSum : IProblem
    {
        public int Id => 20;

        public string Title => "Factorial digit sum";

        public string Description => "n! means n × (n − 1) × ... × 3 × 2 × 1" +
            "\n" +
            "For example, 10! = 10 × 9 × ... × 3 × 2 × 1 = 3628800," +
            "\n" +
            "and the sum of the digits in the number 10! is 3 + 6 + 2 + 8 + 8 + 0 + 0 = 27." +
            "\n" +
            "Find the sum of the digits in the number 100!";

        public string Solution => $"sum equals {FindSum(100)}";

        private int FindSum(int number)
        {
            string factorialString = Factorial(number).ToString();
            int sum = 0;

            foreach (var ch in factorialString)
            {
                sum += int.Parse(ch.ToString());
            }

            return sum;
        }

        private BigInteger Factorial(int number)
        {
            if (number == 0 || number == 1)
            {
                return 1;
            }

            BigInteger result = 2;

            for (int i = 3; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }
    }
}
