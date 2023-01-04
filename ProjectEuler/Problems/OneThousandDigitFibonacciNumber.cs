using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler.Problems
{
    public class OneThousandDigitFibonacciNumber : IProblem
    {
        public int Id => 25;

        public string Title => "1000-digit Fibonacci number";

        public string Description => "The Fibonacci sequence is defined by the recurrence relation:" +
            "\n" +
            "    Fn = Fn−1 + Fn−2, where F1 = 1 and F2 = 1." +
            "\n" +
            "Hence the first 12 terms will be:" +
            "\n    F1 = 1" +
            "\n    F2 = 1" +
            "\n    F3 = 2" +
            "\n    F4 = 3" +
            "\n    F5 = 5" +
            "\n    F6 = 8" +
            "\n    F7 = 13" +
            "\n    F8 = 21" +
            "\n    F9 = 34" +
            "\n    F10 = 55" +
            "\n    F11 = 89" +
            "\n    F12 = 144" +
            "\n" +
            "The 12th term, F12, is the first term to contain three digits." +
            "\n" +
            "What is the index of the first term in the Fibonacci sequence to contain 1000 digits?";

        public string Solution => $"the first term index is {FindFirstTermIndex(1000)}";

        private int FindFirstTermIndex(int digitsNumber)
        {
            var fibonacci = new List<BigInteger>() { 1, 1, };
            while (fibonacci.Last().ToString().Length < digitsNumber)
            {
                fibonacci.Add(fibonacci.Last() + fibonacci[fibonacci.Count - 2]);
            }
            return fibonacci.Count();
        }
    }
}
