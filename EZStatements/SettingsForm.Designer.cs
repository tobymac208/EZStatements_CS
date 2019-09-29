namespace EZStatements
{
    partial class SettingsForm
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
            this.errorLabel = new System.Windows.Forms.Label();
            this.completeButton = new System.Windows.Forms.Button();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.titleOfTracker = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.errorLabel.Location = new System.Drawing.Point(199, 122);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(178, 19);
            this.errorLabel.TabIndex = 122;
            this.errorLabel.Text = "Everything\'s working.";
            // 
            // completeButton
            // 
            this.completeButton.Enabled = false;
            this.completeButton.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeButton.Location = new System.Drawing.Point(154, 59);
            this.completeButton.Name = "completeButton";
            this.completeButton.Size = new System.Drawing.Size(133, 36);
            this.completeButton.TabIndex = 121;
            this.completeButton.Text = "Complete";
            this.completeButton.UseVisualStyleBackColor = true;
            this.completeButton.Click += new System.EventHandler(this.completeButton_Click);
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveChangesButton.Location = new System.Drawing.Point(14, 59);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(133, 36);
            this.saveChangesButton.TabIndex = 120;
            this.saveChangesButton.Text = "Save Changes";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.saveChangesButton_Click);
            // 
            // titleOfTracker
            // 
            this.titleOfTracker.Location = new System.Drawing.Point(154, 11);
            this.titleOfTracker.Name = "titleOfTracker";
            this.titleOfTracker.Size = new System.Drawing.Size(187, 21);
            this.titleOfTracker.TabIndex = 124;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 19);
            this.label1.TabIndex = 123;
            this.label1.Text = "Title of tracker: ";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(554, 157);
            this.Controls.Add(this.titleOfTracker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.completeButton);
            this.Controls.Add(this.saveChangesButton);
            this.Font = new System.Drawing.Font("Montserrat", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button completeButton;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.TextBox titleOfTracker;
        private System.Windows.Forms.Label label1;
    }
}