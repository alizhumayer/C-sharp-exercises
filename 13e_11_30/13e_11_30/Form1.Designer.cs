namespace _13e_11_30
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
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_10 = new System.Windows.Forms.Label();
            this.lbl_16 = new System.Windows.Forms.Label();
            this.btn_számol = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_16);
            this.groupBox1.Controls.Add(this.rb_10);
            this.groupBox1.Controls.Add(this.rb_2);
            this.groupBox1.Location = new System.Drawing.Point(73, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Miből";
            // 
            // rb_2
            // 
            this.rb_2.AutoSize = true;
            this.rb_2.Location = new System.Drawing.Point(24, 20);
            this.rb_2.Name = "rb_2";
            this.rb_2.Size = new System.Drawing.Size(31, 17);
            this.rb_2.TabIndex = 0;
            this.rb_2.Text = "2";
            this.rb_2.UseVisualStyleBackColor = true;
            // 
            // rb_10
            // 
            this.rb_10.AutoSize = true;
            this.rb_10.Checked = true;
            this.rb_10.Location = new System.Drawing.Point(24, 43);
            this.rb_10.Name = "rb_10";
            this.rb_10.Size = new System.Drawing.Size(37, 17);
            this.rb_10.TabIndex = 0;
            this.rb_10.TabStop = true;
            this.rb_10.Text = "10";
            this.rb_10.UseVisualStyleBackColor = true;
            // 
            // rb_16
            // 
            this.rb_16.AutoSize = true;
            this.rb_16.Location = new System.Drawing.Point(24, 66);
            this.rb_16.Name = "rb_16";
            this.rb_16.Size = new System.Drawing.Size(37, 17);
            this.rb_16.TabIndex = 0;
            this.rb_16.Text = "16";
            this.rb_16.UseVisualStyleBackColor = true;
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Location = new System.Drawing.Point(328, 98);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(16, 13);
            this.lbl_2.TabIndex = 1;
            this.lbl_2.Text = "2:";
            // 
            // lbl_10
            // 
            this.lbl_10.AutoSize = true;
            this.lbl_10.Location = new System.Drawing.Point(328, 123);
            this.lbl_10.Name = "lbl_10";
            this.lbl_10.Size = new System.Drawing.Size(22, 13);
            this.lbl_10.TabIndex = 1;
            this.lbl_10.Text = "10:";
            // 
            // lbl_16
            // 
            this.lbl_16.AutoSize = true;
            this.lbl_16.Location = new System.Drawing.Point(328, 144);
            this.lbl_16.Name = "lbl_16";
            this.lbl_16.Size = new System.Drawing.Size(22, 13);
            this.lbl_16.TabIndex = 2;
            this.lbl_16.Text = "16:";
            // 
            // btn_számol
            // 
            this.btn_számol.Location = new System.Drawing.Point(224, 212);
            this.btn_számol.Name = "btn_számol";
            this.btn_számol.Size = new System.Drawing.Size(75, 23);
            this.btn_számol.TabIndex = 3;
            this.btn_számol.Text = "Számol";
            this.btn_számol.UseVisualStyleBackColor = true;
            this.btn_számol.Click += new System.EventHandler(this.btn_számol_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 397);
            this.Controls.Add(this.btn_számol);
            this.Controls.Add(this.lbl_16);
            this.Controls.Add(this.lbl_10);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
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
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Label lbl_10;
        private System.Windows.Forms.Label lbl_16;
        private System.Windows.Forms.Button btn_számol;
    }
}

