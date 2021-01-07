namespace adatb
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
            this.Eredmeny_box = new System.Windows.Forms.ListBox();
            this.Run = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Insert_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Eredmeny_box
            // 
            this.Eredmeny_box.FormattingEnabled = true;
            this.Eredmeny_box.Location = new System.Drawing.Point(40, 107);
            this.Eredmeny_box.Name = "Eredmeny_box";
            this.Eredmeny_box.Size = new System.Drawing.Size(379, 251);
            this.Eredmeny_box.TabIndex = 0;
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(458, 43);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(75, 23);
            this.Run.TabIndex = 1;
            this.Run.Text = "Run";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 405);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // Insert_btn
            // 
            this.Insert_btn.Location = new System.Drawing.Point(191, 401);
            this.Insert_btn.Name = "Insert_btn";
            this.Insert_btn.Size = new System.Drawing.Size(75, 23);
            this.Insert_btn.TabIndex = 3;
            this.Insert_btn.Text = "INSERT";
            this.Insert_btn.UseVisualStyleBackColor = true;
            this.Insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 550);
            this.Controls.Add(this.Insert_btn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.Eredmeny_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Eredmeny_box;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Insert_btn;
    }
}

