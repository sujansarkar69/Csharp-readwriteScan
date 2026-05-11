using WordFreqCLI.Services;
using WordFreqCLI.Utils;

namespace WordFreqCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            FileReader reader = new FileReader();
            TextProcessor processor = new TextProcessor();
            WordCounter counter = new WordCounter();
            ConsolePrinter printer = new ConsolePrinter();

            string path = "/Users/sujansarkar/Desktop/TestFiles";

            string[] files = reader.GetTextFiles(path);

            List<string> allWords = new List<string>();

            foreach (string file in files)
            {
                Console.WriteLine($"Reading: {file}");

                string content = reader.ReadFile(file);

                List<string> words =
                    processor.ExtractWords(content);

                allWords.AddRange(words);
            }

            Dictionary<string, int> frequencies =
                counter.CountWords(allWords);

            Console.WriteLine("\nWORD FREQUENCIES:\n");

            printer.Print(frequencies);
        }
    }
}