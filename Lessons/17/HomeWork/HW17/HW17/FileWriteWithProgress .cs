using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HW17
{
    public class FileWriteWithProgress
    {
        public event EventHandler<RandomDataGeneratinfields> WritingPerformed;
        public event EventHandler<RandomDataGenerated> WritingComplited;
        private string _fileName;
        public byte[] WriteBytes(string fileName, int datasize, float percentageToFireEvent)
        {
            _fileName = fileName;
            Random rand = new Random();
            var array = new byte[datasize];
            rand.NextBytes(array);
            foreach (var item in array)
            {
                File.AppendAllText(fileName, item.ToString());
            }
            StartWritingPerformed(this, percentageToFireEvent);
            WritingProgressComplited(this, array);
            return array;
        }
        protected virtual void StartWritingPerformed(object sender, float percentageToFireEvent)
        {
            var counToProcess = 1.0f / percentageToFireEvent;
            var text = new List<string>();
            for (var i = 0; i < counToProcess; i++)
            {
                var result = i + 1;
                text.Add($"Process completed on {result * 10}%");
            }
            var args = new RandomDataGeneratinfields
            {
                Text = text
            };
            WritingPerformed?.Invoke(sender, args);

        }
        protected virtual void WritingProgressComplited(object sender, byte[] array)
        {
            var args = new RandomDataGenerated
            {
                RandomData = array
            };
            WritingComplited?.Invoke(sender, args);
        }

    }
}
