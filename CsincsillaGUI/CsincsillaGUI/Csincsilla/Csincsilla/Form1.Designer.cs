namespace Csincsilla
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
            this.button1 = new System.Windows.Forms.Button();
            this.adatokszama = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.simogat = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.keresettnev = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.keresettadatok = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Simogatóba";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adatokszama
            // 
            this.adatokszama.AutoSize = true;
            this.adatokszama.Location = new System.Drawing.Point(73, 39);
            this.adatokszama.Name = "adatokszama";
            this.adatokszama.Size = new System.Drawing.Size(46, 17);
            this.adatokszama.TabIndex = 1;
            this.adatokszama.Text = "label1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 275);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(522, 316);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // simogat
            // 
            this.simogat.AutoSize = true;
            this.simogat.Location = new System.Drawing.Point(283, 142);
            this.simogat.Name = "simogat";
            this.simogat.Size = new System.Drawing.Size(46, 17);
            this.simogat.TabIndex = 3;
            this.simogat.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Keresett csincsilla";
            // 
            // keresettnev
            // 
            this.keresettnev.Location = new System.Drawing.Point(271, 195);
            this.keresettnev.Name = "keresettnev";
            this.keresettnev.Size = new System.Drawing.Size(283, 22);
            this.keresettnev.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(629, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Keresés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // keresettadatok
            // 
            this.keresettadatok.AutoSize = true;
            this.keresettadatok.Location = new System.Drawing.Point(617, 262);
            this.keresettadatok.Name = "keresettadatok";
            this.keresettadatok.Size = new System.Drawing.Size(46, 17);
            this.keresettadatok.TabIndex = 7;
            this.keresettadatok.Text = "label2";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(616, 506);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(217, 60);
            this.button3.TabIndex = 8;
            this.button3.Text = "Adatok simogato.txt-be";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 603);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.keresettadatok);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.keresettnev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.simogat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.adatokszama);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Csincsillák";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label adatokszama;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label simogat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox keresettnev;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label keresettadatok;
        private System.Windows.Forms.Button button3;
    }
}

