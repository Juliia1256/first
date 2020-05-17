using System;
using System.IO;

namespace CW17_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator g1 = new Generator();

            g1.GetArray += FileWrite;
            g1.Generate(3);
        }

        public static void FileWrite(object sender, DataGeneratorEventArgs dataGeneratorEventArgs)
        {
            foreach (var item in dataGeneratorEventArgs.arraybyte)
            {
                File.AppendAllText("log.txt", item.ToString());
            }
        }
    }
    class DataGeneratorEventArgs : EventArgs
    {
        public byte[] arraybyte { get; }
        public DataGeneratorEventArgs(byte[] arrayb)
        {
            arraybyte = arrayb;
        }

    }

    class Generator
    {
        public event EventHandler<DataGeneratorEventArgs> GetArray;
        public void Generate(int count)
        {
            Random rand = new Random();
            var arrayb = new byte [count];
            rand.NextBytes(arrayb);
            GetArray?.Invoke(this, new DataGeneratorEventArgs(arrayb));
        }

    }
}
