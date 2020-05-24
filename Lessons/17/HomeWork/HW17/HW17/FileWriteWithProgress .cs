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
            var count = 1.0f;
            for (var i = 0; i < datasize; i++)
            {
                array[i] = (byte)rand.Next(100);
                File.AppendAllText(fileName, i.ToString());
                if (((i + count) / datasize) % percentageToFireEvent == 0)
                {
                    var text = $"Process of writing to the {fileName} completed on {((i + count) / datasize) * 100}%";
                    StartWritingPerformed(this, text);
                }
                else if ((i + count) == datasize)
                {
                    var text = $"Process of writing to the {fileName} completed on 100%";
                    StartWritingPerformed(this, text);
                }
            }
            WritingProgressComplited(this, array);
            return array;
        }
        protected virtual void StartWritingPerformed(object sender, string text)
        {
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
