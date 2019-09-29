namespace EZStatements
{
    partial class AddNewStatementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewStatementForm));
            this.cancelButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.isConsolidatedButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.amountForPeriod = new System.Windows.Forms.TextBox();
            this.addPayPeriodButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.completeButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(15, 14);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(87, 25);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(78, 75);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(241, 21);
            this.dateTimePicker.TabIndex = 2;
            // 
            // isConsolidatedButton
            // 
            this.isConsolidatedButton.AutoSize = true;
            this.isConsolidatedButton.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isConsolidatedButton.Location = new System.Drawing.Point(20, 139);
            this.isConsolidatedButton.Name = "isConsolidatedButton";
            this.isConsolidatedButton.Size = new System.Drawing.Size(150, 23);
            this.isConsolidatedButton.TabIndex = 4;
            this.isConsolidatedButton.TabStop = true;
            this.isConsolidatedButton.Text = "Is Consolidated";
            this.isConsolidatedButton.UseVisualStyleBackColor = true;
            this.isConsolidatedButton.CheckedChanged += new System.EventHandler(this.isConsolidatedButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Price:";
            // 
            // amountForPeriod
            // 
            this.amountForPeriod.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountForPeriod.Location = new System.Drawing.Point(78, 209);
            this.amountForPeriod.Name = "amountForPeriod";
            this.amountForPeriod.Size = new System.Drawing.Size(151, 21);
            this.amountForPeriod.TabIndex = 6;
            // 
            // addPayPeriodButton
            // 
            this.addPayPeriodButton.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPayPeriodButton.Location = new System.Drawing.Point(237, 207);
            this.addPayPeriodButton.Name = "addPayPeriodButton";
            this.addPayPeriodButton.Size = new System.Drawing.Size(113, 25);
            this.addPayPeriodButton.TabIndex = 7;
            this.addPayPeriodButton.Text = "Add Pay Period";
            this.addPayPeriodButton.UseVisualStyleBackColor = true;
            this.addPayPeriodButton.Click += new System.EventHandler(this.addPayPeriodButton_Click);
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(20, 267);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(87, 25);
            this.addButton.TabIndex = 8;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // completeButton
            // 
            this.completeButton.Enabled = false;
            this.completeButton.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeButton.Location = new System.Drawing.Point(115, 267);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(87, 25);
            this.completeButton.TabIndex = 9;
            this.completeButton.Text = "Complete";
            this.completeButton.UseVisualStyleBackColor = true;
            this.completeButton.Click += new System.EventHandler(this.completeButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.errorLabel.Location = new System.Drawing.Point(73, 324);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(178, 19);
            this.errorLabel.TabIndex = 10;
            this.errorLabel.Text = "Everything\'s working.";
            // 
            // AddNewStatementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(352, 355);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.completeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.addPayPeriodButton);
            this.Controls.Add(this.amountForPeriod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.isConsolidatedButton);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cancelButton);
            this.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddNewStatementForm";
            this.Text = "AddNewStatementForm";
            this.Load += new System.EventHandler(this.AddNewStatementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.RadioButton isConsolidatedButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox amountForPeriod;
        private System.Windows.Forms.Button addPayPeriodButton;
        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label errorLabel;
    }
}