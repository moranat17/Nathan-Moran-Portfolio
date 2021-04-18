namespace Lab_7
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
            this.FVLabel = new System.Windows.Forms.Label();
            this.AIRLabel = new System.Windows.Forms.Label();
            this.NOYLabel = new System.Windows.Forms.Label();
            this.PVLabel = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.FVInput = new System.Windows.Forms.TextBox();
            this.AIRInput = new System.Windows.Forms.TextBox();
            this.NOYInput = new System.Windows.Forms.TextBox();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FVLabel
            // 
            this.FVLabel.AutoSize = true;
            this.FVLabel.Location = new System.Drawing.Point(23, 22);
            this.FVLabel.Name = "FVLabel";
            this.FVLabel.Size = new System.Drawing.Size(70, 13);
            this.FVLabel.TabIndex = 0;
            this.FVLabel.Text = "Future Value:";
            // 
            // AIRLabel
            // 
            this.AIRLabel.AutoSize = true;
            this.AIRLabel.Location = new System.Drawing.Point(23, 53);
            this.AIRLabel.Name = "AIRLabel";
            this.AIRLabel.Size = new System.Drawing.Size(107, 13);
            this.AIRLabel.TabIndex = 1;
            this.AIRLabel.Text = "Annual Interest Rate:";
            // 
            // NOYLabel
            // 
            this.NOYLabel.AutoSize = true;
            this.NOYLabel.Location = new System.Drawing.Point(23, 86);
            this.NOYLabel.Name = "NOYLabel";
            this.NOYLabel.Size = new System.Drawing.Size(64, 13);
            this.NOYLabel.TabIndex = 2;
            this.NOYLabel.Text = "No. of Year:";
            // 
            // PVLabel
            // 
            this.PVLabel.AutoSize = true;
            this.PVLabel.Location = new System.Drawing.Point(23, 126);
            this.PVLabel.Name = "PVLabel";
            this.PVLabel.Size = new System.Drawing.Size(76, 13);
            this.PVLabel.TabIndex = 3;
            this.PVLabel.Text = "Present Value:";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(106, 167);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 4;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // FVInput
            // 
            this.FVInput.Location = new System.Drawing.Point(165, 19);
            this.FVInput.Name = "FVInput";
            this.FVInput.Size = new System.Drawing.Size(100, 20);
            this.FVInput.TabIndex = 5;
            // 
            // AIRInput
            // 
            this.AIRInput.Location = new System.Drawing.Point(165, 50);
            this.AIRInput.Name = "AIRInput";
            this.AIRInput.Size = new System.Drawing.Size(100, 20);
            this.AIRInput.TabIndex = 6;
            // 
            // NOYInput
            // 
            this.NOYInput.Location = new System.Drawing.Point(165, 83);
            this.NOYInput.Name = "NOYInput";
            this.NOYInput.Size = new System.Drawing.Size(100, 20);
            this.NOYInput.TabIndex = 7;
            // 
            // OutputLabel
            // 
            this.OutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OutputLabel.Location = new System.Drawing.Point(165, 125);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(100, 20);
            this.OutputLabel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AcceptButton = this.CalculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 202);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.NOYInput);
            this.Controls.Add(this.AIRInput);
            this.Controls.Add(this.FVInput);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.PVLabel);
            this.Controls.Add(this.NOYLabel);
            this.Controls.Add(this.AIRLabel);
            this.Controls.Add(this.FVLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FVLabel;
        private System.Windows.Forms.Label AIRLabel;
        private System.Windows.Forms.Label NOYLabel;
        private System.Windows.Forms.Label PVLabel;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox FVInput;
        private System.Windows.Forms.TextBox AIRInput;
        private System.Windows.Forms.TextBox NOYInput;
        private System.Windows.Forms.Label OutputLabel;
    }
}

