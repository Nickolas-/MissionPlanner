using System;
using System.Threading;

namespace SIGINT
{
    public class SimpleTimer : IDisposable
    {

        private readonly Timer _timer;

        private bool _inProgress;

        private Action _callback;

        public SimpleTimer(Action callback, TimeSpan rate)
            : this(callback, rate, randomStartTime: false)
        {
        }

        public SimpleTimer(Action callback, TimeSpan rate, bool randomStartTime)
        {
            _callback = callback;
            TimeSpan dueTime = rate;
            if (randomStartTime)
            {
                Random random = new Random();
                dueTime = TimeSpan.FromSeconds(rate.TotalSeconds * random.NextDouble());
            }

            _timer = new Timer(InternalWork, null, dueTime, rate);
        }

        private void InternalWork(object state)
        {
            if (_inProgress)
            {
                return;
            }

            try
            {
                _inProgress = true;
                _callback();
            }
            catch (Exception exception)
            {
            }
            finally
            {
                _inProgress = false;
            }
        }

        public void Dispose()
        {
            if (_timer != null)
            {
                _timer.Dispose();
            }
        }
    }
}
