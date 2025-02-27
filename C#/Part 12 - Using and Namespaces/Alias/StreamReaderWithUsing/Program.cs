using System;
using System.IO;

namespace StreamReaderWithUsing
{
    class Program
    {
        static void Main()
        {
            // Using statement for StreamReader
            using (StreamReader reader = new StreamReader("example.txt"))
            {
                string content = reader.ReadToEnd();
                Console.WriteLine(content);
            } // StreamReader is disposed of automatically here
        }
    }
}
