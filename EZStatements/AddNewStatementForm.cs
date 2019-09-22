using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using EZStatements.POCO.PayPeriod;
using EZStatements.POCO.Statements;

namespace EZStatements
{
    public partial class AddNewStatementForm : Form
    {
        // Our statement to use
        private Statement newStatement;

        public AddNewStatementForm(Statement value)
        {
            InitializeComponent();

            this.Text = "Create new statement";

            newStatement = value;
        }

        public Statement NewStatement
        {
            get { return newStatement; }
            set { newStatement = value; }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void addPayPeriodButton_Click(object sender, EventArgs e)
        {
            newStatement.PayPeriod = new PayPeriod();

            // Create a new window to use
            CreatePayPeriodForm form = new CreatePayPeriodForm(newStatement.PayPeriod);

            // Hide this windows
            this.Hide();

            // Show the window
            form.ShowDialog();
            
            amountForPeriod.Text = Utility.Round_Double(newStatement.PayPeriod.TimeEntriesList.TotalTime * newStatement.PayPeriod.PayRate) + "";

            // Show this window again
            this.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddNewStatementForm_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            PayPeriod period = newStatement.PayPeriod;

            string name = dateTimePicker.Text;
            bool is_consolidated = isConsolidatedButton.Checked;
            double amount = Double.Parse(amountForPeriod.Text);

            newStatement.Date = dateTimePicker.Text;
            newStatement.Is_Consolidated = is_consolidated;
            newStatement.Price_Of_Statement = amount;
            newStatement.PayPeriod = period;

            completeButton.Enabled = true;
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void isConsolidatedButton_CheckedChanged(object sender, EventArgs e)
        {
        }
    }
}
