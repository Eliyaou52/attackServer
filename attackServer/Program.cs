using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attackServer
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //await GetDataAsync();
            //Console.WriteLine("Recivde Data");
            //Console.ReadLine();

            //2.
            //string FilePath = "C:\\Users\\e9189\\source\\repos\\attackServer\\attackServer\\MyFile.txt";
            //string conect = await ReadFileAsync(FilePath);
            //Console.WriteLine(conect);
            //Console.ReadLine();

            //3.
            Task<string> taskA = GetDataFromServuceAAsync();
            Task<string> taskB = GetDataFromServuceBAsync();

            await Task.WhenAll(taskA, taskB);

            Console.WriteLine($"Task A result: {taskA.Result}.");
            Console.WriteLine($"Task B result: {taskB.Result}.");
            Console.ReadLine();
        }

        public static async Task GetDataAsync()
        {
            Console.WriteLine("Recivde Data");
            await Task.Delay(100);
        }

        public static async Task<string> ReadFileAsync(string FilePath)
        {
            string result = await Task.Run(() => File.ReadAllText(FilePath));
            return result;
        }

        public static async Task<string> GetDataFromServuceAAsync()
        {
            await Task.Delay(100);
            return "Data from server A";
        }

        public static async Task<string> GetDataFromServuceBAsync()
        {
            await Task.Delay(100);
            return "Data from server B";
        }
    }
}
