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
    public partial class SettingsForm : Form
    {
        private StatementTracker theTracker;

        public SettingsForm(StatementTracker tracker)
        {
            InitializeComponent();

            this.theTracker = tracker;

            this.Text = "Change settings for \"" + theTracker.Title_Of_Tracker + "\"";

            titleOfTracker.Text = theTracker.Title_Of_Tracker;
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {

        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            // Load in the items
            // Make sure there is something for the title
            if (titleOfTracker.Text.Trim().Length <= 0)
            {
                errorLabel.Text = "You must enter something.";
                return; // exit function
            }

            theTracker.Title_Of_Tracker = titleOfTracker.Text;

            // Tell the user
            errorLabel.Text = "Name of tracker successfully changed.";

            // Allow the user to close this window.
            completeButton.Enabled = true;
        }

        private void completeButton_Click(object sender, EventArgs e)
        {
            // Close the current window
            this.Close();
        }
    }
}
