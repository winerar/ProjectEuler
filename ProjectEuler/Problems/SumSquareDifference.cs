namespace ProjectEuler
{
    public class SumSquareDifference : IProblem
    {
        public int Id => 6;

        public string Title => "Sum square difference";

        public string Description => "The sum of the squares of the first ten natural numbers is," +
            "\n" +
            "\t1^2 + 2^2 + ... + 10^2 = 385" +
            "\n" +
            "The square of the sum of the first ten natural numbers is," +
            "\n" +
            "\t(1 + 2 + ... + 10)^2 = 55^2 = 3025" +
            "\n" +
            "Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is" +
            "\n" +
            "\t3025 - 385 = 2640." +
            "\n" +
            "Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.";

        public string Solution => $"the difference equals {FindDifference(100)}";

        private int FindDifference(int count)
        {
            int sum = 0;
            int squared = 0;

            for (int i = 1; i <= count; i++)
            {
                sum += i;
                squared += i * i;
            }
            int result = sum * sum - squared;

            return result;
        }
    }
}
