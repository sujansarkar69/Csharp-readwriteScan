using System.Text.RegularExpressions;

namespace WordFreqCLI.Services
{
    public class TextProcessor
    {
        public List<string> ExtractWords(string text)
        {
            List<string> wordsList = new List<string>();

            string[] words =
                Regex.Split(text.ToLower(), @"[\s\p{P}]+");

            foreach (string word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    wordsList.Add(word);
                }
            }

            return wordsList;
        }
    }
}