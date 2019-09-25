using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace EZStatements.POCO.Statements
{
    [Serializable()]
    public class StatementTracker : ISerializable
    {
        private Statements the_statements;
        private String title_of_tracker;
        private double payRate;

        public StatementTracker(String title_of_tracker)
        {
            the_statements = new Statements();
            this.title_of_tracker = title_of_tracker;
        }

        public Statements The_Statements
        {
            get { return the_statements; }
            set { the_statements = value; }
        }

        public String Title_Of_Tracker
        {
            get { return title_of_tracker; }
            set { title_of_tracker = value; }
        }

        public double PayRate
        {
            get { return payRate; }
            set { payRate = value; }
        }

        /// <summary>
        /// Add a statement.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Boolean AddStatement(Statement value)
        {
            return the_statements.AddStatement(value);
        }

        /// <summary>
        /// Remove a statement.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public Boolean RemoveStatement(Statement value)
        {
            return the_statements.RemoveStatement(value);
        }

        /// <summary>
        /// Print out a detailed summary of what's in the 
        /// </summary>
        public String StatementDataToString()
        {
            if (the_statements.List_Of_Statements.Count < 1)
            {
                return "No data to examine";
            }

            // This is a total counter for all of the statements.
            int count = 0;

            // This is what will be returned
            String bufferedString = "";

            // Add in the title
            bufferedString += "Data for tracker \"" + title_of_tracker + "\"" + "\r\n\r\n";

            // Local variables for tracking calculations and totals
            double totalAmountOwed = 0;
            double totalAmountPaid = 0;
            double totalAmount = 0;
            double percentagePaid;

            // Iterate through our list
            foreach (Statement current_statement in the_statements.List_Of_Statements)
            {
                // For each Statement, add the data to the string
                bufferedString += "[" + count + "] " + current_statement.Date +
                        "\r\n\r\tAmount: $" + current_statement.Price_Of_Statement +
                        "\r\n\r\tConsolidated: " + current_statement.Is_Consolidated +
                        "\r\n\r\tHourly rate: " + current_statement.PayPeriod.PayRate + "\r\n";

                // Add to the total number of Statements
                count++;

                // Add to the total amount of money involved
                totalAmount += current_statement.Price_Of_Statement;

                // Checks whether the statement is settled or not
                if (!(current_statement.Is_Consolidated))
                { // is the current statement not dealt with?
                    totalAmountOwed += current_statement.Price_Of_Statement;
                }
                else
                {
                    totalAmountPaid += current_statement.Price_Of_Statement;
                }
            }
            // Calculate the percentage paid
            percentagePaid = (totalAmountPaid / totalAmount) * 100;

            bufferedString += "\r\n";

            const double percentageForTaxes = 50;

            // Add the final data
            bufferedString += "Data collected from " + count + " entry/entries.\r\n";
            bufferedString += "Total amount owed: $" + Utility.Round_Double(totalAmountOwed) + "\r\n";
            bufferedString += "Total amount paid: $" + Utility.Round_Double(totalAmountPaid) + "\r\n";
            bufferedString += "Total for withholdings, at a " + percentageForTaxes + "% rate: $" + Utility.Round_Double(totalAmountPaid * (percentageForTaxes/100)) + "\r\n";
            bufferedString += "% paid: " + Utility.Round_Double(percentagePaid) + "%\r\n\r\n";

            return bufferedString; // return the string to the user
        }

        /// <summary>
        /// Simply sets the list of our Statements equal to whatever the user passed in.
        /// </summary>
        /// <param name="value"></param>
        public void SetAllStatements(Statements value)
        {
            this.the_statements = value;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Statements", The_Statements);
            info.AddValue("Title of Tracker", Title_Of_Tracker);
        }

        public StatementTracker(SerializationInfo info, StreamingContext context)
        {
            The_Statements = (Statements)info.GetValue("Statements", typeof(Statements));
            Title_Of_Tracker = (String)info.GetValue("Title of Tracker", typeof(String));
        }

    } // End of StatementTracker class
} // end of namespace declaration
