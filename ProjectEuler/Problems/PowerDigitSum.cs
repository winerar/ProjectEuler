using System.Numerics;

namespace ProjectEuler
{
    public class PowerDigitSum : IProblem
    {
        public int Id => 16;

        public string Title => "Power digit sum";

        public string Description => "2^15 = 32768 and the sum of its digits is 3 + 2 + 7 + 6 + 8 = 26." +
            "\n" +
            "What is the sum of the digits of the number 2^1000?";

        public string Solution => $"sum equals {FindSum()}";

        private int FindSum()
        {
            int sum = 0;
            string number = BigInteger.Pow(2, 1000).ToString();
            foreach (var ch in number)
            {
                sum += int.Parse(ch.ToString());
            }
            return sum;
        }
    }
}
