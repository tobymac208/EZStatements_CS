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
    public partial class CreatePayPeriodForm : Form
    {
        private PayPeriod period;

        public CreatePayPeriodForm(PayPeriod value)
        {
            InitializeComponent();

            this.Text = "Create new pay period";

            period = value;
        }

        public PayPeriod Period
        {
            get { return period; }
            set { period = value; }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void CreatePayPeriodForm_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // -- Load in all items -- //
            // Sunday
            int sunday_hours = ParseFieldToInt(hoursForSunday);
            int sunday_minutes = ParseFieldToInt(minutesForSunday);

            // Monday
            int monday_hours = ParseFieldToInt(hoursForMonday);
            int monday_minutes = ParseFieldToInt(minutesForMonday);

            // Tuesday
            int tuesday_hours = ParseFieldToInt(hoursForTuesday);
            int tuesday_minutes = ParseFieldToInt(minutesForMonday);

            // Wednesday
            int wednesday_hours = ParseFieldToInt(hoursForWednesday);
            int wednesday_minutes = ParseFieldToInt(minutesForWednesday);

            // Thursday
            int thursday_hours = ParseFieldToInt(hoursForThursday);
            int thursday_minutes = ParseFieldToInt(minutesForThursday);

            // Friday
            int friday_hours = ParseFieldToInt(hoursForFriday);
            int friday_minutes = ParseFieldToInt(minutesForFriday);

            // Saturday
            int saturday_hours = ParseFieldToInt(hoursForSaturday);
            int saturday_minutes = ParseFieldToInt(minutesForSaturday);

            double hourly_rate;

            if (hourlyRate.Text != "")
            {
                hourly_rate = double.Parse(hourlyRate.Text);
            }
            else
            {
                hourly_rate = 0;
            }

            // Create entries
            TimeEntry sunday_entry = new TimeEntry(sunday_hours, sunday_minutes);
            TimeEntry monday_entry = new TimeEntry(monday_hours, monday_minutes);
            TimeEntry tuesday_entry = new TimeEntry(tuesday_hours, tuesday_minutes);
            TimeEntry wednesday_entry = new TimeEntry(wednesday_hours, wednesday_minutes);
            TimeEntry thursday_entry = new TimeEntry(thursday_hours, thursday_minutes);
            TimeEntry friday_entry = new TimeEntry(friday_hours, friday_minutes);
            TimeEntry saturday_entry = new TimeEntry(saturday_hours, saturday_minutes);

            // Add entries to our list
            Period.TimeEntriesList.AddTimeEntry(sunday_entry);
            Period.TimeEntriesList.AddTimeEntry(monday_entry);
            Period.TimeEntriesList.AddTimeEntry(tuesday_entry);
            Period.TimeEntriesList.AddTimeEntry(wednesday_entry);
            Period.TimeEntriesList.AddTimeEntry(thursday_entry);
            Period.TimeEntriesList.AddTimeEntry(friday_entry);
            Period.TimeEntriesList.AddTimeEntry(saturday_entry);

            // Initialize the hourly rate
            Period.PayRate = hourly_rate;

            completeButton.Enabled = true;
        }
        
        /// <summary>
        /// Simply returns the result of returning the field's value converted to an int.
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        private int ParseFieldToInt(TextBox field)
        {
            if (field.Text != "")
            {
                return int.Parse(field.Text);
            }

            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            hoursForSunday.Text = "0";
            minutesForSunday.Text = "0";

            hoursForMonday.Text = "0";
            minutesForMonday.Text = "0";

            hoursForTuesday.Text = "0";
            minutesForTuesday.Text = "0";

            hoursForWednesday.Text = "0";
            minutesForWednesday.Text = "0";

            hoursForThursday.Text = "0";
            minutesForThursday.Text = "0";

            hoursForFriday.Text = "0";
            minutesForFriday.Text = "0";

            hoursForSaturday.Text = "0";
            minutesForSaturday.Text = "0";

            hourlyRate.Text = "0";
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
