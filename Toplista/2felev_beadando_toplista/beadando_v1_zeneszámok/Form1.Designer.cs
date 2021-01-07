namespace beadando_v1
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
            this.btn_beolvas = new System.Windows.Forms.Button();
            this.ofd_olvas = new System.Windows.Forms.OpenFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kivalogat = new System.Windows.Forms.Button();
            this.btn_htmlbe = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_beolvas
            // 
            this.btn_beolvas.Location = new System.Drawing.Point(16, 12);
            this.btn_beolvas.Name = "btn_beolvas";
            this.btn_beolvas.Size = new System.Drawing.Size(99, 23);
            this.btn_beolvas.TabIndex = 0;
            this.btn_beolvas.Text = "Beolvas";
            this.btn_beolvas.UseVisualStyleBackColor = true;
            this.btn_beolvas.Click += new System.EventHandler(this.btn_beolvas_Click);
            // 
            // ofd_olvas
            // 
            this.ofd_olvas.FileName = "zeneszamok.txt";
            this.ofd_olvas.Filter = "|*.txt";
            // 
            // comboBox1
            // 
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Válassz egy kategóriát a kiválogatáshoz";
            // 
            // btn_kivalogat
            // 
            this.btn_kivalogat.Enabled = false;
            this.btn_kivalogat.Location = new System.Drawing.Point(16, 87);
            this.btn_kivalogat.Name = "btn_kivalogat";
            this.btn_kivalogat.Size = new System.Drawing.Size(121, 23);
            this.btn_kivalogat.TabIndex = 3;
            this.btn_kivalogat.Text = "Kiválogatás";
            this.btn_kivalogat.UseVisualStyleBackColor = true;
            this.btn_kivalogat.Click += new System.EventHandler(this.btn_kivalogat_Click);
            // 
            // btn_htmlbe
            // 
            this.btn_htmlbe.Enabled = false;
            this.btn_htmlbe.Location = new System.Drawing.Point(215, 147);
            this.btn_htmlbe.Name = "btn_htmlbe";
            this.btn_htmlbe.Size = new System.Drawing.Size(121, 23);
            this.btn_htmlbe.TabIndex = 4;
            this.btn_htmlbe.Text = "HTML készítése";
            this.btn_htmlbe.UseVisualStyleBackColor = true;
            this.btn_htmlbe.Click += new System.EventHandler(this.btn_htmlbe_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(16, 121);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(193, 316);
            this.listBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 455);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_htmlbe);
            this.Controls.Add(this.btn_kivalogat);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_beolvas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_beolvas;
        private System.Windows.Forms.OpenFileDialog ofd_olvas;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_kivalogat;
        private System.Windows.Forms.Button btn_htmlbe;
        private System.Windows.Forms.ListBox listBox1;
    }
}

