namespace Benzinkut
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
            this.components = new System.ComponentModel.Container();
            this.gb98 = new System.Windows.Forms.GroupBox();
            this.gb95 = new System.Windows.Forms.GroupBox();
            this.gbd = new System.Windows.Forms.GroupBox();
            this.sh95 = new System.Windows.Forms.NumericUpDown();
            this.sh98 = new System.Windows.Forms.NumericUpDown();
            this.shd = new System.Windows.Forms.NumericUpDown();
            this.gba = new System.Windows.Forms.GroupBox();
            this.sha = new System.Windows.Forms.NumericUpDown();
            this.ta = new System.Windows.Forms.Timer(this.components);
            this.t95 = new System.Windows.Forms.Timer(this.components);
            this.t98 = new System.Windows.Forms.Timer(this.components);
            this.td = new System.Windows.Forms.Timer(this.components);
            this.gb106 = new System.Windows.Forms.GroupBox();
            this.sh106 = new System.Windows.Forms.NumericUpDown();
            this.cb95 = new System.Windows.Forms.ComboBox();
            this.l_vIdo = new System.Windows.Forms.Label();
            this.l_vIdo2 = new System.Windows.Forms.Label();
            this.cb98 = new System.Windows.Forms.ComboBox();
            this.cbd = new System.Windows.Forms.ComboBox();
            this.cb106 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.t106 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.sh95)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sh98)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sh106)).BeginInit();
            this.SuspendLayout();
            // 
            // gb98
            // 
            this.gb98.Location = new System.Drawing.Point(111, 27);
            this.gb98.Name = "gb98";
            this.gb98.Size = new System.Drawing.Size(91, 264);
            this.gb98.TabIndex = 1;
            this.gb98.TabStop = false;
            this.gb98.Text = "98";
            // 
            // gb95
            // 
            this.gb95.Location = new System.Drawing.Point(13, 27);
            this.gb95.Name = "gb95";
            this.gb95.Size = new System.Drawing.Size(91, 264);
            this.gb95.TabIndex = 0;
            this.gb95.TabStop = false;
            this.gb95.Text = "95";
            // 
            // gbd
            // 
            this.gbd.Location = new System.Drawing.Point(208, 27);
            this.gbd.Name = "gbd";
            this.gbd.Size = new System.Drawing.Size(91, 264);
            this.gbd.TabIndex = 2;
            this.gbd.TabStop = false;
            this.gbd.Text = "Diesel";
            // 
            // sh95
            // 
            this.sh95.Location = new System.Drawing.Point(13, 298);
            this.sh95.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sh95.Name = "sh95";
            this.sh95.Size = new System.Drawing.Size(91, 20);
            this.sh95.TabIndex = 3;
            // 
            // sh98
            // 
            this.sh98.Location = new System.Drawing.Point(111, 298);
            this.sh98.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.sh98.Name = "sh98";
            this.sh98.Size = new System.Drawing.Size(91, 20);
            this.sh98.TabIndex = 4;
            // 
            // shd
            // 
            this.shd.Location = new System.Drawing.Point(209, 298);
            this.shd.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.shd.Name = "shd";
            this.shd.Size = new System.Drawing.Size(90, 20);
            this.shd.TabIndex = 5;
            // 
            // gba
            // 
            this.gba.Location = new System.Drawing.Point(13, 325);
            this.gba.Name = "gba";
            this.gba.Size = new System.Drawing.Size(286, 56);
            this.gba.TabIndex = 6;
            this.gba.TabStop = false;
            this.gba.Text = "Autók";
            // 
            // sha
            // 
            this.sha.Location = new System.Drawing.Point(111, 387);
            this.sha.Name = "sha";
            this.sha.Size = new System.Drawing.Size(91, 20);
            this.sha.TabIndex = 7;
            // 
            // ta
            // 
            this.ta.Interval = 1000;
            this.ta.Tick += new System.EventHandler(this.ta_Tick);
            // 
            // t95
            // 
            this.t95.Interval = 500;
            this.t95.Tick += new System.EventHandler(this.t95_Tick);
            // 
            // t98
            // 
            this.t98.Interval = 500;
            this.t98.Tick += new System.EventHandler(this.t98_Tick);
            // 
            // td
            // 
            this.td.Interval = 500;
            this.td.Tick += new System.EventHandler(this.td_Tick);
            // 
            // gb106
            // 
            this.gb106.Location = new System.Drawing.Point(306, 27);
            this.gb106.Name = "gb106";
            this.gb106.Size = new System.Drawing.Size(91, 264);
            this.gb106.TabIndex = 8;
            this.gb106.TabStop = false;
            this.gb106.Text = "106";
            // 
            // sh106
            // 
            this.sh106.Location = new System.Drawing.Point(306, 298);
            this.sh106.Name = "sh106";
            this.sh106.Size = new System.Drawing.Size(91, 20);
            this.sh106.TabIndex = 9;
            // 
            // cb95
            // 
            this.cb95.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb95.FormattingEnabled = true;
            this.cb95.Location = new System.Drawing.Point(460, 89);
            this.cb95.Name = "cb95";
            this.cb95.Size = new System.Drawing.Size(121, 21);
            this.cb95.TabIndex = 10;
            this.cb95.SelectedIndexChanged += new System.EventHandler(this.cb95_SelectedIndexChanged);
            // 
            // l_vIdo
            // 
            this.l_vIdo.AutoSize = true;
            this.l_vIdo.Location = new System.Drawing.Point(457, 47);
            this.l_vIdo.Name = "l_vIdo";
            this.l_vIdo.Size = new System.Drawing.Size(76, 13);
            this.l_vIdo.TabIndex = 11;
            this.l_vIdo.Text = "Várakozási idő";
            // 
            // l_vIdo2
            // 
            this.l_vIdo2.AutoSize = true;
            this.l_vIdo2.Location = new System.Drawing.Point(460, 70);
            this.l_vIdo2.Name = "l_vIdo2";
            this.l_vIdo2.Size = new System.Drawing.Size(46, 13);
            this.l_vIdo2.TabIndex = 12;
            this.l_vIdo2.Text = "(millisec)";
            // 
            // cb98
            // 
            this.cb98.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb98.FormattingEnabled = true;
            this.cb98.Location = new System.Drawing.Point(460, 117);
            this.cb98.Name = "cb98";
            this.cb98.Size = new System.Drawing.Size(121, 21);
            this.cb98.TabIndex = 13;
            this.cb98.SelectedIndexChanged += new System.EventHandler(this.cb98_SelectedIndexChanged);
            // 
            // cbd
            // 
            this.cbd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbd.FormattingEnabled = true;
            this.cbd.Location = new System.Drawing.Point(460, 145);
            this.cbd.Name = "cbd";
            this.cbd.Size = new System.Drawing.Size(121, 21);
            this.cbd.TabIndex = 14;
            this.cbd.SelectedIndexChanged += new System.EventHandler(this.cbd_SelectedIndexChanged);
            // 
            // cb106
            // 
            this.cb106.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb106.FormattingEnabled = true;
            this.cb106.Location = new System.Drawing.Point(460, 173);
            this.cb106.Name = "cb106";
            this.cb106.Size = new System.Drawing.Size(121, 21);
            this.cb106.TabIndex = 15;
            this.cb106.SelectedIndexChanged += new System.EventHandler(this.cb106_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "95";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "98";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "D";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "106";
            // 
            // t106
            // 
            this.t106.Interval = 500;
            this.t106.Tick += new System.EventHandler(this.t106_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 427);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb106);
            this.Controls.Add(this.cbd);
            this.Controls.Add(this.cb98);
            this.Controls.Add(this.l_vIdo2);
            this.Controls.Add(this.l_vIdo);
            this.Controls.Add(this.cb95);
            this.Controls.Add(this.sh106);
            this.Controls.Add(this.gb106);
            this.Controls.Add(this.sha);
            this.Controls.Add(this.gba);
            this.Controls.Add(this.shd);
            this.Controls.Add(this.sh98);
            this.Controls.Add(this.sh95);
            this.Controls.Add(this.gbd);
            this.Controls.Add(this.gb98);
            this.Controls.Add(this.gb95);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sh95)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sh98)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sh106)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb98;
        private System.Windows.Forms.GroupBox gb95;
        private System.Windows.Forms.GroupBox gbd;
        private System.Windows.Forms.NumericUpDown sh95;
        private System.Windows.Forms.NumericUpDown sh98;
        private System.Windows.Forms.NumericUpDown shd;
        private System.Windows.Forms.GroupBox gba;
        private System.Windows.Forms.NumericUpDown sha;
        private System.Windows.Forms.Timer ta;
        private System.Windows.Forms.Timer t95;
        private System.Windows.Forms.Timer t98;
        private System.Windows.Forms.Timer td;
        private System.Windows.Forms.GroupBox gb106;
        private System.Windows.Forms.NumericUpDown sh106;
        private System.Windows.Forms.ComboBox cb95;
        private System.Windows.Forms.Label l_vIdo;
        private System.Windows.Forms.Label l_vIdo2;
        private System.Windows.Forms.ComboBox cb98;
        private System.Windows.Forms.ComboBox cbd;
        private System.Windows.Forms.ComboBox cb106;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer t106;
    }
}

