namespace Lab2
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
            this.pricelbl = new System.Windows.Forms.Label();
            this.fifteenlbl = new System.Windows.Forms.Label();
            this.eighteenlbl = new System.Windows.Forms.Label();
            this.twentylbl = new System.Windows.Forms.Label();
            this.pricetb = new System.Windows.Forms.TextBox();
            this.calcbtn = new System.Windows.Forms.Button();
            this.fifteencalc = new System.Windows.Forms.Label();
            this.eighteencalc = new System.Windows.Forms.Label();
            this.twentycalc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pricelbl
            // 
            this.pricelbl.AutoSize = true;
            this.pricelbl.Location = new System.Drawing.Point(22, 9);
            this.pricelbl.Name = "pricelbl";
            this.pricelbl.Size = new System.Drawing.Size(131, 17);
            this.pricelbl.TabIndex = 0;
            this.pricelbl.Text = "Enter price of meal:";
            this.pricelbl.Click += new System.EventHandler(this.Label1_Click);
            // 
            // fifteenlbl
            // 
            this.fifteenlbl.AutoSize = true;
            this.fifteenlbl.Location = new System.Drawing.Point(117, 50);
            this.fifteenlbl.Name = "fifteenlbl";
            this.fifteenlbl.Size = new System.Drawing.Size(36, 17);
            this.fifteenlbl.TabIndex = 1;
            this.fifteenlbl.Text = "15%";
            // 
            // eighteenlbl
            // 
            this.eighteenlbl.AutoSize = true;
            this.eighteenlbl.Location = new System.Drawing.Point(117, 88);
            this.eighteenlbl.Name = "eighteenlbl";
            this.eighteenlbl.Size = new System.Drawing.Size(36, 17);
            this.eighteenlbl.TabIndex = 2;
            this.eighteenlbl.Text = "18%";
            // 
            // twentylbl
            // 
            this.twentylbl.AutoSize = true;
            this.twentylbl.Location = new System.Drawing.Point(117, 129);
            this.twentylbl.Name = "twentylbl";
            this.twentylbl.Size = new System.Drawing.Size(36, 17);
            this.twentylbl.TabIndex = 3;
            this.twentylbl.Text = "20%";
            // 
            // pricetb
            // 
            this.pricetb.Location = new System.Drawing.Point(188, 6);
            this.pricetb.Name = "pricetb";
            this.pricetb.Size = new System.Drawing.Size(100, 22);
            this.pricetb.TabIndex = 4;
            // 
            // calcbtn
            // 
            this.calcbtn.Location = new System.Drawing.Point(117, 175);
            this.calcbtn.Name = "calcbtn";
            this.calcbtn.Size = new System.Drawing.Size(120, 30);
            this.calcbtn.TabIndex = 5;
            this.calcbtn.Text = "Calculate Tip";
            this.calcbtn.UseVisualStyleBackColor = true;
            this.calcbtn.Click += new System.EventHandler(this.Calcbtn_Click);
            // 
            // fifteencalc
            // 
            this.fifteencalc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fifteencalc.Location = new System.Drawing.Point(188, 49);
            this.fifteencalc.Name = "fifteencalc";
            this.fifteencalc.Size = new System.Drawing.Size(100, 22);
            this.fifteencalc.TabIndex = 6;
            // 
            // eighteencalc
            // 
            this.eighteencalc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eighteencalc.Location = new System.Drawing.Point(188, 87);
            this.eighteencalc.Name = "eighteencalc";
            this.eighteencalc.Size = new System.Drawing.Size(100, 22);
            this.eighteencalc.TabIndex = 7;
            // 
            // twentycalc
            // 
            this.twentycalc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.twentycalc.Location = new System.Drawing.Point(188, 128);
            this.twentycalc.Name = "twentycalc";
            this.twentycalc.Size = new System.Drawing.Size(100, 22);
            this.twentycalc.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 234);
            this.Controls.Add(this.twentycalc);
            this.Controls.Add(this.eighteencalc);
            this.Controls.Add(this.fifteencalc);
            this.Controls.Add(this.calcbtn);
            this.Controls.Add(this.pricetb);
            this.Controls.Add(this.twentylbl);
            this.Controls.Add(this.eighteenlbl);
            this.Controls.Add(this.fifteenlbl);
            this.Controls.Add(this.pricelbl);
            this.Name = "Form1";
            this.Text = "Lab 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pricelbl;
        private System.Windows.Forms.Label fifteenlbl;
        private System.Windows.Forms.Label eighteenlbl;
        private System.Windows.Forms.Label twentylbl;
        private System.Windows.Forms.TextBox pricetb;
        private System.Windows.Forms.Button calcbtn;
        private System.Windows.Forms.Label fifteencalc;
        private System.Windows.Forms.Label eighteencalc;
        private System.Windows.Forms.Label twentycalc;
    }
}

