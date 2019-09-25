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
            this.settingsButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveAndExitButton
            // 
            this.saveAndExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveAndExitButton.Location = new System.Drawing.Point(134, 8);
            this.saveAndExitButton.Margin = new System.Windows.Forms.Padding(4);
            this.saveAndExitButton.Name = "saveAndExitButton";
            this.saveAndExitButton.Size = new System.Drawing.Size(141, 28);
            this.saveAndExitButton.TabIndex = 0;
            this.saveAndExitButton.Text = "Save and Exit";
            this.saveAndExitButton.UseVisualStyleBackColor = true;
            this.saveAndExitButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // textArea
            // 
            this.textArea.BackColor = System.Drawing.SystemColors.Info;
            this.textArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textArea.Location = new System.Drawing.Point(17, 52);
            this.textArea.Margin = new System.Windows.Forms.Padding(4);
            this.textArea.Multiline = true;
            this.textArea.Name = "textArea";
            this.textArea.ReadOnly = true;
            this.textArea.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textArea.Size = new System.Drawing.Size(435, 492);
            this.textArea.TabIndex = 1;
            this.textArea.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // printButton
            // 
            this.printButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printButton.Location = new System.Drawing.Point(17, 552);
            this.printButton.Margin = new System.Windows.Forms.Padding(4);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(100, 28);
            this.printButton.TabIndex = 2;
            this.printButton.Text = "Print";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // addStatementButton
            // 
            this.addStatementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addStatementButton.Location = new System.Drawing.Point(124, 552);
            this.addStatementButton.Margin = new System.Windows.Forms.Padding(4);
            this.addStatementButton.Name = "addStatementButton";
            this.addStatementButton.Size = new System.Drawing.Size(119, 28);
            this.addStatementButton.TabIndex = 4;
            this.addStatementButton.Text = "Add statement";
            this.addStatementButton.UseVisualStyleBackColor = true;
            this.addStatementButton.Click += new System.EventHandler(this.addStatementButton_Click);
            // 
            // numberToFlipTextField
            // 
            this.numberToFlipTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberToFlipTextField.Location = new System.Drawing.Point(204, 618);
            this.numberToFlipTextField.Margin = new System.Windows.Forms.Padding(4);
            this.numberToFlipTextField.Name = "numberToFlipTextField";
            this.numberToFlipTextField.Size = new System.Drawing.Size(132, 22);
            this.numberToFlipTextField.TabIndex = 5;
            // 
            // numberToRemoveTextField
            // 
            this.numberToRemoveTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberToRemoveTextField.Location = new System.Drawing.Point(204, 656);
            this.numberToRemoveTextField.Margin = new System.Windows.Forms.Padding(4);
            this.numberToRemoveTextField.Name = "numberToRemoveTextField";
            this.numberToRemoveTextField.Size = new System.Drawing.Size(132, 22);
            this.numberToRemoveTextField.TabIndex = 6;
            // 
            // flipButton
            // 
            this.flipButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flipButton.Location = new System.Drawing.Point(344, 615);
            this.flipButton.Margin = new System.Windows.Forms.Padding(4);
            this.flipButton.Name = "flipButton";
            this.flipButton.Size = new System.Drawing.Size(100, 28);
            this.flipButton.TabIndex = 7;
            this.flipButton.Text = "Flip";
            this.flipButton.UseVisualStyleBackColor = true;
            this.flipButton.Click += new System.EventHandler(this.flipButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.Location = new System.Drawing.Point(344, 653);
            this.removeButton.Margin = new System.Windows.Forms.Padding(4);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(100, 28);
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
            this.errorLabel.Location = new System.Drawing.Point(120, 728);
            this.errorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(156, 20);
            this.errorLabel.TabIndex = 9;
            this.errorLabel.Text = "Everything\'s working.";
            // 
            // editButton
            // 
            this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.Location = new System.Drawing.Point(344, 686);
            this.editButton.Margin = new System.Windows.Forms.Padding(4);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(100, 26);
            this.editButton.TabIndex = 11;
            this.editButton.Text = "Edit";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // numberToChangeTextField
            // 
            this.numberToChangeTextField.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberToChangeTextField.Location = new System.Drawing.Point(204, 690);
            this.numberToChangeTextField.Margin = new System.Windows.Forms.Padding(4);
            this.numberToChangeTextField.Name = "numberToChangeTextField";
            this.numberToChangeTextField.Size = new System.Drawing.Size(132, 22);
            this.numberToChangeTextField.TabIndex = 10;
            // 
            // settingsButton
            // 
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Location = new System.Drawing.Point(17, 8);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(109, 28);
            this.settingsButton.TabIndex = 12;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 618);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 20);
            this.label11.TabIndex = 57;
            this.label11.Text = "Flip \"consolidated\" (#):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 658);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Remove a statement (#):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 688);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 59;
            this.label2.Text = "Edit a statement (#): ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(471, 753);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.settingsButton);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}