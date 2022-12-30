using System;
using System.Linq;

namespace ProjectEuler
{
    public class TenThousandFirstPrime : IProblem
    {
        public int Id => 7;

        public string Title => "10001st prime";

        public string Description => "By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13," +
            " we can see that the 6th prime is 13." +
            "\n" +
            "What is the 10 001st prime number?";

        public string Solution => $"10 001st prime number is {GetPrimeNumberByIndex(10001)}";

        private int GetPrimeNumberByIndex(int index)
        {
            int counter = 1;
            List<int> primes = new List<int> { 2 };

            while (primes.Count < index)
            {
                counter += 2;
                bool isPrime = true;
                int i = 0;
                while (primes[i] * primes[i] <= counter)
                {
                    if (counter % primes[i] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    i++;
                }
                if (isPrime)
                {
                    primes.Add(counter);
                }
            }

            return primes.Last();
        }
    }
}
