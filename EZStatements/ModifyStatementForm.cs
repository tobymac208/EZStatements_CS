using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EZStatements.POCO.Statements;

namespace EZStatements
{
    public partial class ModifyStatementForm : Form
    {
        private Statement statementToModify;

        // Default constructor. This allows the user to pass the Statement object by reference.
        public ModifyStatementForm(Statement statementByReference)
        {
            InitializeComponent();

            statementToModify = statementByReference;

            this.Text = "Modify Statement: " + statementToModify.Date;

            // Load in all of the data
            Update_Data();
        }

        private void ModifyStatementForm_Load(object sender, EventArgs e)
        {

        }

        // Update all of the fields with the Statement's data
        private void Update_Data()
        {
            hoursForSunday.Text = statementToModify.PayPeriod.TimeEntriesList.TimeEntriesList[0].Hours + "";
            minutesForSunday.Text = statementToModify.PayPeriod.TimeEntriesList.TimeEntriesList[0].Minutes + "";

            hoursForMonday.Text = statementToModify.PayPeriod.TimeEntriesList.TimeEntriesList[1].Hours + "";
            minutesForMonday.Text = statementToModify.PayPeriod.TimeEntriesList.TimeEntriesList[1].Minutes + "";

            hoursForTuesday.Text = statementToModify.PayPeriod.TimeEntriesList.TimeEntriesList[2].Hours + "";
            minutesForTuesday.Text = statementToModify.PayPeriod.TimeEntriesList.TimeEntriesList[2].Minutes + "";

            hoursForWednesday.Text = statementToModify.PayPeriod.TimeEntriesList.TimeEntriesList[3].Hours + "";
            minutesForWednesday.Text = statementToModify.PayPeriod.TimeEntriesList.TimeEntriesList[3].Minutes + "";

            hoursForThursday.Text = statementToModify.PayPeriod.TimeEntriesList.TimeEntriesList[4].Hours + "";
            minutesForThursday.Text = statementToModify.PayPeriod.TimeEntriesList.TimeEntriesList[4].Minutes + "";

            hoursForFriday.Text = statementToModify.PayPeriod.TimeEntriesList.TimeEntriesList[5].Hours + "";
            minutesForFriday.Text = statementToModify.PayPeriod.TimeEntriesList.TimeEntriesList[5].Minutes + "";

            hoursForSaturday.Text = statementToModify.PayPeriod.TimeEntriesList.TimeEntriesList[6].Hours + "";
            minutesForSaturday.Text = statementToModify.PayPeriod.TimeEntriesList.TimeEntriesList[6].Minutes + "";

            hourlyRate.Text = statementToModify.PayPeriod.PayRate + "";

            isConsolidatedButton.Checked = statementToModify.Is_Consolidated;
        }

        private void isConsolidatedButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            // Load in all of the options to our Statement object.
            statementToModify.Is_Consolidated = isConsolidatedButton.Checked;

            // Load in all of the entries
            statementToModify.PayPeriod.TimeEntriesList.TimeEntriesList[0].Hours =   int.Parse(hoursForSunday.Text );
            statementToModify.PayPeriod.TimeEntriesList.TimeEntriesList[0].Minutes = int.Parse(minutesForSunday.Text);

            statementToModify.PayPeriod.TimeEntriesList.TimeEntriesList[1].Hours =   int.Parse(hoursForMonday.Text);
            statementToModify.PayPeriod.TimeEntriesList.TimeEntriesList[1].Minutes = int.Parse(minutesForMonday.Text);

            statementToModify.PayPeriod.TimeEntriesList.TimeEntriesList[2].Hours =   int.Parse(hoursForTuesday.Text);
            statementToModify.PayPeriod.TimeEntriesList.TimeEntriesList[2].Minutes = int.Parse(minutesForTuesday.Text);

            statementToModify.PayPeriod.TimeEntriesList.TimeEntriesList[3].Hours =   int.Parse(hoursForWednesday.Text);
            statementToModify.PayPeriod.TimeEntriesList.TimeEntriesList[3].Minutes = int.Parse(minutesForWednesday.Text);

            statementToModify.PayPeriod.TimeEntriesList.TimeEntriesList[4].Hours =   int.Parse(hoursForThursday.Text);
            statementToModify.PayPeriod.TimeEntriesList.TimeEntriesList[4].Minutes = int.Parse(minutesForThursday.Text);

            statementToModify.PayPeriod.TimeEntriesList.TimeEntriesList[5].Hours =   int.Parse(hoursForFriday.Text);
            statementToModify.PayPeriod.TimeEntriesList.TimeEntriesList[5].Minutes = int.Parse(minutesForFriday.Text);

            statementToModify.PayPeriod.TimeEntriesList.TimeEntriesList[6].Hours =   int.Parse(hoursForSaturday.Text);
            statementToModify.PayPeriod.TimeEntriesList.TimeEntriesList[6].Minutes = int.Parse(minutesForSaturday.Text);

            // Load in the new Pay Rate
            statementToModify.PayPeriod.PayRate = Double.Parse(hourlyRate.Text);

            // Calculate the price of the statement
            statementToModify.Price_Of_Statement = statementToModify.PayPeriod.TimeEntriesList.TotalTime * statementToModify.PayPeriod.PayRate;
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            // Close this form
            this.Close();
        }
    }
}
