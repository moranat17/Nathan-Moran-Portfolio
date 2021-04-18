namespace Lab_6
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
            this.calcbutton = new System.Windows.Forms.Button();
            this.enterlabel = new System.Windows.Forms.Label();
            this.gradelabel = new System.Windows.Forms.Label();
            this.gradeoutputlabel = new System.Windows.Forms.Label();
            this.wordstyped = new System.Windows.Forms.TextBox();
            this.welcomelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calcbutton
            // 
            this.calcbutton.Location = new System.Drawing.Point(137, 167);
            this.calcbutton.Name = "calcbutton";
            this.calcbutton.Size = new System.Drawing.Size(75, 23);
            this.calcbutton.TabIndex = 0;
            this.calcbutton.Text = "Calculate";
            this.calcbutton.UseVisualStyleBackColor = true;
            this.calcbutton.Click += new System.EventHandler(this.Calcbutton_Click);
            // 
            // enterlabel
            // 
            this.enterlabel.AutoSize = true;
            this.enterlabel.Location = new System.Drawing.Point(47, 75);
            this.enterlabel.Name = "enterlabel";
            this.enterlabel.Size = new System.Drawing.Size(102, 13);
            this.enterlabel.TabIndex = 1;
            this.enterlabel.Text = "Enter Words Typed:";
            // 
            // gradelabel
            // 
            this.gradelabel.AutoSize = true;
            this.gradelabel.Location = new System.Drawing.Point(110, 120);
            this.gradelabel.Name = "gradelabel";
            this.gradelabel.Size = new System.Drawing.Size(39, 13);
            this.gradelabel.TabIndex = 2;
            this.gradelabel.Text = "Grade:";
            // 
            // gradeoutputlabel
            // 
            this.gradeoutputlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gradeoutputlabel.Location = new System.Drawing.Point(188, 119);
            this.gradeoutputlabel.Name = "gradeoutputlabel";
            this.gradeoutputlabel.Size = new System.Drawing.Size(100, 23);
            this.gradeoutputlabel.TabIndex = 3;
            // 
            // wordstyped
            // 
            this.wordstyped.Location = new System.Drawing.Point(188, 72);
            this.wordstyped.Name = "wordstyped";
            this.wordstyped.Size = new System.Drawing.Size(100, 20);
            this.wordstyped.TabIndex = 4;
            // 
            // welcomelabel
            // 
            this.welcomelabel.AutoSize = true;
            this.welcomelabel.Location = new System.Drawing.Point(92, 27);
            this.welcomelabel.Name = "welcomelabel";
            this.welcomelabel.Size = new System.Drawing.Size(164, 13);
            this.welcomelabel.TabIndex = 5;
            this.welcomelabel.Text = "Welcome to the Grade Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 225);
            this.Controls.Add(this.welcomelabel);
            this.Controls.Add(this.wordstyped);
            this.Controls.Add(this.gradeoutputlabel);
            this.Controls.Add(this.gradelabel);
            this.Controls.Add(this.enterlabel);
            this.Controls.Add(this.calcbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcbutton;
        private System.Windows.Forms.Label enterlabel;
        private System.Windows.Forms.Label gradelabel;
        private System.Windows.Forms.Label gradeoutputlabel;
        private System.Windows.Forms.TextBox wordstyped;
        private System.Windows.Forms.Label welcomelabel;
    }
}

