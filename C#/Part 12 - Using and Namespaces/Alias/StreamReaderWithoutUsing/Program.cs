using System;
using System.IO;

namespace StreamReaderWithoutUsing
{
    class Program
    {
        static void Main()
        {
            StreamReader reader = null;
            try
            {
                // Create a new StreamReader object
                reader = new StreamReader("example.txt");
                string content = reader.ReadToEnd();
                Console.WriteLine(content);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            finally
            {
                // Manually dispose of the StreamReader
                if (reader != null)
                {
                    reader.Close(); // Important to close to free resources
                }
            }
        }
    }
}
