using System;
using System.Collections.Generic;
using System.IO;

namespace HW17
{
    class Program
    {
        static void Main(string[] args)
        {
            var writer = new FileWriteWithProgress();
            writer.WritingComplited += WritingProgressComplited;
            writer.WritingPerformed += StartWritingPerformed;
            var randomsemp = writer.WriteBytes("text.log", 100, 0.5f);
            var randomsemp2 = writer.WriteBytes("file.log", 20, 0.2f);
        }
        public static void StartWritingPerformed(object sender, RandomDataGeneratinfields e) => Console.WriteLine(e.Text);
        public static void WritingProgressComplited(object sender, EventArgs e) => Console.WriteLine("Process completed");
    }
}
