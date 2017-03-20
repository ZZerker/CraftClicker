namespace TimerTest
{
    partial class CraftClicker
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
            if(disposing && (components != null))
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
            this.startButton = new System.Windows.Forms.Button();
            this.intervalLabel = new System.Windows.Forms.Label();
            this.w = new System.Windows.Forms.Label();
            this.secondsLabel = new System.Windows.Forms.Label();
            this.minuteLabel = new System.Windows.Forms.Label();
            this.secIntervalComboBox = new System.Windows.Forms.ComboBox();
            this.minInternvalComboBox = new System.Windows.Forms.ComboBox();
            this.secDelayComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fixLocRadioButton = new System.Windows.Forms.RadioButton();
            this.mouseLocRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.iterationsComboBox = new System.Windows.Forms.ComboBox();
            this.fixNumberOfIterationsRadioButton = new System.Windows.Forms.RadioButton();
            this.infiniteIterationsRadioButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.assignButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(363, 255);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(116, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButtonClick);
            // 
            // intervalLabel
            // 
            this.intervalLabel.AutoSize = true;
            this.intervalLabel.Location = new System.Drawing.Point(13, 13);
            this.intervalLabel.Name = "intervalLabel";
            this.intervalLabel.Size = new System.Drawing.Size(48, 13);
            this.intervalLabel.TabIndex = 1;
            this.intervalLabel.Text = "Interval: ";
            // 
            // w
            // 
            this.w.AutoSize = true;
            this.w.Location = new System.Drawing.Point(13, 44);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(80, 13);
            this.w.TabIndex = 3;
            this.w.Text = "Random Delay:";
            // 
            // secondsLabel
            // 
            this.secondsLabel.AutoSize = true;
            this.secondsLabel.Location = new System.Drawing.Point(328, 13);
            this.secondsLabel.Name = "secondsLabel";
            this.secondsLabel.Size = new System.Drawing.Size(29, 13);
            this.secondsLabel.TabIndex = 4;
            this.secondsLabel.Text = "Sec.";
            // 
            // minuteLabel
            // 
            this.minuteLabel.AutoSize = true;
            this.minuteLabel.Location = new System.Drawing.Point(177, 13);
            this.minuteLabel.Name = "minuteLabel";
            this.minuteLabel.Size = new System.Drawing.Size(27, 13);
            this.minuteLabel.TabIndex = 6;
            this.minuteLabel.Text = "Min.";
            // 
            // secIntervalComboBox
            // 
            this.secIntervalComboBox.FormattingEnabled = true;
            this.secIntervalComboBox.Location = new System.Drawing.Point(363, 10);
            this.secIntervalComboBox.Name = "secIntervalComboBox";
            this.secIntervalComboBox.Size = new System.Drawing.Size(116, 21);
            this.secIntervalComboBox.TabIndex = 7;
            // 
            // minInternvalComboBox
            // 
            this.minInternvalComboBox.FormattingEnabled = true;
            this.minInternvalComboBox.Location = new System.Drawing.Point(210, 10);
            this.minInternvalComboBox.Name = "minInternvalComboBox";
            this.minInternvalComboBox.Size = new System.Drawing.Size(105, 21);
            this.minInternvalComboBox.TabIndex = 8;
            // 
            // secDelayComboBox
            // 
            this.secDelayComboBox.FormattingEnabled = true;
            this.secDelayComboBox.Location = new System.Drawing.Point(363, 41);
            this.secDelayComboBox.Name = "secDelayComboBox";
            this.secDelayComboBox.Size = new System.Drawing.Size(116, 21);
            this.secDelayComboBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Sec.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fixLocRadioButton);
            this.groupBox1.Controls.Add(this.mouseLocRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(16, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 72);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Click Target";
            // 
            // fixLocRadioButton
            // 
            this.fixLocRadioButton.AutoSize = true;
            this.fixLocRadioButton.Location = new System.Drawing.Point(7, 44);
            this.fixLocRadioButton.Name = "fixLocRadioButton";
            this.fixLocRadioButton.Size = new System.Drawing.Size(334, 17);
            this.fixLocRadioButton.TabIndex = 1;
            this.fixLocRadioButton.TabStop = true;
            this.fixLocRadioButton.Text = "Use mouselocation when timer started (mouse independent static)";
            this.fixLocRadioButton.UseVisualStyleBackColor = true;
            // 
            // mouseLocRadioButton
            // 
            this.mouseLocRadioButton.AutoSize = true;
            this.mouseLocRadioButton.Location = new System.Drawing.Point(7, 20);
            this.mouseLocRadioButton.Name = "mouseLocRadioButton";
            this.mouseLocRadioButton.Size = new System.Drawing.Size(115, 17);
            this.mouseLocRadioButton.TabIndex = 0;
            this.mouseLocRadioButton.TabStop = true;
            this.mouseLocRadioButton.Text = "Use mouselocation";
            this.mouseLocRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.iterationsComboBox);
            this.groupBox2.Controls.Add(this.fixNumberOfIterationsRadioButton);
            this.groupBox2.Controls.Add(this.infiniteIterationsRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(16, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(463, 72);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Interations";
            // 
            // iterationsComboBox
            // 
            this.iterationsComboBox.FormattingEnabled = true;
            this.iterationsComboBox.Location = new System.Drawing.Point(347, 43);
            this.iterationsComboBox.Name = "iterationsComboBox";
            this.iterationsComboBox.Size = new System.Drawing.Size(110, 21);
            this.iterationsComboBox.TabIndex = 2;
            // 
            // fixNumberOfIterationsRadioButton
            // 
            this.fixNumberOfIterationsRadioButton.AutoSize = true;
            this.fixNumberOfIterationsRadioButton.Location = new System.Drawing.Point(7, 44);
            this.fixNumberOfIterationsRadioButton.Name = "fixNumberOfIterationsRadioButton";
            this.fixNumberOfIterationsRadioButton.Size = new System.Drawing.Size(123, 17);
            this.fixNumberOfIterationsRadioButton.TabIndex = 1;
            this.fixNumberOfIterationsRadioButton.TabStop = true;
            this.fixNumberOfIterationsRadioButton.Text = "Number of Iterations:";
            this.fixNumberOfIterationsRadioButton.UseVisualStyleBackColor = true;
            // 
            // infiniteIterationsRadioButton
            // 
            this.infiniteIterationsRadioButton.AutoSize = true;
            this.infiniteIterationsRadioButton.Location = new System.Drawing.Point(7, 20);
            this.infiniteIterationsRadioButton.Name = "infiniteIterationsRadioButton";
            this.infiniteIterationsRadioButton.Size = new System.Drawing.Size(102, 17);
            this.infiniteIterationsRadioButton.TabIndex = 0;
            this.infiniteIterationsRadioButton.TabStop = true;
            this.infiniteIterationsRadioButton.Text = "Infinite Iterations";
            this.infiniteIterationsRadioButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Assign \'Start Timer\' Hotkey: ";
            // 
            // assignButton
            // 
            this.assignButton.Location = new System.Drawing.Point(363, 226);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(116, 23);
            this.assignButton.TabIndex = 15;
            this.assignButton.Text = "Assign";
            this.assignButton.UseVisualStyleBackColor = true;
            this.assignButton.Click += new System.EventHandler(this.assignButton_Click);
            // 
            // CraftClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 291);
            this.Controls.Add(this.assignButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.secDelayComboBox);
            this.Controls.Add(this.minInternvalComboBox);
            this.Controls.Add(this.secIntervalComboBox);
            this.Controls.Add(this.minuteLabel);
            this.Controls.Add(this.secondsLabel);
            this.Controls.Add(this.w);
            this.Controls.Add(this.intervalLabel);
            this.Controls.Add(this.startButton);
            this.Name = "CraftClicker";
            this.Text = "CraftClicker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label intervalLabel;
        private System.Windows.Forms.Label w;
        private System.Windows.Forms.Label secondsLabel;
        private System.Windows.Forms.Label minuteLabel;
        private System.Windows.Forms.ComboBox secIntervalComboBox;
        private System.Windows.Forms.ComboBox minInternvalComboBox;
        private System.Windows.Forms.ComboBox secDelayComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton fixLocRadioButton;
        private System.Windows.Forms.RadioButton mouseLocRadioButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox iterationsComboBox;
        private System.Windows.Forms.RadioButton fixNumberOfIterationsRadioButton;
        private System.Windows.Forms.RadioButton infiniteIterationsRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button assignButton;
    }
}

