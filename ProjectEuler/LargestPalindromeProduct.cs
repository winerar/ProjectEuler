using System;
using System.Linq;

namespace ProjectEuler
{
    public class LargestPalindromeProduct : IProblem
    {
        public int Id => 4;

        public string Title => "Largest palindrome product";

        public string Description => "A palindromic number reads the same both ways. " +
            "The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99." +
            "\n" +
            "Find the largest palindrome made from the product of two 3-digit numbers.";

        public string Solution => $"largest product is {FindLargestProduct()}";

        private int FindLargestProduct()
        {
            int largest = 0;

            bool found = false;
            int firstHalf = 998;
            int[] factors = new int[2];

            while (!found)
            {
                firstHalf--;
                int palindrome = makePalindrome(firstHalf);
                for (int i = 999; i > 99; i--)
                {
                    if ((palindrome / i) > 999 || i * i < palindrome)
                    {
                        break;
                    }
                    if (palindrome % i == 0)
                    {
                        found = true;
                        factors[0] = palindrome / i;
                        factors[1] = i;
                        largest = palindrome;
                        break;
                    }
                }
            }

            return largest;
        }

        private int makePalindrome(int firstHalf)
        {
            string value = Reverse(firstHalf.ToString());
            int length = value.Length;
            char[] reversed = new char[length];
            for (int i = 0; i < length; i++)
            {
                reversed[i] = value[i];
            }
            return int.Parse(firstHalf + new string(reversed));
        }

        private string Reverse(string text)
        {
            char[] array = text.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }
    }
}
