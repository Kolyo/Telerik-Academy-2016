using System;

namespace GSM
{
    internal class Call
    {
        private DateTime callTime;
        private string number;
        private int duration;

        public DateTime CallTime
        {
            get { return callTime; }
            set { callTime = value; }
        }

        public string Number
        {
            get { return number; }
            set { number = value; }
        }

        public int Duration
        {
            get { return duration; }
            set { duration = value; }
        }
        public Call(DateTime callTime, string number, int duration)
        {
            CallTime = callTime;
            Number = number;
            Duration = duration;
        }
        public override string ToString()
        {
            return $"{CallTime} | {Number} | Duration: {Duration}";
        }
    }

}
