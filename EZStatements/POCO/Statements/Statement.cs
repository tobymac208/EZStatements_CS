using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using EZStatements.POCO.PayPeriod;
using EZStatements;

namespace EZStatements.POCO.Statements
{
    [Serializable()]
    public class Statement : ISerializable
    {
        // Name for the statement
        private String date;
        // Flag for checking whether the statement has been dealt with
        private Boolean statement_consolidated;
        // Amount of money for the statement
        private double price_of_statement;
        // Holds all of the time entries
        private PayPeriod.PayPeriod payPeriod;

        public Statement(String date, Boolean statement_consolidated, double price_of_statement, PayPeriod.PayPeriod payPeriod)
        {
            this.date = date;
            this.statement_consolidated = statement_consolidated;
            this.price_of_statement = price_of_statement;
            this.payPeriod = payPeriod;
        }

        public Statement()
        {
            this.date = null;
            this.statement_consolidated = false;
            this.price_of_statement = 0;
            this.payPeriod = null;
        }

        public String Date
        {
            get { return date; }
            set { date = value; }
        }

        public Boolean Is_Consolidated
        {
            get { return statement_consolidated; }
            set { statement_consolidated = value; }
        }

        public double Price_Of_Statement
        {
            get { return Utility.Round_Double(payPeriod.TimeEntriesList.TotalTime * payPeriod.PayRate); }
            set { price_of_statement = value; }
        }

        public PayPeriod.PayPeriod PayPeriod
        {
            get { return payPeriod; }
            set { payPeriod = value; }
        }

        /// <summary>
        /// Checks if two Statements are equal
        /// </summary>
        /// <returns></returns>
        public Boolean Equals(Statement value)
        {
            return (value.Date == this.Date);
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Date", Date);
            info.AddValue("Statement Consolidated", Is_Consolidated);
            info.AddValue("Pay Period", this.PayPeriod);
            info.AddValue("Price of Statement", Price_Of_Statement);
        }

        public Statement(SerializationInfo info, StreamingContext context)
        {
            Date = (String)info.GetValue("Date", typeof(String));
            Is_Consolidated = (Boolean)info.GetValue("Statement Consolidated", typeof(Boolean));
            this.PayPeriod = (PayPeriod.PayPeriod)info.GetValue("Pay Period", typeof(PayPeriod.PayPeriod));
            // This is a shorthand for calculating the amount of money
            Price_Of_Statement = Price_Of_Statement;
        }
    }
}
