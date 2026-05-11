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

            Console.WriteLine("Enter directory path:");
            string path = Console.ReadLine() ?? "";

            if (!Directory.Exists(path))
            {
                Console.WriteLine("Directory does not exist.");
                return;
            }

            Console.WriteLine("Enter N:");
            string nInput = Console.ReadLine() ?? "0";
            int n = int.Parse(nInput);

            Console.WriteLine("Enter M:");
            string mInput = Console.ReadLine() ?? "0";
            int m = int.Parse(mInput);

            string[] files = reader.GetTextFiles(path);

            List<string> allWords = new List<string>();

            foreach (string file in files)
            {
                Console.WriteLine($"\nReading: {file}");

                string content = reader.ReadFile(file);

                List<string> words = processor.ExtractWords(content, n, m);

                allWords.AddRange(words);
            }

            Dictionary<string, int> frequencies = counter.CountWords(allWords);

            Console.WriteLine("\nWORD FREQUENCIES:\n");

            printer.Print(frequencies);
        }
    }
}