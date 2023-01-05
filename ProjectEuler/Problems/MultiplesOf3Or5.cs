namespace ProjectEuler
{
    public class MultiplesOf3Or5 : IProblem
    {
        public int Id => 1;

        public string Title => "Multiples of 3 or 5";

        public string Description => "If we list all the natural numbers below 10 that are multiples of 3 or 5," +
            " we get 3, 5, 6 and 9. The sum of these multiples is 23." +
            "\n" +
            "Find the sum of all the multiples of 3 or 5 below 1000.";

        public string Solution => $"sum equals {GetSum(1, 1000)}";

        private int GetSum(int start, int end)
        {
            int sum = 0;

            for (int i = start; i < end; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
