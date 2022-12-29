using System;
using System.Linq;

namespace ProjectEuler
{
    public class LargestPrimeFactor : IProblem
    {
        public int Id => 3;

        public string Title => "Largest prime factor";

        public string Description => "The prime factors of 13195 are 5, 7, 13 and 29." +
            "\n" +
            "What is the largest prime factor of the number 600851475143?";

        public string Solution => $"largest prime factor is {GetLargestPrimeFactor(600851475143L)}";

        private long GetLargestPrimeFactor(long number)
        {
            long largestPrimeFactor = 0;
            long[] factors = new long[2];

            for (long i = 2; i * i < number; i++)
            {
                if (number % i == 0)
                {
                    factors[0] = i;
                    factors[1] = number / i;

                    foreach (var factor in factors)
                    {
                        if (IsPrime(factor) && factor > largestPrimeFactor)
                        {
                            largestPrimeFactor = factor;
                        }
                    }
                }
            }

            return largestPrimeFactor;
        }

        private static bool IsPrime(long number)
        {
            bool isPrime = true;
            for (long i = 2; i * i < number; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            return isPrime;
        }
    }
}
