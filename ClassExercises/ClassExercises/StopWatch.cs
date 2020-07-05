using System;

namespace ClassExercises
{
    class StopWatch
    {
        private DateTime _start;
        private DateTime _stop;
        private bool _isActive;

        public void StartTimer()
        {
            if (_isActive)
                throw new Exception("Stopwatch is already running");

            _start = DateTime.Now;
            _isActive = true;
                
            Console.WriteLine("StopWatch started, press enter again to stop.");
            Console.ReadLine();
        }

        public void StopTimer()
        {
            if (!_isActive)
                throw new Exception("Stop Watch not running.");

            _stop = DateTime.Now;
            _isActive = false;

            Console.WriteLine("Time elapsed: " + GetTime());
        }

        private TimeSpan GetTime()
        {
            return _stop - _start;
        }

        public static void runStopWatch()
        {
            while (true)
            {
                Console.WriteLine("Type 'exit' to leave program or 'start' to start stopwatch");
                var command = Console.ReadLine();
                if (command.ToLower() == "exit")
                    break;
                else if (command.ToLower() == "start")
                {
                    var stopwatch = new StopWatch();
                    stopwatch.StartTimer();
                    stopwatch.StopTimer();
                }
                else
                {
                    Console.WriteLine("Sorry... I didn't understand.");
                }

            }
        }
    }
}
