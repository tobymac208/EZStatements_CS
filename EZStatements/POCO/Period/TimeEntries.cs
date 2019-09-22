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
    public class TimeEntries : ISerializable
    {
        private List<TimeEntry> timeEntriesList;

        public TimeEntries()
        {
            timeEntriesList = new List<TimeEntry>();
        }

        public List<TimeEntry> TimeEntriesList
        {
            get { return timeEntriesList; }
            set { timeEntriesList = value; }
        }

        public void AddTimeEntry(TimeEntry value)
        {
            timeEntriesList.Add(value);
        }

        /// <summary>
        /// Calculates the total time amongst all of the time entries for this period.
        /// </summary>
        public double TotalTime
        {
            get
            {
                double totalTime = 0.0;

                foreach (TimeEntry entry in timeEntriesList)
                {
                    totalTime += entry.TotalTimeFractional;
                }

                return totalTime;
            }
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Time Entries", TimeEntriesList);
        }

        public TimeEntries(SerializationInfo info, StreamingContext context)
        {
            TimeEntriesList = (List<TimeEntry>)info.GetValue("Time Entries", typeof(List<TimeEntry>));
        }
    }
}
