namespace ProjectEuler
{
    public class SpecialPythagoreanTriplet : IProblem
    {
        public int Id => 9;

        public string Title => "Special Pythagorean triplet";

        public string Description => "A Pythagorean triplet is a set of three natural numbers, a < b < c, for which," +
            "\n" +
            "\ta^2 + b^2 = c^2" +
            "\n" +
            "For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2." +
            "\n" +
            "There exists exactly one Pythagorean triplet for which a + b + c = 1000." +
            "\n" +
            "Find the product abc.";

        public string Solution => $"product equals {FindProduct(1000)}";

        private int FindProduct(int sum)
        {
            int product = 0;
            bool productIsFound = false;

            for (int a = 1; a < sum; a++)
            {
                for (int b = a + 1; b < sum; b++)
                {
                    int c = sum - a - b;
                    if (a * a + b * b == c * c)
                    {
                        product = a * b * c;
                        productIsFound = true;
                        break;
                    }
                }
                if (productIsFound)
                {
                    break;
                }
            }

            return product;
        }
    }
}
