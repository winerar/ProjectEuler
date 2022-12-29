using System;
using System.Linq;

namespace ProjectEuler
{
    public class SmallestMultiple : IProblem
    {
        public int Id => 5;

        public string Title => "Smallest multiple";

        public string Description => "2520 is the smallest number that can be divided by each of the numbers from 1 to 10" +
            " without any remainder." +
            "\n" +
            "What is the smallest positive number that is evenly divisible by all of the numbers " +
            "from 1 to 20?";

        public string Solution => $"the smallest number is {GetSmallestMultiple()}";

        private int GetSmallestMultiple()
        {
            int i = 20;

            while (i % 3 != 0 || i % 6 != 0 || i % 7 != 0 ||
                i % 8 != 0 || i % 9 != 0 || i % 11 != 0 ||
                i % 12 != 0 || i % 13 != 0 || i % 14 != 0 ||
                i % 15 != 0 || i % 16 != 0 || i % 17 != 0 ||
                i % 18 != 0 || i % 19 != 0)
            {
                i += 20;
            }

            return i;
        }
    }
}
