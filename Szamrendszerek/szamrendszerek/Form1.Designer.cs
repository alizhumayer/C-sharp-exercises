namespace szamrendszerek
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_2 = new System.Windows.Forms.RadioButton();
            this.rb_10 = new System.Windows.Forms.RadioButton();
            this.rb_16 = new System.Windows.Forms.RadioButton();
            this.l_2 = new System.Windows.Forms.Label();
            this.l_10 = new System.Windows.Forms.Label();
            this.l_16 = new System.Windows.Forms.Label();
            this.btn_szamol = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_16);
            this.groupBox1.Controls.Add(this.rb_10);
            this.groupBox1.Controls.Add(this.rb_2);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 103);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Miből";
            // 
            // rb_2
            // 
            this.rb_2.AutoSize = true;
            this.rb_2.Location = new System.Drawing.Point(7, 20);
            this.rb_2.Name = "rb_2";
            this.rb_2.Size = new System.Drawing.Size(55, 17);
            this.rb_2.TabIndex = 0;
            this.rb_2.Text = "Kettes";
            this.rb_2.UseVisualStyleBackColor = true;
            // 
            // rb_10
            // 
            this.rb_10.AutoSize = true;
            this.rb_10.Checked = true;
            this.rb_10.Location = new System.Drawing.Point(7, 44);
            this.rb_10.Name = "rb_10";
            this.rb_10.Size = new System.Drawing.Size(50, 17);
            this.rb_10.TabIndex = 1;
            this.rb_10.TabStop = true;
            this.rb_10.Text = "Tizes";
            this.rb_10.UseVisualStyleBackColor = true;
            // 
            // rb_16
            // 
            this.rb_16.AutoSize = true;
            this.rb_16.Location = new System.Drawing.Point(7, 68);
            this.rb_16.Name = "rb_16";
            this.rb_16.Size = new System.Drawing.Size(77, 17);
            this.rb_16.TabIndex = 2;
            this.rb_16.Text = "Tizenhatos";
            this.rb_16.UseVisualStyleBackColor = true;
            // 
            // l_2
            // 
            this.l_2.AutoSize = true;
            this.l_2.Location = new System.Drawing.Point(158, 33);
            this.l_2.Name = "l_2";
            this.l_2.Size = new System.Drawing.Size(13, 13);
            this.l_2.TabIndex = 1;
            this.l_2.Text = "2";
            // 
            // l_10
            // 
            this.l_10.AutoSize = true;
            this.l_10.Location = new System.Drawing.Point(161, 57);
            this.l_10.Name = "l_10";
            this.l_10.Size = new System.Drawing.Size(19, 13);
            this.l_10.TabIndex = 2;
            this.l_10.Text = "10";
            // 
            // l_16
            // 
            this.l_16.AutoSize = true;
            this.l_16.Location = new System.Drawing.Point(159, 81);
            this.l_16.Name = "l_16";
            this.l_16.Size = new System.Drawing.Size(19, 13);
            this.l_16.TabIndex = 3;
            this.l_16.Text = "16";
            // 
            // btn_szamol
            // 
            this.btn_szamol.Location = new System.Drawing.Point(13, 123);
            this.btn_szamol.Name = "btn_szamol";
            this.btn_szamol.Size = new System.Drawing.Size(75, 23);
            this.btn_szamol.TabIndex = 4;
            this.btn_szamol.Text = "Számol";
            this.btn_szamol.UseVisualStyleBackColor = true;
            this.btn_szamol.Click += new System.EventHandler(this.btn_szamol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 490);
            this.Controls.Add(this.btn_szamol);
            this.Controls.Add(this.l_16);
            this.Controls.Add(this.l_10);
            this.Controls.Add(this.l_2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Számrendszer átválás (sor,verem)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_16;
        private System.Windows.Forms.RadioButton rb_10;
        private System.Windows.Forms.RadioButton rb_2;
        private System.Windows.Forms.Label l_2;
        private System.Windows.Forms.Label l_10;
        private System.Windows.Forms.Label l_16;
        private System.Windows.Forms.Button btn_szamol;
    }
}

