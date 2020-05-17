using System;
using System.IO;

namespace CW17
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator g1 = new Generator();

            g1.GetArray += FileWrite;
            g1.Generate(3);
        }

        public static void FileWrite(byte[] b)
        {
            foreach (var item in b)
            {
                File.AppendAllText("log.txt", item.ToString());
            }
        }
    }

    class Generator
    {

        public delegate void Arraybyte(byte[] arrayb);
        public event Arraybyte GetArray;
        public void Generate(int count)
        {
            Random rand = new Random();
            byte[] arrayb = new byte[count];
            rand.NextBytes(arrayb);
            GetArray?.Invoke(arrayb);
        }

    }
}
