using System;
using System.Threading;

namespace CW17_1
{
    class Program
    {
        enum Task
        {
            Standard,
            Complex
        }
        class Worker
        {
            public event Action<string> WorkCompleted;
            private int _number;
            private int _delay;
            public Worker(int number, int delay)
            {
                _number = number;
                _delay = delay;
            }
            public void Start(Task task, int seconds)
            {
                Thread.Sleep((_delay+seconds) * 1000);
                var result = $"Task with type: {task} completed after {_delay + seconds} seconds from worker {_number}";
                WorkCompleted?.Invoke(result);
            }
        }
        static void Main(string[] args)
        {
            var workers = new[]
            {
                new Worker(1, 0),
                new Worker(2, 1),
                new Worker(3, 2)
            };

            foreach (var worker in workers)
            {
                worker.WorkCompleted += OnCompleted;
                worker.Start(Task.Complex, 2);
            }

        }
        private static void OnCompleted(string result)
        {
            Console.WriteLine(result);
        }
    }
}
