namespace Lab_4
{
    partial class Lab4
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
            this.gpalabel = new System.Windows.Forms.Label();
            this.admtestlabel = new System.Windows.Forms.Label();
            this.gpatextbox = new System.Windows.Forms.TextBox();
            this.admtesttextbox = new System.Windows.Forms.TextBox();
            this.admitbutton = new System.Windows.Forms.Button();
            this.answerlabel = new System.Windows.Forms.Label();
            this.acceptcount = new System.Windows.Forms.Label();
            this.denycount = new System.Windows.Forms.Label();
            this.appstatus = new System.Windows.Forms.Label();
            this.acceptstudents = new System.Windows.Forms.Label();
            this.denystudents = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gpalabel
            // 
            this.gpalabel.AutoSize = true;
            this.gpalabel.Location = new System.Drawing.Point(120, 38);
            this.gpalabel.Name = "gpalabel";
            this.gpalabel.Size = new System.Drawing.Size(41, 17);
            this.gpalabel.TabIndex = 0;
            this.gpalabel.Text = "GPA:";
            // 
            // admtestlabel
            // 
            this.admtestlabel.AutoSize = true;
            this.admtestlabel.Location = new System.Drawing.Point(12, 86);
            this.admtestlabel.Name = "admtestlabel";
            this.admtestlabel.Size = new System.Drawing.Size(149, 17);
            this.admtestlabel.TabIndex = 1;
            this.admtestlabel.Text = "Admission Test Score:";
            // 
            // gpatextbox
            // 
            this.gpatextbox.Location = new System.Drawing.Point(192, 34);
            this.gpatextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gpatextbox.Name = "gpatextbox";
            this.gpatextbox.Size = new System.Drawing.Size(100, 22);
            this.gpatextbox.TabIndex = 2;
            // 
            // admtesttextbox
            // 
            this.admtesttextbox.Location = new System.Drawing.Point(192, 82);
            this.admtesttextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admtesttextbox.Name = "admtesttextbox";
            this.admtesttextbox.Size = new System.Drawing.Size(100, 22);
            this.admtesttextbox.TabIndex = 3;
            // 
            // admitbutton
            // 
            this.admitbutton.Location = new System.Drawing.Point(123, 125);
            this.admitbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.admitbutton.Name = "admitbutton";
            this.admitbutton.Size = new System.Drawing.Size(75, 30);
            this.admitbutton.TabIndex = 4;
            this.admitbutton.Text = "Admit?";
            this.admitbutton.UseVisualStyleBackColor = true;
            this.admitbutton.Click += new System.EventHandler(this.Admitbutton_Click);
            // 
            // answerlabel
            // 
            this.answerlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.answerlabel.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.answerlabel.Location = new System.Drawing.Point(202, 173);
            this.answerlabel.Name = "answerlabel";
            this.answerlabel.Size = new System.Drawing.Size(101, 24);
            this.answerlabel.TabIndex = 5;
            // 
            // acceptcount
            // 
            this.acceptcount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.acceptcount.Location = new System.Drawing.Point(202, 206);
            this.acceptcount.Name = "acceptcount";
            this.acceptcount.Size = new System.Drawing.Size(101, 24);
            this.acceptcount.TabIndex = 6;
            // 
            // denycount
            // 
            this.denycount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.denycount.Location = new System.Drawing.Point(202, 241);
            this.denycount.Name = "denycount";
            this.denycount.Size = new System.Drawing.Size(101, 24);
            this.denycount.TabIndex = 7;
            // 
            // appstatus
            // 
            this.appstatus.AutoSize = true;
            this.appstatus.Location = new System.Drawing.Point(36, 174);
            this.appstatus.Name = "appstatus";
            this.appstatus.Size = new System.Drawing.Size(125, 17);
            this.appstatus.TabIndex = 8;
            this.appstatus.Text = "Application Status:";
            // 
            // acceptstudents
            // 
            this.acceptstudents.AutoSize = true;
            this.acceptstudents.Location = new System.Drawing.Point(30, 207);
            this.acceptstudents.Name = "acceptstudents";
            this.acceptstudents.Size = new System.Drawing.Size(131, 17);
            this.acceptstudents.TabIndex = 9;
            this.acceptstudents.Text = "Accepted Students:";
            // 
            // denystudents
            // 
            this.denystudents.AutoSize = true;
            this.denystudents.Location = new System.Drawing.Point(33, 242);
            this.denystudents.Name = "denystudents";
            this.denystudents.Size = new System.Drawing.Size(128, 17);
            this.denystudents.TabIndex = 10;
            this.denystudents.Text = "Rejected Students:";
            // 
            // Lab4
            // 
            this.AcceptButton = this.admitbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 274);
            this.Controls.Add(this.denystudents);
            this.Controls.Add(this.acceptstudents);
            this.Controls.Add(this.appstatus);
            this.Controls.Add(this.denycount);
            this.Controls.Add(this.acceptcount);
            this.Controls.Add(this.answerlabel);
            this.Controls.Add(this.admitbutton);
            this.Controls.Add(this.admtesttextbox);
            this.Controls.Add(this.gpatextbox);
            this.Controls.Add(this.admtestlabel);
            this.Controls.Add(this.gpalabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Lab4";
            this.Text = "Lab 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gpalabel;
        private System.Windows.Forms.Label admtestlabel;
        private System.Windows.Forms.TextBox gpatextbox;
        private System.Windows.Forms.TextBox admtesttextbox;
        private System.Windows.Forms.Button admitbutton;
        private System.Windows.Forms.Label answerlabel;
        private System.Windows.Forms.Label acceptcount;
        private System.Windows.Forms.Label denycount;
        private System.Windows.Forms.Label appstatus;
        private System.Windows.Forms.Label acceptstudents;
        private System.Windows.Forms.Label denystudents;
    }
}

