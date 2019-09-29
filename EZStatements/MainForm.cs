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

            Update_Comboboxes();

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
            string dateToFlip = flipSelectionCombobox.SelectedItem.ToString();

            if (dateToFlip.Trim().Equals(""))
            {
                errorLabel.Text = "No dates to flip.";
                return;
            }

            tracker.FlipByDate(dateToFlip);

            // Tell the user is worked
            errorLabel.Text = "Value for " + dateToFlip + " has been flipped.";

            Clear_Fields(); // Clear the fields
            Update_Data(); // update the screen
            Update_Comboboxes();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            // Get the data from the user
            string dateToRemove = removeSelectionCombobox.SelectedItem.ToString();

            if (dateToRemove.Trim().Equals(""))
            {
                errorLabel.Text = "No dates to remove.";
                return;
            }

            tracker.RemoveByDate(dateToRemove);

            // Tell the user is worked
            errorLabel.Text = "Value for " + dateToRemove + " has been removed.";

            Clear_Fields(); // Clear the fields
            Update_Data(); // update the screen
            Update_Comboboxes();
        }

        // Modify a statement.
        private void editButton_Click(object sender, EventArgs e)
        {
            if (editSelectionCombobox.SelectedItem.ToString().Trim() == "")
            {
                errorLabel.Text = "No dates to modify.";
                return;
            }

            // Grab the number that was entered.
            int valueToChange = tracker.FindIndexByDate(editSelectionCombobox.Text);

            // Open a Modify window to change the statement selected -- chooses Statement directly from list
            ModifyStatementForm form = new ModifyStatementForm(tracker.The_Statements.List_Of_Statements[valueToChange]);

            // hide this window. Show the new window. Show this window again, afterwards.
            this.Hide();
            form.ShowDialog();
            this.Show();

            // Clear all of the fields.
            Clear_Fields();
            Update_Data();
            Update_Comboboxes();
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

        // Called when someone has changed what's in the box
        private void entrySelectionCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        // Utility functions
        private void Clear_Fields()
        {
            flipSelectionCombobox.Text = "";
            removeSelectionCombobox.Text = "";
            editSelectionCombobox.Text = "";
        }

        private void Update_Data()
        {
            textArea.Text = tracker.StatementDataToString();
        }

        private void Update_Comboboxes()
        {
            flipSelectionCombobox.Items.Clear();
            removeSelectionCombobox.Items.Clear();
            editSelectionCombobox.Items.Clear();
            // Add the dates to the list
            foreach (Statement statement in tracker.The_Statements.List_Of_Statements)
            {
                flipSelectionCombobox.Items.Add(statement.Date);
                removeSelectionCombobox.Items.Add(statement.Date);
                editSelectionCombobox.Items.Add(statement.Date);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
