namespace WordFreqCLI.Services
{
    public class WordCounter
    {
        public Dictionary<string, int> CountWords(List<string> words)
        {
            Dictionary<string, int> frequencies =
                new Dictionary<string, int>();

            foreach (string word in words)
            {
                if (frequencies.ContainsKey(word))
                {
                    frequencies[word]++;
                }
                else
                {
                    frequencies[word] = 1;
                }
            }

            return frequencies;
        }
    }
}