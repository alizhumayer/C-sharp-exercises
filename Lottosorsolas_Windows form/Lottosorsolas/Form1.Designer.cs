namespace Lottosorsolas
{
    partial class btn_sorsolas
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
            this.rb_otos = new System.Windows.Forms.RadioButton();
            this.rb_hatos = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_skandinav = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_skandinav);
            this.groupBox1.Controls.Add(this.rb_hatos);
            this.groupBox1.Controls.Add(this.rb_otos);
            this.groupBox1.Location = new System.Drawing.Point(13, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Válassza ki a lottó típusát";
            // 
            // rb_otos
            // 
            this.rb_otos.AutoSize = true;
            this.rb_otos.Checked = true;
            this.rb_otos.Location = new System.Drawing.Point(7, 20);
            this.rb_otos.Name = "rb_otos";
            this.rb_otos.Size = new System.Drawing.Size(67, 17);
            this.rb_otos.TabIndex = 0;
            this.rb_otos.TabStop = true;
            this.rb_otos.Text = "Ötöslottó";
            this.rb_otos.UseVisualStyleBackColor = true;
            // 
            // rb_hatos
            // 
            this.rb_hatos.AutoSize = true;
            this.rb_hatos.Location = new System.Drawing.Point(7, 44);
            this.rb_hatos.Name = "rb_hatos";
            this.rb_hatos.Size = new System.Drawing.Size(73, 17);
            this.rb_hatos.TabIndex = 1;
            this.rb_hatos.Text = "Hatoslottó";
            this.rb_hatos.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(346, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sorsolás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kihúzott számok:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "label3";
            // 
            // rb_skandinav
            // 
            this.rb_skandinav.AutoSize = true;
            this.rb_skandinav.Location = new System.Drawing.Point(7, 68);
            this.rb_skandinav.Name = "rb_skandinav";
            this.rb_skandinav.Size = new System.Drawing.Size(76, 17);
            this.rb_skandinav.TabIndex = 2;
            this.rb_skandinav.Text = "Skandináv";
            this.rb_skandinav.UseVisualStyleBackColor = true;
            // 
            // btn_sorsolas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 310);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Name = "btn_sorsolas";
            this.Text = "Lottósorsolás";
            this.Load += new System.EventHandler(this.btn_sorsolas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_skandinav;
        private System.Windows.Forms.RadioButton rb_hatos;
        private System.Windows.Forms.RadioButton rb_otos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

