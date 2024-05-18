namespace SendTimeCalculator
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            calculateButton = new Button();
            importLabel = new Label();
            importTextBox = new TextBox();
            toxicsnipeInputLabel = new Label();
            outputBox = new TextBox();
            SendTimeHeader = new Label();
            remainingTimeLabel = new Label();
            ArrivalTimeHeader = new Label();
            outputArrivalText = new TextBox();
            SuspendLayout();
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(371, 80);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(151, 26);
            calculateButton.TabIndex = 0;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // importLabel
            // 
            importLabel.AutoSize = true;
            importLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 1, true);
            importLabel.Location = new Point(12, 9);
            importLabel.Name = "importLabel";
            importLabel.Size = new Size(204, 28);
            importLabel.TabIndex = 1;
            importLabel.Text = "Calculate Send Time";
            // 
            // importTextBox
            // 
            importTextBox.Location = new Point(12, 70);
            importTextBox.MaxLength = 99999999;
            importTextBox.Multiline = true;
            importTextBox.Name = "importTextBox";
            importTextBox.ScrollBars = ScrollBars.Vertical;
            importTextBox.Size = new Size(345, 46);
            importTextBox.TabIndex = 2;
            // 
            // toxicsnipeInputLabel
            // 
            toxicsnipeInputLabel.AutoSize = true;
            toxicsnipeInputLabel.Font = new Font("Segoe UI", 12F);
            toxicsnipeInputLabel.Location = new Point(12, 46);
            toxicsnipeInputLabel.Name = "toxicsnipeInputLabel";
            toxicsnipeInputLabel.Size = new Size(248, 21);
            toxicsnipeInputLabel.TabIndex = 5;
            toxicsnipeInputLabel.Text = "Toxic Snipe Calculator Offpack Text";
            // 
            // outputBox
            // 
            outputBox.BackColor = SystemColors.Window;
            outputBox.Location = new Point(12, 145);
            outputBox.Name = "outputBox";
            outputBox.ReadOnly = true;
            outputBox.Size = new Size(345, 23);
            outputBox.TabIndex = 6;
            // 
            // SendTimeHeader
            // 
            SendTimeHeader.AutoSize = true;
            SendTimeHeader.Location = new Point(12, 127);
            SendTimeHeader.Name = "SendTimeHeader";
            SendTimeHeader.Size = new Size(65, 15);
            SendTimeHeader.TabIndex = 7;
            SendTimeHeader.Text = "Send Time:";
            // 
            // remainingTimeLabel
            // 
            remainingTimeLabel.AutoSize = true;
            remainingTimeLabel.Location = new Point(371, 148);
            remainingTimeLabel.Name = "remainingTimeLabel";
            remainingTimeLabel.Size = new Size(0, 15);
            remainingTimeLabel.TabIndex = 8;
            // 
            // ArrivalTimeHeader
            // 
            ArrivalTimeHeader.AutoSize = true;
            ArrivalTimeHeader.Location = new Point(12, 171);
            ArrivalTimeHeader.Name = "ArrivalTimeHeader";
            ArrivalTimeHeader.Size = new Size(73, 15);
            ArrivalTimeHeader.TabIndex = 9;
            ArrivalTimeHeader.Text = "Arrival Time:";
            // 
            // outputArrivalText
            // 
            outputArrivalText.BackColor = SystemColors.Window;
            outputArrivalText.Location = new Point(12, 189);
            outputArrivalText.Name = "outputArrivalText";
            outputArrivalText.ReadOnly = true;
            outputArrivalText.Size = new Size(345, 23);
            outputArrivalText.TabIndex = 10;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 223);
            Controls.Add(outputArrivalText);
            Controls.Add(ArrivalTimeHeader);
            Controls.Add(remainingTimeLabel);
            Controls.Add(SendTimeHeader);
            Controls.Add(outputBox);
            Controls.Add(toxicsnipeInputLabel);
            Controls.Add(importTextBox);
            Controls.Add(importLabel);
            Controls.Add(calculateButton);
            Name = "MainForm";
            Text = "Send Time Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calculateButton;
        private Label importLabel;
        private TextBox importTextBox;
        private ComboBox worldDropDown;
        private Label toxicsnipeInputLabel;
        private TextBox outputBox;
        private Label SendTimeHeader;
        private Label remainingTimeLabel;
        private Label ArrivalTimeHeader;
        private TextBox outputArrivalText;
    }
}
