using System.IO;

namespace WordFreqCLI.Services
{
    public class FileReader
    {
        public string[] GetTextFiles(string directoryPath)
        {
            return Directory.GetFiles(directoryPath, "*.txt");
        }

        public string ReadFile(string filePath)
        {
            return File.ReadAllText(filePath);
        }
    }
}