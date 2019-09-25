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
    public partial class MainForm : Form
    {
        private StatementTracker tracker;

        public MainForm()
        {
            // Load all components
            InitializeComponent();

            tracker = FileOperations.DeserializeFile();

            this.Text = "EZStatements v1.1";

            Update_Data();
        }

        private void Main_Load(object sender, EventArgs e){}

        // Performs action for "Save and Exit" button.
        private void button1_Click(object sender, EventArgs e)
        {
            CloseFunctionality();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Called whenever the the form is trying to be closed.
        /// </summary>
        private void CloseFunctionality()
        {
            // Write the data to the correct file.
            FileOperations.SerializeFile(tracker);

            Console.WriteLine("Data written to file.");
            Console.WriteLine("File closing.");

            // Close the Form
            this.Close();
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            Update_Data();
        }

        private void addStatementButton_Click(object sender, EventArgs e)
        {
            Statement newStatement = new Statement(null, false, 0, new POCO.PayPeriod.PayPeriod());

            // Open window to create a new statement
            AddNewStatementForm form = new AddNewStatementForm(newStatement);

            // Hide this window
            this.Hide();

            // Show our new form
            form.ShowDialog();

            if (newStatement.Date == null)
            {
                errorLabel.Text = "There was a problem. Creation failed.";
            }
            else
            {
                bool added = tracker.AddStatement(newStatement);

                if (!added)
                {
                    errorLabel.Text = "Statement failed to add.";
                }
            }

            // Show this window again
            this.Show();

            Clear_Fields();
            Update_Data();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {

        }

        private void flipButton_Click(object sender, EventArgs e)
        {
            // Get the data from the user
            int numberToFlip = int.Parse(numberToFlipTextField.Text);

            // Is the a valid number?
            if (numberToFlip >= tracker.The_Statements.List_Of_Statements.Count || numberToFlip < 0) // NOPE
            {
                errorLabel.Text = "Error attempting to flip. Invalid index!";
                return; // exit the function
            }

            // Get the value of that boolean
            bool currentBool = tracker.The_Statements.List_Of_Statements[numberToFlip].Is_Consolidated;

            // Flip that boolean
            tracker.The_Statements.List_Of_Statements[numberToFlip].Is_Consolidated = !currentBool;

            // Tell the user is worked
            errorLabel.Text = "Value for " + numberToFlip + " has been flipped.";

            Clear_Fields(); // Clear the fields
            Update_Data(); // update the screen
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // Get the data from the user
            int numberToRemove = int.Parse(numberToRemoveTextField.Text);

            // Is the a valid number?
            if (numberToRemove >= tracker.The_Statements.List_Of_Statements.Count || numberToRemove < 0) // NOPE
            {
                errorLabel.Text = "Error attempting to flip. Invalid index!";
                return; // exit the function
            }

            // Flip that boolean
            tracker.The_Statements.List_Of_Statements.RemoveAt(numberToRemove);

            // Tell the user is worked
            errorLabel.Text = "Value for " + numberToRemove + " has been removed.";

            Clear_Fields(); // Clear the fields
            Update_Data(); // update the screen
        }

        // Modify a statement.
        private void editButton_Click(object sender, EventArgs e)
        {
            if (numberToChangeTextField.Text.Trim() == "")
            {
                return;
            }
            // Grab the number that was entered.
            int valueToChange = int.Parse(numberToChangeTextField.Text);

            if (valueToChange >= tracker.The_Statements.List_Of_Statements.Count || valueToChange < 0)
            {
                errorLabel.Text = "Invalid entry.";
                // Leave the method.
                return;
            }

            // Open a Modify window to change the statement selected -- chooses Statement directly from list
            ModifyStatementForm form = new ModifyStatementForm(tracker.The_Statements.List_Of_Statements[valueToChange]);

            // hide this window. Show the new window. Show this window again, afterwards.
            this.Hide();
            form.ShowDialog();
            this.Show();

            // Clear all of the fields.
            Clear_Fields();
            Update_Data();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            // Open the "Settings" window
            SettingsForm settingsForm = new SettingsForm(tracker);

            this.Hide();

            settingsForm.ShowDialog();

            this.Show();

            Clear_Fields();
            Update_Data();
        }

        // Utility functions
        private void Clear_Fields()
        {
            numberToFlipTextField.Text = "";
            numberToRemoveTextField.Text = "";
            numberToChangeTextField.Text = "";
        }

        private void Update_Data()
        {
            textArea.Text = tracker.StatementDataToString();
        }
    }
}
