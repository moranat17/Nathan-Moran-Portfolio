namespace Lab_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.radiuslabel = new System.Windows.Forms.Label();
            this.radiusinput = new System.Windows.Forms.TextBox();
            this.diameterlabel = new System.Windows.Forms.Label();
            this.surfacearealabel = new System.Windows.Forms.Label();
            this.volumelabel = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.circle2 = new System.Windows.Forms.PictureBox();
            this.circle1 = new System.Windows.Forms.PictureBox();
            this.diameter = new System.Windows.Forms.Label();
            this.surfacearea = new System.Windows.Forms.Label();
            this.volume = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.circle2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.circle1)).BeginInit();
            this.SuspendLayout();
            // 
            // radiuslabel
            // 
            this.radiuslabel.AutoSize = true;
            this.radiuslabel.Location = new System.Drawing.Point(165, 65);
            this.radiuslabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.radiuslabel.Name = "radiuslabel";
            this.radiuslabel.Size = new System.Drawing.Size(90, 13);
            this.radiuslabel.TabIndex = 0;
            this.radiuslabel.Text = "Radius of sphere:";
            // 
            // radiusinput
            // 
            this.radiusinput.Location = new System.Drawing.Point(259, 62);
            this.radiusinput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radiusinput.Name = "radiusinput";
            this.radiusinput.Size = new System.Drawing.Size(99, 20);
            this.radiusinput.TabIndex = 1;
            // 
            // diameterlabel
            // 
            this.diameterlabel.AutoSize = true;
            this.diameterlabel.Location = new System.Drawing.Point(31, 219);
            this.diameterlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.diameterlabel.Name = "diameterlabel";
            this.diameterlabel.Size = new System.Drawing.Size(49, 13);
            this.diameterlabel.TabIndex = 2;
            this.diameterlabel.Text = "Diameter";
            // 
            // surfacearealabel
            // 
            this.surfacearealabel.AutoSize = true;
            this.surfacearealabel.Location = new System.Drawing.Point(11, 260);
            this.surfacearealabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.surfacearealabel.Name = "surfacearealabel";
            this.surfacearealabel.Size = new System.Drawing.Size(69, 13);
            this.surfacearealabel.TabIndex = 3;
            this.surfacearealabel.Text = "Surface Area";
            this.surfacearealabel.Click += new System.EventHandler(this.Label3_Click);
            // 
            // volumelabel
            // 
            this.volumelabel.AutoSize = true;
            this.volumelabel.Location = new System.Drawing.Point(38, 298);
            this.volumelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.volumelabel.Name = "volumelabel";
            this.volumelabel.Size = new System.Drawing.Size(42, 13);
            this.volumelabel.TabIndex = 4;
            this.volumelabel.Text = "Volume";
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(272, 97);
            this.calculate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(73, 22);
            this.calculate.TabIndex = 5;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // circle2
            // 
            this.circle2.Image = ((System.Drawing.Image)(resources.GetObject("circle2.Image")));
            this.circle2.Location = new System.Drawing.Point(223, 200);
            this.circle2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.circle2.Name = "circle2";
            this.circle2.Size = new System.Drawing.Size(150, 150);
            this.circle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circle2.TabIndex = 6;
            this.circle2.TabStop = false;
            // 
            // circle1
            // 
            this.circle1.Image = ((System.Drawing.Image)(resources.GetObject("circle1.Image")));
            this.circle1.Location = new System.Drawing.Point(11, 11);
            this.circle1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.circle1.Name = "circle1";
            this.circle1.Size = new System.Drawing.Size(150, 150);
            this.circle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.circle1.TabIndex = 7;
            this.circle1.TabStop = false;
            // 
            // diameter
            // 
            this.diameter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.diameter.Location = new System.Drawing.Point(111, 218);
            this.diameter.Name = "diameter";
            this.diameter.Size = new System.Drawing.Size(70, 22);
            this.diameter.TabIndex = 8;
            // 
            // surfacearea
            // 
            this.surfacearea.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surfacearea.Location = new System.Drawing.Point(111, 259);
            this.surfacearea.Name = "surfacearea";
            this.surfacearea.Size = new System.Drawing.Size(70, 22);
            this.surfacearea.TabIndex = 9;
            // 
            // volume
            // 
            this.volume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.volume.Location = new System.Drawing.Point(111, 297);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(70, 22);
            this.volume.TabIndex = 10;
            // 
            // Form1
            // 
            this.AcceptButton = this.calculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.surfacearea);
            this.Controls.Add(this.diameter);
            this.Controls.Add(this.circle1);
            this.Controls.Add(this.circle2);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.volumelabel);
            this.Controls.Add(this.surfacearealabel);
            this.Controls.Add(this.diameterlabel);
            this.Controls.Add(this.radiusinput);
            this.Controls.Add(this.radiuslabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Lab 3";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.circle2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.circle1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label radiuslabel;
        private System.Windows.Forms.TextBox radiusinput;
        private System.Windows.Forms.Label diameterlabel;
        private System.Windows.Forms.Label surfacearealabel;
        private System.Windows.Forms.Label volumelabel;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.PictureBox circle2;
        private System.Windows.Forms.PictureBox circle1;
        private System.Windows.Forms.Label diameter;
        private System.Windows.Forms.Label surfacearea;
        private System.Windows.Forms.Label volume;
    }
}

