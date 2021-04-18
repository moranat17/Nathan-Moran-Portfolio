namespace Prog2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.datelabel = new System.Windows.Forms.Label();
            this.lettertext = new System.Windows.Forms.TextBox();
            this.dateoutputlabel = new System.Windows.Forms.Label();
            this.timelabel = new System.Windows.Forms.Label();
            this.timeoutputlabel = new System.Windows.Forms.Label();
            this.hourstext = new System.Windows.Forms.TextBox();
            this.welcomelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter first letter of last name (uppercase):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter total credit hours:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "When Do I Register?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // datelabel
            // 
            this.datelabel.AutoSize = true;
            this.datelabel.Location = new System.Drawing.Point(118, 229);
            this.datelabel.Name = "datelabel";
            this.datelabel.Size = new System.Drawing.Size(30, 13);
            this.datelabel.TabIndex = 3;
            this.datelabel.Text = "Date";
            // 
            // lettertext
            // 
            this.lettertext.Location = new System.Drawing.Point(267, 123);
            this.lettertext.Name = "lettertext";
            this.lettertext.Size = new System.Drawing.Size(100, 20);
            this.lettertext.TabIndex = 4;
            // 
            // dateoutputlabel
            // 
            this.dateoutputlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dateoutputlabel.Location = new System.Drawing.Point(68, 259);
            this.dateoutputlabel.Name = "dateoutputlabel";
            this.dateoutputlabel.Size = new System.Drawing.Size(131, 23);
            this.dateoutputlabel.TabIndex = 5;
            // 
            // timelabel
            // 
            this.timelabel.AutoSize = true;
            this.timelabel.Location = new System.Drawing.Point(297, 229);
            this.timelabel.Name = "timelabel";
            this.timelabel.Size = new System.Drawing.Size(30, 13);
            this.timelabel.TabIndex = 6;
            this.timelabel.Text = "Time";
            // 
            // timeoutputlabel
            // 
            this.timeoutputlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeoutputlabel.Location = new System.Drawing.Point(267, 259);
            this.timeoutputlabel.Name = "timeoutputlabel";
            this.timeoutputlabel.Size = new System.Drawing.Size(100, 23);
            this.timeoutputlabel.TabIndex = 7;
            // 
            // hourstext
            // 
            this.hourstext.Location = new System.Drawing.Point(267, 82);
            this.hourstext.Name = "hourstext";
            this.hourstext.Size = new System.Drawing.Size(100, 20);
            this.hourstext.TabIndex = 8;
            // 
            // welcomelabel
            // 
            this.welcomelabel.AutoSize = true;
            this.welcomelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.welcomelabel.Location = new System.Drawing.Point(118, 22);
            this.welcomelabel.Name = "welcomelabel";
            this.welcomelabel.Size = new System.Drawing.Size(227, 17);
            this.welcomelabel.TabIndex = 9;
            this.welcomelabel.Text = "Welcome to the Registration Portal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 316);
            this.Controls.Add(this.welcomelabel);
            this.Controls.Add(this.hourstext);
            this.Controls.Add(this.timeoutputlabel);
            this.Controls.Add(this.timelabel);
            this.Controls.Add(this.dateoutputlabel);
            this.Controls.Add(this.lettertext);
            this.Controls.Add(this.datelabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label datelabel;
        private System.Windows.Forms.TextBox lettertext;
        private System.Windows.Forms.Label dateoutputlabel;
        private System.Windows.Forms.Label timelabel;
        private System.Windows.Forms.Label timeoutputlabel;
        private System.Windows.Forms.TextBox hourstext;
        private System.Windows.Forms.Label welcomelabel;
    }
}

