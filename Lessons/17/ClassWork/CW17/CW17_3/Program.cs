using System;
using System.Threading;

namespace CW17_3
{
    class Program
    {
        enum Task
        {
            Standard,
            Complex
        }
        class WorkCompletedEventArgs : EventArgs
        {
            public string Text { get; }
            public int Seconds { get; }
            public WorkCompletedEventArgs(string text, int seconds)
            {
                Text = text;
                Seconds = seconds;
            }
        }
        class Worker
        {
            public event EventHandler <WorkCompletedEventArgs> WorkCompleted;
            public event EventHandler WorkExecuting;
            private int _number;
            private int _delay;
            public Worker(int number, int delay)
            {
                _number = number;
                _delay = delay;
            }
            public void Start(Task task, int seconds)
            {
                var totalseconds = _delay + seconds;
                for (var i = 0; i<totalseconds; i++)
                {
                    Thread.Sleep(1 * 1000);
                    WorkExecuting?.Invoke(this, EventArgs.Empty);
                }
               
                var args = new WorkCompletedEventArgs($"Task with type: {task} completed after {totalseconds} seconds from worker {_number}",
                    totalseconds);
                WorkCompleted?.Invoke(this, args);
            }
        }
        class Printer
        {
            public static void PrinterResult(object sender, WorkCompletedEventArgs args) => Console.WriteLine(args.Text);
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
                worker.WorkCompleted += Printer.PrinterResult;
                worker.WorkExecuting += (sender,_) => Console.WriteLine("Execute");
                worker.Start(Task.Complex, 2);
            }

        }

    }
}
