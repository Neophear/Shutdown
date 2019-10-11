using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Shutdown
{
    class DetailedTimer
    {
        private Timer timerSecond = new Timer(1000);
        
        /// <summary>
        /// Fires when the Hour property changes
        /// </summary>
        public event EventHandler OnHourChange;
        private void HourChange()
        {
            EventHandler handler = OnHourChange;
            if (null != handler) handler(this, EventArgs.Empty);
        }

        /// <summary>
        /// Fires when the Minute property changes
        /// </summary>
        public event EventHandler OnMinuteChange;
        private void MinuteChange()
        {
            EventHandler handler = OnMinuteChange;
            if (null != handler) handler(this, EventArgs.Empty);
        }

        /// <summary>
        /// Fires when the Second property changes
        /// </summary>
        public event EventHandler OnSecondChange;
        private void SecondChange()
        {
            EventHandler handler = OnSecondChange;
            if (null != handler) handler(this, EventArgs.Empty);
        }

        /// <summary>
        /// Fires when timer reaches 0
        /// </summary>
        public event EventHandler OnTimerDone;
        private void TimerDone()
        {
            EventHandler handler = OnTimerDone;
            if (null != handler) handler(this, EventArgs.Empty);
        }

        private int hour = 0;
        public int Hour
        {
            get
            {
                return hour;
            }
            set
            {
                HourChange();
                hour = value;
            }
        }

        private int minute = 0;
        public int Minute
        {
            get
            {
                return minute;
            }
            set
            {
                MinuteChange();
                minute = value;
            }
        }

        private int second = 0;
        public int Second
        {
            get
            {
                return second;
            }
            set
            {
                SecondChange();
                second = value;
            }
        }

        public DetailedTimer()
        {
            timerSecond.Elapsed += timerSecond_Elapsed;
        }

        /// <summary>
        /// Creates a new instance of DetailedTimer
        /// </summary>
        /// <param name="hour">Set hours</param>
        /// <param name="minute">Set minutes</param>
        /// <param name="second">Set seconds</param>
        public DetailedTimer(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        void timerSecond_Elapsed(object sender, ElapsedEventArgs e)
        {
            CountDownSecond();
        }

        private void CountDownSecond()
        {
            if (Second > 0)
                Second--;
            else if (Minute > 0)
            {
                Minute--;
                Second = 59;
            }
            else if (Hour > 0)
            {
                Hour--;
                Minute = 59;
                Second = 59;
            }
            else
	        {
                timerSecond.Stop();
                TimerDone();
	        }
        }

        /// <summary>
        /// Starts the timer
        /// </summary>
        public void Start()
        {
            timerSecond.Start();
        }

        /// <summary>
        /// Stops the timer
        /// </summary>
        public void Stop()
        {
            timerSecond.Stop();
        }
    }
}