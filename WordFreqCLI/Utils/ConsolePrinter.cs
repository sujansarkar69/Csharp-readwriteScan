namespace WordFreqCLI.Utils
{
    public class ConsolePrinter
    {
        public void Print(Dictionary<string, int> frequencies)
        {
            foreach (var entry in frequencies)
            {
                Console.WriteLine($"{entry.Key} : {entry.Value}");
            }
        }
    }
}