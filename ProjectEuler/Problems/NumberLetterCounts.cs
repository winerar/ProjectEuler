namespace ProjectEuler.Problems
{
    public class NumberLetterCounts : IProblem
    {
        public int Id => 17;
        public string Title => "Number letter counts";
        public string Description => "If the numbers 1 to 5 are written out in words: one, two, three, four, five, " +
            "then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total." +
            "\n" +
            "If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used? " +
            "\n" +
            "NOTE: Do not count spaces or hyphens. " +
            "For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters." +
            " The use of \"and\" when writing out numbers is in compliance with British usage.";
        public string Solution => $"{GetLettersCount(1, 1000)} letters are used in total";

        private int GetLettersCount(int start, int end)
        {
            int count = 0;

            for (int i = start; i <= end; i++)
            {
                var stringNumber = string.Empty;
                var thousandsCount = i / 1000;
                var hundredsCount = i % 1000 / 100;
                var tensCount = i % 100 / 10;
                var unitsCount = i % 10;

                if (thousandsCount > 0 && thousandsCount <= 10)
                {
                    stringNumber += vocabular[thousandsCount];
                    stringNumber += vocabular[1000];
                }
                if (hundredsCount > 0 && hundredsCount < 10)
                {
                    stringNumber += vocabular[hundredsCount];
                    stringNumber += vocabular[100];
                    if (tensCount != 0 || unitsCount != 0)
                    {
                        stringNumber += "and";
                    }
                }
                if (tensCount > 0)
                {
                    if (tensCount == 1)
                    {
                        stringNumber += vocabular[i % 100];
                    }
                    else
                    {
                        stringNumber += vocabular[tensCount * 10];
                    }
                }
                if (unitsCount > 0 && tensCount != 1)
                {
                    stringNumber += vocabular[unitsCount];
                }
                count += stringNumber.Length;
            }

            return count;
        }

        private static Dictionary<int, string> vocabular = new Dictionary<int, string>
            {
                { 1, "one" },
                { 2, "two" },
                { 3, "three" },
                { 4, "four" },
                { 5, "five" },
                { 6, "six" },
                { 7, "seven" },
                { 8, "eight" },
                { 9, "nine" },
                { 10, "ten" },
                { 11, "eleven" },
                { 12, "twelve" },
                { 13, "thirteen" },
                { 14, "fourteen" },
                { 15, "fifteen" },
                { 16, "sixteen" },
                { 17, "seventeen" },
                { 18, "eighteen" },
                { 19, "nineteen" },
                { 20, "twenty" },
                { 30, "thirty" },
                { 40, "forty" },
                { 50, "fifty" },
                { 60, "sixty" },
                { 70, "seventy" },
                { 80, "eighty" },
                { 90, "ninety" },
                { 100, "hundred" },
                { 1000, "thousand" }
            };
    }
}
