namespace Present_Value
{
    partial class Form1
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
            this.labelFutureValue = new System.Windows.Forms.Label();
            this.labelAnnualRate = new System.Windows.Forms.Label();
            this.labelYears = new System.Windows.Forms.Label();
            this.futureValueTestBox = new System.Windows.Forms.TextBox();
            this.annualInterestRateTextBox = new System.Windows.Forms.TextBox();
            this.numberOfYearsTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.labelPresentValue = new System.Windows.Forms.Label();
            this.presentValueLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFutureValue
            // 
            this.labelFutureValue.AutoSize = true;
            this.labelFutureValue.Location = new System.Drawing.Point(12, 27);
            this.labelFutureValue.Name = "labelFutureValue";
            this.labelFutureValue.Size = new System.Drawing.Size(106, 13);
            this.labelFutureValue.TabIndex = 0;
            this.labelFutureValue.Text = "Future value desired:";
            // 
            // labelAnnualRate
            // 
            this.labelAnnualRate.AutoSize = true;
            this.labelAnnualRate.Location = new System.Drawing.Point(12, 64);
            this.labelAnnualRate.Name = "labelAnnualRate";
            this.labelAnnualRate.Size = new System.Drawing.Size(127, 13);
            this.labelAnnualRate.TabIndex = 1;
            this.labelAnnualRate.Text = "Annual Interest Rate (%): ";
            // 
            // labelYears
            // 
            this.labelYears.AutoSize = true;
            this.labelYears.Location = new System.Drawing.Point(12, 100);
            this.labelYears.Name = "labelYears";
            this.labelYears.Size = new System.Drawing.Size(89, 13);
            this.labelYears.TabIndex = 2;
            this.labelYears.Text = "Number of Years:";
            // 
            // futureValueTestBox
            // 
            this.futureValueTestBox.Location = new System.Drawing.Point(140, 24);
            this.futureValueTestBox.Name = "futureValueTestBox";
            this.futureValueTestBox.Size = new System.Drawing.Size(100, 20);
            this.futureValueTestBox.TabIndex = 3;
            // 
            // annualInterestRateTextBox
            // 
            this.annualInterestRateTextBox.Location = new System.Drawing.Point(140, 61);
            this.annualInterestRateTextBox.Name = "annualInterestRateTextBox";
            this.annualInterestRateTextBox.Size = new System.Drawing.Size(100, 20);
            this.annualInterestRateTextBox.TabIndex = 4;
            // 
            // numberOfYearsTextBox
            // 
            this.numberOfYearsTextBox.Location = new System.Drawing.Point(140, 97);
            this.numberOfYearsTextBox.Name = "numberOfYearsTextBox";
            this.numberOfYearsTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberOfYearsTextBox.TabIndex = 5;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(28, 191);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(109, 34);
            this.calculateButton.TabIndex = 6;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(155, 191);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(107, 34);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // labelPresentValue
            // 
            this.labelPresentValue.AutoSize = true;
            this.labelPresentValue.Location = new System.Drawing.Point(13, 128);
            this.labelPresentValue.Name = "labelPresentValue";
            this.labelPresentValue.Size = new System.Drawing.Size(88, 26);
            this.labelPresentValue.TabIndex = 8;
            this.labelPresentValue.Text = "Amount needed\r\n to deposit today:";
            // 
            // presentValueLabel
            // 
            this.presentValueLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.presentValueLabel.Location = new System.Drawing.Point(140, 132);
            this.presentValueLabel.Name = "presentValueLabel";
            this.presentValueLabel.Size = new System.Drawing.Size(100, 22);
            this.presentValueLabel.TabIndex = 9;
            this.presentValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 254);
            this.Controls.Add(this.presentValueLabel);
            this.Controls.Add(this.labelPresentValue);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.numberOfYearsTextBox);
            this.Controls.Add(this.annualInterestRateTextBox);
            this.Controls.Add(this.futureValueTestBox);
            this.Controls.Add(this.labelYears);
            this.Controls.Add(this.labelAnnualRate);
            this.Controls.Add(this.labelFutureValue);
            this.Name = "Form1";
            this.Text = "Present Value";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFutureValue;
        private System.Windows.Forms.Label labelAnnualRate;
        private System.Windows.Forms.Label labelYears;
        private System.Windows.Forms.TextBox futureValueTestBox;
        private System.Windows.Forms.TextBox annualInterestRateTextBox;
        private System.Windows.Forms.TextBox numberOfYearsTextBox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label labelPresentValue;
        private System.Windows.Forms.Label presentValueLabel;
    }
}

