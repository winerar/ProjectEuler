using System;
using System.Linq;

namespace ProjectEuler.Problems
{
    public class LongestCollatzSequence : IProblem
    {
        public int Id => 14;

        public string Title => "Longest Collatz sequence";

        public string Description => "The following iterative sequence is defined for the set of positive integers:" +
            "\n" +
            "\tn → n/2 (n is even)" +
            "\n" +
            "\tn → 3n + 1 (n is odd)" +
            "\n" +
            "Using the rule above and starting with 13, we generate the following sequence:" +
            "\n" +
            "\t13 → 40 → 20 → 10 → 5 → 16 → 8 → 4 → 2 → 1" +
            "\n" +
            "It can be seen that this sequence (starting at 13 and finishing at 1) contains 10 terms. " +
            "Although it has not been proved yet (Collatz Problem), it is thought that all starting numbers finish at 1." +
            "\n" +
            "Which starting number, under one million, produces the longest chain?" +
            "\n" +
            "NOTE: Once the chain starts the terms are allowed to go above one million.";

        public string Solution => $"number is {FindNumber()}";

        private int FindNumber()
        {
            int number = 1;
            long longestChain = 0;

            for (int i = 2; i < 1000000; i++)
            {
                var chainLength = FindChainLength(i);
                if (chainLength > longestChain)
                {
                    longestChain = chainLength;
                    number = i;
                }
            }

            return number;
        }

        private long FindChainLength(long number)
        {
            long chainLength = 1;

            while (number != 1)
            {
                if (number % 2 == 0)
                {
                    number = number / 2;
                }
                else
                {
                    number = 3 * number + 1;
                }
                chainLength += 1;
            }

            return chainLength;
        }
    }
}
