namespace _13e_14_2_10_19
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_hatos = new System.Windows.Forms.RadioButton();
            this.rb_ötös = new System.Windows.Forms.RadioButton();
            this.rb_skandináv = new System.Windows.Forms.RadioButton();
            this.btn_sorsolás = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_skandináv);
            this.groupBox2.Controls.Add(this.rb_hatos);
            this.groupBox2.Controls.Add(this.rb_ötös);
            this.groupBox2.Location = new System.Drawing.Point(127, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 134);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Választás";
            // 
            // rb_hatos
            // 
            this.rb_hatos.AutoSize = true;
            this.rb_hatos.Location = new System.Drawing.Point(35, 55);
            this.rb_hatos.Name = "rb_hatos";
            this.rb_hatos.Size = new System.Drawing.Size(53, 17);
            this.rb_hatos.TabIndex = 0;
            this.rb_hatos.Text = "Hatos";
            this.rb_hatos.UseVisualStyleBackColor = true;
            // 
            // rb_ötös
            // 
            this.rb_ötös.AutoSize = true;
            this.rb_ötös.Checked = true;
            this.rb_ötös.Location = new System.Drawing.Point(35, 32);
            this.rb_ötös.Name = "rb_ötös";
            this.rb_ötös.Size = new System.Drawing.Size(47, 17);
            this.rb_ötös.TabIndex = 0;
            this.rb_ötös.TabStop = true;
            this.rb_ötös.Text = "Ötös";
            this.rb_ötös.UseVisualStyleBackColor = true;
            // 
            // rb_skandináv
            // 
            this.rb_skandináv.AutoSize = true;
            this.rb_skandináv.Location = new System.Drawing.Point(35, 78);
            this.rb_skandináv.Name = "rb_skandináv";
            this.rb_skandináv.Size = new System.Drawing.Size(76, 17);
            this.rb_skandináv.TabIndex = 0;
            this.rb_skandináv.Text = "Skandináv";
            this.rb_skandináv.UseVisualStyleBackColor = true;
            // 
            // btn_sorsolás
            // 
            this.btn_sorsolás.Location = new System.Drawing.Point(195, 253);
            this.btn_sorsolás.Name = "btn_sorsolás";
            this.btn_sorsolás.Size = new System.Drawing.Size(75, 23);
            this.btn_sorsolás.TabIndex = 1;
            this.btn_sorsolás.Text = "Sorsolás";
            this.btn_sorsolás.UseVisualStyleBackColor = true;
            this.btn_sorsolás.Click += new System.EventHandler(this.btn_sorsolás_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 364);
            this.Controls.Add(this.btn_sorsolás);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_skandináv;
        private System.Windows.Forms.RadioButton rb_hatos;
        private System.Windows.Forms.RadioButton rb_ötös;
        private System.Windows.Forms.Button btn_sorsolás;
    }
}

