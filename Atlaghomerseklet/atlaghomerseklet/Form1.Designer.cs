namespace atlaghomerseklet
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_atlag = new System.Windows.Forms.Button();
            this.btn_fok = new System.Windows.Forms.Button();
            this.btn_legmelegebb = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.vane_ki = new System.Windows.Forms.Label();
            this.atlag_ki = new System.Windows.Forms.Label();
            this.fok_alatt = new System.Windows.Forms.Label();
            this.meleg_ki = new System.Windows.Forms.Label();
            this.btn_feltolt = new System.Windows.Forms.Button();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.fok10_alatt = new System.Windows.Forms.Label();
            this.btn_fokalatt = new System.Windows.Forms.Button();
            this.l_fokalatt = new System.Windows.Forms.Label();
            this.legmelegebb = new System.Windows.Forms.Label();
            this.van_e = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(486, 260);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_atlag
            // 
            this.btn_atlag.Enabled = false;
            this.btn_atlag.Location = new System.Drawing.Point(508, 14);
            this.btn_atlag.Name = "btn_atlag";
            this.btn_atlag.Size = new System.Drawing.Size(113, 23);
            this.btn_atlag.TabIndex = 1;
            this.btn_atlag.Text = "Átlaghőmérséklet";
            this.btn_atlag.UseVisualStyleBackColor = true;
            this.btn_atlag.Click += new System.EventHandler(this.btn_atlag_Click);
            // 
            // btn_fok
            // 
            this.btn_fok.Enabled = false;
            this.btn_fok.ForeColor = System.Drawing.Color.DarkOrange;
            this.btn_fok.Location = new System.Drawing.Point(508, 43);
            this.btn_fok.Name = "btn_fok";
            this.btn_fok.Size = new System.Drawing.Size(113, 23);
            this.btn_fok.TabIndex = 2;
            this.btn_fok.Text = "10 fok felett";
            this.btn_fok.UseVisualStyleBackColor = true;
            this.btn_fok.Click += new System.EventHandler(this.btn_fok_Click);
            // 
            // btn_legmelegebb
            // 
            this.btn_legmelegebb.Enabled = false;
            this.btn_legmelegebb.ForeColor = System.Drawing.Color.Red;
            this.btn_legmelegebb.Location = new System.Drawing.Point(508, 102);
            this.btn_legmelegebb.Name = "btn_legmelegebb";
            this.btn_legmelegebb.Size = new System.Drawing.Size(113, 23);
            this.btn_legmelegebb.TabIndex = 3;
            this.btn_legmelegebb.Text = "Legmelegebb";
            this.btn_legmelegebb.UseVisualStyleBackColor = true;
            this.btn_legmelegebb.Click += new System.EventHandler(this.btn_legmelegebb_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(508, 173);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(113, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(505, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Átlaghőmérséklet";
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(505, 203);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(113, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "Van-e ilyen mérés?";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // vane_ki
            // 
            this.vane_ki.AutoSize = true;
            this.vane_ki.Location = new System.Drawing.Point(505, 176);
            this.vane_ki.Name = "vane_ki";
            this.vane_ki.Size = new System.Drawing.Size(0, 13);
            this.vane_ki.TabIndex = 7;
            // 
            // atlag_ki
            // 
            this.atlag_ki.AutoSize = true;
            this.atlag_ki.Location = new System.Drawing.Point(625, 13);
            this.atlag_ki.Name = "atlag_ki";
            this.atlag_ki.Size = new System.Drawing.Size(0, 13);
            this.atlag_ki.TabIndex = 8;
            // 
            // fok_alatt
            // 
            this.fok_alatt.AutoSize = true;
            this.fok_alatt.Location = new System.Drawing.Point(625, 43);
            this.fok_alatt.Name = "fok_alatt";
            this.fok_alatt.Size = new System.Drawing.Size(0, 13);
            this.fok_alatt.TabIndex = 9;
            // 
            // meleg_ki
            // 
            this.meleg_ki.AutoSize = true;
            this.meleg_ki.Location = new System.Drawing.Point(625, 73);
            this.meleg_ki.Name = "meleg_ki";
            this.meleg_ki.Size = new System.Drawing.Size(0, 13);
            this.meleg_ki.TabIndex = 10;
            // 
            // btn_feltolt
            // 
            this.btn_feltolt.Location = new System.Drawing.Point(13, 288);
            this.btn_feltolt.Name = "btn_feltolt";
            this.btn_feltolt.Size = new System.Drawing.Size(116, 23);
            this.btn_feltolt.TabIndex = 11;
            this.btn_feltolt.Text = "Feltölt és megjelenít";
            this.btn_feltolt.UseVisualStyleBackColor = true;
            this.btn_feltolt.Click += new System.EventHandler(this.btn_feltolt_Click);
            // 
            // openFile
            // 
            this.openFile.FileName = "homerseklet.txt";
            // 
            // fok10_alatt
            // 
            this.fok10_alatt.AutoSize = true;
            this.fok10_alatt.Location = new System.Drawing.Point(625, 43);
            this.fok10_alatt.Name = "fok10_alatt";
            this.fok10_alatt.Size = new System.Drawing.Size(0, 13);
            this.fok10_alatt.TabIndex = 12;
            // 
            // btn_fokalatt
            // 
            this.btn_fokalatt.Enabled = false;
            this.btn_fokalatt.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_fokalatt.Location = new System.Drawing.Point(508, 73);
            this.btn_fokalatt.Name = "btn_fokalatt";
            this.btn_fokalatt.Size = new System.Drawing.Size(113, 23);
            this.btn_fokalatt.TabIndex = 13;
            this.btn_fokalatt.Text = "10 fok alatt";
            this.btn_fokalatt.UseVisualStyleBackColor = true;
            this.btn_fokalatt.Click += new System.EventHandler(this.btn_fokalatt_Click);
            // 
            // l_fokalatt
            // 
            this.l_fokalatt.AutoSize = true;
            this.l_fokalatt.Location = new System.Drawing.Point(628, 73);
            this.l_fokalatt.Name = "l_fokalatt";
            this.l_fokalatt.Size = new System.Drawing.Size(0, 13);
            this.l_fokalatt.TabIndex = 14;
            // 
            // legmelegebb
            // 
            this.legmelegebb.AutoSize = true;
            this.legmelegebb.Location = new System.Drawing.Point(640, 111);
            this.legmelegebb.Name = "legmelegebb";
            this.legmelegebb.Size = new System.Drawing.Size(0, 13);
            this.legmelegebb.TabIndex = 15;
            // 
            // van_e
            // 
            this.van_e.AutoSize = true;
            this.van_e.Location = new System.Drawing.Point(628, 203);
            this.van_e.Name = "van_e";
            this.van_e.Size = new System.Drawing.Size(0, 13);
            this.van_e.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(763, 323);
            this.Controls.Add(this.van_e);
            this.Controls.Add(this.legmelegebb);
            this.Controls.Add(this.l_fokalatt);
            this.Controls.Add(this.btn_fokalatt);
            this.Controls.Add(this.fok10_alatt);
            this.Controls.Add(this.btn_feltolt);
            this.Controls.Add(this.meleg_ki);
            this.Controls.Add(this.fok_alatt);
            this.Controls.Add(this.atlag_ki);
            this.Controls.Add(this.vane_ki);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_legmelegebb);
            this.Controls.Add(this.btn_fok);
            this.Controls.Add(this.btn_atlag);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Hőmérsékletek";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_atlag;
        private System.Windows.Forms.Button btn_fok;
        private System.Windows.Forms.Button btn_legmelegebb;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label vane_ki;
        private System.Windows.Forms.Label atlag_ki;
        private System.Windows.Forms.Label fok_alatt;
        private System.Windows.Forms.Label meleg_ki;
        private System.Windows.Forms.Button btn_feltolt;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Label fok10_alatt;
        private System.Windows.Forms.Button btn_fokalatt;
        private System.Windows.Forms.Label l_fokalatt;
        private System.Windows.Forms.Label legmelegebb;
        private System.Windows.Forms.Label van_e;
    }
}

