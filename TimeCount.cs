using System;

namespace Stopwatch
{
    partial class Program
    {
        public class TimeCount
        {
            // private instances of the class (so they can't be modified from outside)
            // модификатор доступа private, чтобы нельзя было напрямую поменять значения членов класса
            private DateTime _startTime;
            private TimeSpan _timer;
            private bool isWorking = false;

            // methods. методы.
            public void Start()
            {
                if (isWorking)
                {
                    throw new InvalidOperationException("You can't start a new timer before previous one is working");
                }
                else
                {
                    isWorking = true;
                    _startTime = DateTime.Now;
                }
            }

            public TimeSpan Stop(DateTime time)
            {
                isWorking = false;
                _timer = time - _startTime;
                return _timer;
            }
        }
    }
}
