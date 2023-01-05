namespace ProjectEuler.Problems
{
    public class NamesScores : IProblem
    {
        public int Id => 22;

        public string Title => "Names scores";

        public string Description => "Using names.txt (right click and 'Save Link/Target As...'), " +
            "a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order. " +
            "Then working out the alphabetical value for each name, " +
            "multiply this value by its alphabetical position in the list to obtain a name score." +
            "\n" +
            "For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, " +
            "is the 938th name in the list. So, COLIN would obtain a score of 938 × 53 = 49714." +
            "\n" +
            "What is the total of all the name scores in the file?";

        public string Solution => $"the total of all scores is {FindTotal()}";

        private int FindTotal()
        {
            string path = @"Files\p022_names.txt";

            if (!File.Exists(path))
            {
                return -1;
            }

            StreamReader streamReader = new StreamReader(path);
            string text = streamReader.ReadToEnd();
            streamReader.Close();

            var names = new List<string>(text.Replace("\"", "").Split(new char[] { ',' }));
            names.Sort();

            int total = 0;

            for (int i = 0; i < names.Count; i++)
            {
                total += (i + 1) * AlphabeticalValue(names[i]);
            }

            return total;
        }

        private int AlphabeticalValue(string word)
        {
            int value = 0;
            foreach (char ch in word)
            {
                value += ch - 64;
            }
            return value;
        }
    }
}
