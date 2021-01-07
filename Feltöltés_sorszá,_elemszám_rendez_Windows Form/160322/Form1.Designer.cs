namespace _160322
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_upload = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_count = new System.Windows.Forms.Button();
            this.btn_sort = new System.Windows.Forms.Button();
            this.btn_ibe = new System.Windows.Forms.Button();
            this.tb_ibe = new System.Windows.Forms.TextBox();
            this.gb_sort = new System.Windows.Forms.GroupBox();
            this.rb_down = new System.Windows.Forms.RadioButton();
            this.rb_up = new System.Windows.Forms.RadioButton();
            this.btn_sorszam = new System.Windows.Forms.Button();
            this.btn_beszur = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_keres = new System.Windows.Forms.Button();
            this.btn_kijelol = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.gb_sort.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(27, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(246, 509);
            this.listBox1.TabIndex = 0;
            this.listBox1.DoubleClick += new System.EventHandler(this.listBox1_DoubleClick);
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(299, 31);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(75, 23);
            this.btn_upload.TabIndex = 1;
            this.btn_upload.Text = "Feltöltés";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.Location = new System.Drawing.Point(395, 31);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Törlés";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_count
            // 
            this.btn_count.Enabled = false;
            this.btn_count.Location = new System.Drawing.Point(488, 30);
            this.btn_count.Name = "btn_count";
            this.btn_count.Size = new System.Drawing.Size(75, 23);
            this.btn_count.TabIndex = 3;
            this.btn_count.Text = "Elemszám";
            this.btn_count.UseVisualStyleBackColor = true;
            this.btn_count.Click += new System.EventHandler(this.btn_count_Click);
            // 
            // btn_sort
            // 
            this.btn_sort.Enabled = false;
            this.btn_sort.Location = new System.Drawing.Point(299, 72);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(75, 23);
            this.btn_sort.TabIndex = 4;
            this.btn_sort.Text = "Rendez";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.btn_sort_Click);
            // 
            // btn_ibe
            // 
            this.btn_ibe.Enabled = false;
            this.btn_ibe.Location = new System.Drawing.Point(279, 237);
            this.btn_ibe.Name = "btn_ibe";
            this.btn_ibe.Size = new System.Drawing.Size(120, 23);
            this.btn_ibe.TabIndex = 5;
            this.btn_ibe.Text = "Sorszám";
            this.btn_ibe.UseVisualStyleBackColor = true;
            this.btn_ibe.Click += new System.EventHandler(this.btn_ibe_Click);
            // 
            // tb_ibe
            // 
            this.tb_ibe.Enabled = false;
            this.tb_ibe.Location = new System.Drawing.Point(481, 266);
            this.tb_ibe.Name = "tb_ibe";
            this.tb_ibe.Size = new System.Drawing.Size(100, 20);
            this.tb_ibe.TabIndex = 6;
            // 
            // gb_sort
            // 
            this.gb_sort.Controls.Add(this.rb_down);
            this.gb_sort.Controls.Add(this.rb_up);
            this.gb_sort.Enabled = false;
            this.gb_sort.Location = new System.Drawing.Point(380, 61);
            this.gb_sort.Name = "gb_sort";
            this.gb_sort.Size = new System.Drawing.Size(201, 40);
            this.gb_sort.TabIndex = 7;
            this.gb_sort.TabStop = false;
            // 
            // rb_down
            // 
            this.rb_down.AutoSize = true;
            this.rb_down.Location = new System.Drawing.Point(107, 17);
            this.rb_down.Name = "rb_down";
            this.rb_down.Size = new System.Drawing.Size(73, 17);
            this.rb_down.TabIndex = 1;
            this.rb_down.Text = "Csökkenő";
            this.rb_down.UseVisualStyleBackColor = true;
            // 
            // rb_up
            // 
            this.rb_up.AutoSize = true;
            this.rb_up.Checked = true;
            this.rb_up.Location = new System.Drawing.Point(7, 17);
            this.rb_up.Name = "rb_up";
            this.rb_up.Size = new System.Drawing.Size(69, 17);
            this.rb_up.TabIndex = 0;
            this.rb_up.TabStop = true;
            this.rb_up.Text = "Növekvő";
            this.rb_up.UseVisualStyleBackColor = true;
            // 
            // btn_sorszam
            // 
            this.btn_sorszam.Enabled = false;
            this.btn_sorszam.Location = new System.Drawing.Point(279, 295);
            this.btn_sorszam.Name = "btn_sorszam";
            this.btn_sorszam.Size = new System.Drawing.Size(120, 23);
            this.btn_sorszam.TabIndex = 8;
            this.btn_sorszam.Text = "Sorszámu törlése";
            this.btn_sorszam.UseVisualStyleBackColor = true;
            this.btn_sorszam.Click += new System.EventHandler(this.btn_sorszam_Click);
            // 
            // btn_beszur
            // 
            this.btn_beszur.Enabled = false;
            this.btn_beszur.Location = new System.Drawing.Point(279, 324);
            this.btn_beszur.Name = "btn_beszur";
            this.btn_beszur.Size = new System.Drawing.Size(120, 23);
            this.btn_beszur.TabIndex = 9;
            this.btn_beszur.Text = "Beszúrás ide";
            this.btn_beszur.UseVisualStyleBackColor = true;
            this.btn_beszur.Click += new System.EventHandler(this.btn_beszur_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(481, 310);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(510, 295);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Elem";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Index";
            // 
            // btn_keres
            // 
            this.btn_keres.Enabled = false;
            this.btn_keres.Location = new System.Drawing.Point(279, 266);
            this.btn_keres.Name = "btn_keres";
            this.btn_keres.Size = new System.Drawing.Size(120, 23);
            this.btn_keres.TabIndex = 13;
            this.btn_keres.Text = "Elem keresése";
            this.btn_keres.UseVisualStyleBackColor = true;
            this.btn_keres.Click += new System.EventHandler(this.btn_keres_Click);
            // 
            // btn_kijelol
            // 
            this.btn_kijelol.Enabled = false;
            this.btn_kijelol.Location = new System.Drawing.Point(179, 546);
            this.btn_kijelol.Name = "btn_kijelol";
            this.btn_kijelol.Size = new System.Drawing.Size(94, 23);
            this.btn_kijelol.TabIndex = 14;
            this.btn_kijelol.Text = "Kijelölt törlése";
            this.btn_kijelol.UseVisualStyleBackColor = true;
            this.btn_kijelol.Click += new System.EventHandler(this.btn_kijelol_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(280, 371);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 150);
            this.comboBox1.TabIndex = 15;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(407, 371);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 16;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(534, 371);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 17;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(620, 61);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(467, 286);
            this.webBrowser1.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(837, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 611);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btn_kijelol);
            this.Controls.Add(this.btn_keres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_beszur);
            this.Controls.Add(this.btn_sorszam);
            this.Controls.Add(this.gb_sort);
            this.Controls.Add(this.tb_ibe);
            this.Controls.Add(this.btn_ibe);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.btn_count);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gb_sort.ResumeLayout(false);
            this.gb_sort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_count;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.Button btn_ibe;
        private System.Windows.Forms.TextBox tb_ibe;
        private System.Windows.Forms.GroupBox gb_sort;
        private System.Windows.Forms.RadioButton rb_down;
        private System.Windows.Forms.RadioButton rb_up;
        private System.Windows.Forms.Button btn_sorszam;
        private System.Windows.Forms.Button btn_beszur;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_keres;
        private System.Windows.Forms.Button btn_kijelol;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button1;
    }
}

