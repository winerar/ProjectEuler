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

            for (int i = 2; i < limit; i++)
            {
                if (IsPrime(i))
                {
                    sum += i;
                }
            }

            return sum;
        }

        private static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }
            if (number == 2 || number == 3)
            {
                return true;
            }
            if ((number & 1) == 0 || number % 3 == 0)
            {
                return false;
            }

            int sqrtN = (int)Math.Sqrt(number) + 1;
            for (int i = 6; i <= sqrtN; i += 6)
            {
                if (number % (i - 1) == 0 || number % (i + 1) == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
