namespace KeyboardSpeedTest
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.inputText = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.trueLabel = new System.Windows.Forms.Label();
            this.trueCount = new System.Windows.Forms.Label();
            this.falseLabel = new System.Windows.Forms.Label();
            this.falseCount = new System.Windows.Forms.Label();
            this.wordArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // inputText
            // 
            this.inputText.Location = new System.Drawing.Point(12, 99);
            this.inputText.Name = "inputText";
            this.inputText.Size = new System.Drawing.Size(225, 23);
            this.inputText.TabIndex = 0;
            this.inputText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyDown);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(86, 128);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 2;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // trueLabel
            // 
            this.trueLabel.AutoSize = true;
            this.trueLabel.Location = new System.Drawing.Point(12, 163);
            this.trueLabel.Name = "trueLabel";
            this.trueLabel.Size = new System.Drawing.Size(69, 15);
            this.trueLabel.TabIndex = 3;
            this.trueLabel.Text = "True Words:";
            // 
            // trueCount
            // 
            this.trueCount.AutoSize = true;
            this.trueCount.Location = new System.Drawing.Point(87, 163);
            this.trueCount.Name = "trueCount";
            this.trueCount.Size = new System.Drawing.Size(0, 15);
            this.trueCount.TabIndex = 4;
            // 
            // falseLabel
            // 
            this.falseLabel.AutoSize = true;
            this.falseLabel.Location = new System.Drawing.Point(161, 163);
            this.falseLabel.Name = "falseLabel";
            this.falseLabel.Size = new System.Drawing.Size(76, 15);
            this.falseLabel.TabIndex = 5;
            this.falseLabel.Text = "False Words: ";
            // 
            // falseCount
            // 
            this.falseCount.AutoSize = true;
            this.falseCount.Location = new System.Drawing.Point(240, 163);
            this.falseCount.Name = "falseCount";
            this.falseCount.Size = new System.Drawing.Size(0, 15);
            this.falseCount.TabIndex = 6;
            // 
            // wordArea
            // 
            this.wordArea.BackColor = System.Drawing.Color.White;
            this.wordArea.Location = new System.Drawing.Point(12, 9);
            this.wordArea.Name = "wordArea";
            this.wordArea.Size = new System.Drawing.Size(225, 87);
            this.wordArea.TabIndex = 0;
            this.wordArea.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 201);
            this.Controls.Add(this.wordArea);
            this.Controls.Add(this.falseCount);
            this.Controls.Add(this.falseLabel);
            this.Controls.Add(this.trueCount);
            this.Controls.Add(this.trueLabel);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.inputText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private TextBox inputText;
        private Button StartButton;
        private Label trueLabel;
        private Label trueCount;
        private Label falseLabel;
        private Label falseCount;
        private Label wordArea;
    }
}