using System.Numerics;

namespace ProjectEuler.Problems
{
    public class SelfPowers : IProblem
    {
        public int Id => 48;

        public string Title => "Self powers";

        public string Description => "The series, 1^1 + 2^2 + 3^3 + ... + 10^10 = 10405071317." +
            "\n" +
            "Find the last ten digits of the series, 1^1 + 2^2 + 3^3 + ... + 1000^1000.";

        public string Solution => $"last ten digits are {FindLastTenDigits()}";

        private string FindLastTenDigits()
        {
            BigInteger sum = 0;
            for (int i = 1; i <= 1000; i++)
            {
                sum += BigInteger.Pow(i, i);
            }

            var stringSum = sum.ToString();
            return stringSum.Substring(stringSum.Length - 10);
        }
    }
}
