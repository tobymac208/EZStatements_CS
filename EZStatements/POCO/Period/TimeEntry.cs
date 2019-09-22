using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace EZStatements.POCO.PayPeriod
{
    [Serializable()]
    public class TimeEntry : ISerializable
    {
        private int hours;
        private int minutes;

        public TimeEntry(int hours, int minutes)
        {
            this.hours = hours;
            this.minutes = minutes;
        }

        public TimeEntry()
        {
            hours = 0;
            minutes = 0;
        }

        public int Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        public int Minutes
        {
            get { return minutes; }
            set { minutes = value; }
        }

        public double TotalTimeFractional
        {
            get { return hours + (double)(minutes / 60.00); }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Hours", Hours);
            info.AddValue("Minutes", Minutes);
        }

        public TimeEntry(SerializationInfo info, StreamingContext context)
        {
            Hours = (int)info.GetValue("Hours", typeof(int));
            Minutes = (int)info.GetValue("Minutes", typeof(int));
        }
    }
}
