using LeaningDDD.Domain.Entities;
using Learning_DDD.WinForm.StaticValues;
using LearningDDD.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Learning_DDD.WinForm.BackgroundWorkers
{
    public static class LatestTimer
    {
        private static Timer _timer;
        private static bool _isWork = false;

        static LatestTimer()
        {
            _timer = new Timer(Callback);
        }

        internal static void Start()
        {
            _timer.Change(0, 10000);
        }

        internal static void Stop()
        {
            _timer.Change(Timeout.Infinite, Timeout.Infinite);
        }

        private static void Callback(object o)
        {
            if (_isWork == true)
            {
                return;
            }

            try
            {
                _isWork = true;
                Measures.Create(Factories.CreateMeasure());
            }
            finally
            {
                _isWork = false;
            }
        }

    }
}
