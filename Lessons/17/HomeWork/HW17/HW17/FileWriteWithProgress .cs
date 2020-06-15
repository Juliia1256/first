using System;
using System.IO;

namespace HW17
{
    public class FileWriteWithProgress
    {
        public event EventHandler<RandomDataGeneratinfields> WritingPerformed;
        public event EventHandler<RandomDataGenerated> WritingComplited;
        public byte[] WriteBytes(string fileName, byte[] data, float percentageToFireEvent)
        {
            var percent = percentageToFireEvent * 100;
            for (var i = 0; i < data.Length; i++)
            {
                var count = i + 1.0f;
                File.AppendAllText(fileName, data[i].ToString());
                if (count % (int)percent == 0)
                {
                    var text = $"Process of writing to the {fileName} completed on {count}%";
                    StartWritingPerformed(this, text);
                }
            }
            WritingProgressComplited(this, data);
            return data;
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
