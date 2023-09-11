using System.IO;

namespace AsyncFileHandling
{
    internal class Program
    {
        //public static string Content { get; set; }
        static async Task Main(string[] args)
        {
            string path = @"C:\Users\iT LOGIX\Desktop\FileHandling.txt"; //for reading
            string path2 = @"C:\Users\iT LOGIX\Desktop\random.txt"; // for writing


            var content = await ReadTextFromFile(path);
            WriteTextToFile(content,path2);
            Console.ReadLine();
        }

        static async Task WriteTextToFile(string content,string path)
        {
            if (File.Exists(path))
            {
                Console.WriteLine("Writing text to file plz wait...");
                using (StreamWriter sw = new StreamWriter(path))
                {
                    await sw.WriteLineAsync(content);
                }
                Console.WriteLine("Writing to file completed!");
            }
        }

        static async Task<string?> ReadTextFromFile(string path)
        {
            Console.WriteLine("Now reading file...");
            using (StreamReader sr = new StreamReader(path))
            {
                string content="";

                if (sr.ReadLine() != null)
                {
                    content =  await sr.ReadToEndAsync();
                }
                Console.WriteLine("Reading file completed...");
                return content;
            }
        }
    }
}