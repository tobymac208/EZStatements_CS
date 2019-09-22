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
    public class PayPeriod : ISerializable
    {
        private TimeEntries timeEntriesList;
        private double payRate;

        public PayPeriod(TimeEntries timeEntries, double payRate)
        {
            this.timeEntriesList = timeEntries;
            this.payRate = payRate;
        }

        public PayPeriod()
        {
            this.timeEntriesList = new TimeEntries();
            this.payRate = 0;
        }

        public TimeEntries TimeEntriesList
        {
            get { return timeEntriesList; }
            set { timeEntriesList = value; }
        }

        public double PayRate
        {
            get { return payRate; }
            set { payRate = value; }
        }

        /// <summary>
        /// Calculates the pay for this specfic period.
        /// </summary>
        /// <returns></returns>
        public double CalculatePayForPeriod()
        {
            return timeEntriesList.TotalTime * payRate;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Time Entries", TimeEntriesList);
            info.AddValue("Pay Rate", PayRate);
        }

        public PayPeriod(SerializationInfo info, StreamingContext context)
        {
            TimeEntriesList = (TimeEntries)info.GetValue("Time Entries", typeof(TimeEntries));
            PayRate = (double)info.GetValue("Pay Rate", typeof(double));
        }
    } // End of PayPeriod class
} // end of namespace declaration
