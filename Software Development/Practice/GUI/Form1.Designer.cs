namespace GUI_Practice
{
    partial class FirstNumTB
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
            this.label1 = new System.Windows.Forms.Label();
            this.FirstNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SecondNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.calculation = new System.Windows.Forms.Label();
            this.calcbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter first number:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // FirstNum
            // 
            this.FirstNum.Location = new System.Drawing.Point(179, 10);
            this.FirstNum.Name = "FirstNum";
            this.FirstNum.Size = new System.Drawing.Size(100, 22);
            this.FirstNum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter second number:";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // SecondNum
            // 
            this.SecondNum.Location = new System.Drawing.Point(179, 64);
            this.SecondNum.Name = "SecondNum";
            this.SecondNum.Size = new System.Drawing.Size(100, 22);
            this.SecondNum.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sum";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // calculation
            // 
            this.calculation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.calculation.Location = new System.Drawing.Point(179, 121);
            this.calculation.Name = "calculation";
            this.calculation.Size = new System.Drawing.Size(100, 22);
            this.calculation.TabIndex = 5;
            // 
            // calcbutton
            // 
            this.calcbutton.Location = new System.Drawing.Point(98, 177);
            this.calcbutton.Name = "calcbutton";
            this.calcbutton.Size = new System.Drawing.Size(98, 23);
            this.calcbutton.TabIndex = 6;
            this.calcbutton.Text = "Calculate";
            this.calcbutton.UseVisualStyleBackColor = true;
            this.calcbutton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // FirstNumTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 239);
            this.Controls.Add(this.calcbutton);
            this.Controls.Add(this.calculation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SecondNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FirstNum);
            this.Controls.Add(this.label1);
            this.Name = "FirstNumTB";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FirstNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SecondNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label calculation;
        private System.Windows.Forms.Button calcbutton;
    }
}

