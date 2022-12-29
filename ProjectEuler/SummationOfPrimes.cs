using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public class SummationOfPrimes : IProblem
    {
        public int Id => 10;

        public string Title => "Summation of primes";

        public string Description => "The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17." +
            "\n" +
            "Find the sum of all the primes below two million.";

        public string Solution => $"sum equals {FindSum(2000000)}";

        private long FindSum(long limit)
        {
            long sum = 0;

            for (int i = 2; i < 2000000; i++)
            {
                if (isPrime(i))
                {
                    sum += i;
                }
            }

            return sum;
        }

        private bool isPrime(int number)
        {
            if (number < 2) return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
