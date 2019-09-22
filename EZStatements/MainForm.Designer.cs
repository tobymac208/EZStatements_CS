namespace EZStatements
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.saveAndExitButton = new System.Windows.Forms.Button();
            this.textArea = new System.Windows.Forms.TextBox();
            this.printButton = new System.Windows.Forms.Button();
            this.addStatementButton = new System.Windows.Forms.Button();
            this.numberToFlipTextField = new System.Windows.Forms.TextBox();
            this.numberToRemoveTextField = new System.Windows.Forms.TextBox();
            this.flipButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.numberToChangeTextField = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveAndExitButton
            // 
            this.saveAndExitButton.Location = new System.Drawing.Point(7, 2);
            this.saveAndExitButton.Name = "saveAndExitButton";
            this.saveAndExitButton.Size = new System.Drawing.Size(106, 23);
            this.saveAndExitButton.TabIndex = 0;
            this.saveAndExitButton.Text = "Save and Exit";
            this.saveAndExitButton.UseVisualStyleBackColor = true;
            this.saveAndExitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textArea
            // 
            this.textArea.Location = new System.Drawing.Point(13, 42);
            this.textArea.Multiline = true;
            this.textArea.Name = "textArea";
            this.textArea.ReadOnly = true;
            this.textArea.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textArea.Size = new System.Drawing.Size(783, 247);
            this.textArea.TabIndex = 1;
            this.textArea.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(13, 296);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(75, 23);
            this.printButton.TabIndex = 2;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // addStatementButton
            // 
            this.addStatementButton.Location = new System.Drawing.Point(94, 296);
            this.addStatementButton.Name = "addStatementButton";
            this.addStatementButton.Size = new System.Drawing.Size(89, 23);
            this.addStatementButton.TabIndex = 4;
            this.addStatementButton.Text = "Add statement";
            this.addStatementButton.UseVisualStyleBackColor = true;
            this.addStatementButton.Click += new System.EventHandler(this.addStatementButton_Click);
            // 
            // numberToFlipTextField
            // 
            this.numberToFlipTextField.Location = new System.Drawing.Point(13, 351);
            this.numberToFlipTextField.Name = "numberToFlipTextField";
            this.numberToFlipTextField.Size = new System.Drawing.Size(100, 20);
            this.numberToFlipTextField.TabIndex = 5;
            // 
            // numberToRemoveTextField
            // 
            this.numberToRemoveTextField.Location = new System.Drawing.Point(13, 378);
            this.numberToRemoveTextField.Name = "numberToRemoveTextField";
            this.numberToRemoveTextField.Size = new System.Drawing.Size(100, 20);
            this.numberToRemoveTextField.TabIndex = 6;
            // 
            // flipButton
            // 
            this.flipButton.Location = new System.Drawing.Point(119, 351);
            this.flipButton.Name = "flipButton";
            this.flipButton.Size = new System.Drawing.Size(75, 23);
            this.flipButton.TabIndex = 7;
            this.flipButton.Text = "Flip";
            this.flipButton.UseVisualStyleBackColor = true;
            this.flipButton.Click += new System.EventHandler(this.flipButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(119, 377);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 8;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.errorLabel.Location = new System.Drawing.Point(321, 421);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(156, 20);
            this.errorLabel.TabIndex = 9;
            this.errorLabel.Text = "Everything\'s working.";
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(119, 403);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(75, 21);
            this.editButton.TabIndex = 11;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // numberToChangeTextField
            // 
            this.numberToChangeTextField.Location = new System.Drawing.Point(13, 404);
            this.numberToChangeTextField.Name = "numberToChangeTextField";
            this.numberToChangeTextField.Size = new System.Drawing.Size(100, 20);
            this.numberToChangeTextField.TabIndex = 10;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.numberToChangeTextField);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.flipButton);
            this.Controls.Add(this.numberToRemoveTextField);
            this.Controls.Add(this.numberToFlipTextField);
            this.Controls.Add(this.addStatementButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.textArea);
            this.Controls.Add(this.saveAndExitButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveAndExitButton;
        private System.Windows.Forms.TextBox textArea;
        private System.Windows.Forms.Button printButton;
        private System.Windows.Forms.Button addStatementButton;
        private System.Windows.Forms.TextBox numberToFlipTextField;
        private System.Windows.Forms.TextBox numberToRemoveTextField;
        private System.Windows.Forms.Button flipButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.TextBox numberToChangeTextField;
    }
}