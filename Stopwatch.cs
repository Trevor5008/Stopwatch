using System;

namespace CSharpIntermediate
{
    public class Stopwatch
    {
        public DateTime StartTime { get; private set; }
        public DateTime StopTime { get; private set; }
        private bool isRunning = false;

        public Stopwatch()
        {
            StartTime = DateTime.Now;
        }

        public void Start()
        {
            if (!isRunning)
            {
                isRunning = true;
                Console.Clear();
                Console.WriteLine("Running...");
            }
            else
            {
                throw new InvalidOperationException("Cannot start an already started stopwatch");
            }
        }
        public void Stop()
        {
            if (isRunning)
            {
                isRunning = false;
                Console.Write("Stopped...");
                Console.WriteLine("");
                StopTime = DateTime.Now;
                Console.WriteLine(StartTime.ToString("HH:mm:ss:ff"));
                Console.WriteLine(StopTime.ToString("HH:mm:ss:ff"));
                TimeSpan interval = StopTime - StartTime;
                // new start time is where timer left off
                StartTime = StopTime;
                Console.WriteLine(interval.TotalSeconds);
            }
            else
            {
                throw new InvalidOperationException("Cannot stop a stopped stopwatch");
            }
        }
    }
}
