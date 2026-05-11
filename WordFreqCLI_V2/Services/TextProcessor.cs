using System.Text.RegularExpressions;

namespace WordFreqCLI.Services
{
    public class TextProcessor
    {
        public List<string> ExtractWords(string text, int n, int m)
        {
            List<string> wordsList = new List<string>();

            string[] words =
              Regex.Split(text.ToLower(), @"[\s\p{P}]+");

            foreach (string word in words)
            {
             if (string.IsNullOrWhiteSpace(word))
                    continue;

                string processed = word;

        // VERSION 2 RULE
             if (processed.Length > n && processed.Length > m)
        {
            processed = processed.Substring(0, processed.Length - m);
        }

        wordsList.Add(processed);
    }

    return wordsList;
}
    }
}