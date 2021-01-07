namespace NegyPontRajz
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
            this.pb_vaszon = new System.Windows.Forms.PictureBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar2 = new System.Windows.Forms.VScrollBar();
            this.vScrollBar3 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_szin = new System.Windows.Forms.Button();
            this.szin_valaszt = new System.Windows.Forms.ColorDialog();
            this.l_r = new System.Windows.Forms.Label();
            this.l_g = new System.Windows.Forms.Label();
            this.l_b = new System.Windows.Forms.Label();
            this.btn_del = new System.Windows.Forms.Button();
            this.l_nowcolor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_vaszon)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_vaszon
            // 
            this.pb_vaszon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_vaszon.Location = new System.Drawing.Point(13, 48);
            this.pb_vaszon.Name = "pb_vaszon";
            this.pb_vaszon.Size = new System.Drawing.Size(279, 333);
            this.pb_vaszon.TabIndex = 0;
            this.pb_vaszon.TabStop = false;
            this.pb_vaszon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_vaszon_MouseDown);
            this.pb_vaszon.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_vaszon_MouseUp);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(308, 253);
            this.vScrollBar1.Maximum = 255;
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 128);
            this.vScrollBar1.TabIndex = 1;
            this.vScrollBar1.ValueChanged += new System.EventHandler(this.vScrollBar1_ValueChanged);
            // 
            // vScrollBar2
            // 
            this.vScrollBar2.Location = new System.Drawing.Point(340, 253);
            this.vScrollBar2.Maximum = 255;
            this.vScrollBar2.Name = "vScrollBar2";
            this.vScrollBar2.Size = new System.Drawing.Size(17, 128);
            this.vScrollBar2.TabIndex = 2;
            this.vScrollBar2.ValueChanged += new System.EventHandler(this.vScrollBar2_ValueChanged);
            // 
            // vScrollBar3
            // 
            this.vScrollBar3.Location = new System.Drawing.Point(370, 253);
            this.vScrollBar3.Maximum = 255;
            this.vScrollBar3.Name = "vScrollBar3";
            this.vScrollBar3.Size = new System.Drawing.Size(17, 128);
            this.vScrollBar3.TabIndex = 3;
            this.vScrollBar3.ValueChanged += new System.EventHandler(this.vScrollBar3_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "B";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Location = new System.Drawing.Point(299, 221);
            this.label4.MaximumSize = new System.Drawing.Size(200, 2);
            this.label4.MinimumSize = new System.Drawing.Size(180, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 2);
            this.label4.TabIndex = 7;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.LargeChange = 5;
            this.hScrollBar1.Location = new System.Drawing.Point(330, 201);
            this.hScrollBar1.Maximum = 25;
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(118, 17);
            this.hScrollBar1.TabIndex = 8;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Tollvastagság: ";
            // 
            // btn_szin
            // 
            this.btn_szin.Location = new System.Drawing.Point(408, 296);
            this.btn_szin.Name = "btn_szin";
            this.btn_szin.Size = new System.Drawing.Size(40, 36);
            this.btn_szin.TabIndex = 10;
            this.btn_szin.Text = "Szín";
            this.btn_szin.UseVisualStyleBackColor = true;
            this.btn_szin.Click += new System.EventHandler(this.btn_szin_Click);
            // 
            // l_r
            // 
            this.l_r.AutoSize = true;
            this.l_r.Location = new System.Drawing.Point(308, 385);
            this.l_r.Name = "l_r";
            this.l_r.Size = new System.Drawing.Size(35, 13);
            this.l_r.TabIndex = 11;
            this.l_r.Text = "label6";
            // 
            // l_g
            // 
            this.l_g.AutoSize = true;
            this.l_g.Location = new System.Drawing.Point(343, 385);
            this.l_g.Name = "l_g";
            this.l_g.Size = new System.Drawing.Size(35, 13);
            this.l_g.TabIndex = 12;
            this.l_g.Text = "label6";
            // 
            // l_b
            // 
            this.l_b.AutoSize = true;
            this.l_b.Location = new System.Drawing.Point(373, 385);
            this.l_b.Name = "l_b";
            this.l_b.Size = new System.Drawing.Size(35, 13);
            this.l_b.TabIndex = 13;
            this.l_b.Text = "label6";
            // 
            // btn_del
            // 
            this.btn_del.ForeColor = System.Drawing.Color.Red;
            this.btn_del.Location = new System.Drawing.Point(308, 48);
            this.btn_del.Name = "btn_del";
            this.btn_del.Size = new System.Drawing.Size(75, 23);
            this.btn_del.TabIndex = 14;
            this.btn_del.Text = "Töröl";
            this.btn_del.UseVisualStyleBackColor = true;
            this.btn_del.Click += new System.EventHandler(this.btn_del_Click);
            // 
            // l_nowcolor
            // 
            this.l_nowcolor.BackColor = System.Drawing.SystemColors.ControlDark;
            this.l_nowcolor.Location = new System.Drawing.Point(405, 268);
            this.l_nowcolor.Name = "l_nowcolor";
            this.l_nowcolor.Size = new System.Drawing.Size(43, 25);
            this.l_nowcolor.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 435);
            this.Controls.Add(this.l_nowcolor);
            this.Controls.Add(this.btn_del);
            this.Controls.Add(this.l_b);
            this.Controls.Add(this.l_g);
            this.Controls.Add(this.l_r);
            this.Controls.Add(this.btn_szin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.vScrollBar3);
            this.Controls.Add(this.vScrollBar2);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.pb_vaszon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb_vaszon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_vaszon;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.VScrollBar vScrollBar2;
        private System.Windows.Forms.VScrollBar vScrollBar3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_szin;
        private System.Windows.Forms.ColorDialog szin_valaszt;
        private System.Windows.Forms.Label l_r;
        private System.Windows.Forms.Label l_g;
        private System.Windows.Forms.Label l_b;
        private System.Windows.Forms.Button btn_del;
        private System.Windows.Forms.Label l_nowcolor;
    }
}

