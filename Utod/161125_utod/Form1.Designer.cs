namespace _161125_utod
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.num_x = new System.Windows.Forms.NumericUpDown();
            this.num_y = new System.Windows.Forms.NumericUpDown();
            this.num_r = new System.Windows.Forms.NumericUpDown();
            this.num_rr = new System.Windows.Forms.NumericUpDown();
            this.btn_rajzol = new System.Windows.Forms.Button();
            this.btn_torol = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.l_x = new System.Windows.Forms.Label();
            this.l_y = new System.Windows.Forms.Label();
            this.l_r1 = new System.Windows.Forms.Label();
            this.l_r2 = new System.Windows.Forms.Label();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.num_cx = new System.Windows.Forms.NumericUpDown();
            this.num_cy = new System.Windows.Forms.NumericUpDown();
            this.l_cx = new System.Windows.Forms.Label();
            this.l_cy = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_rr)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_cx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_cy)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Aquamarine;
            this.pictureBox1.Location = new System.Drawing.Point(33, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 300);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // num_x
            // 
            this.num_x.Location = new System.Drawing.Point(33, 59);
            this.num_x.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.num_x.Name = "num_x";
            this.num_x.Size = new System.Drawing.Size(120, 20);
            this.num_x.TabIndex = 1;
            this.num_x.Tag = "";
            // 
            // num_y
            // 
            this.num_y.Location = new System.Drawing.Point(160, 59);
            this.num_y.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.num_y.Name = "num_y";
            this.num_y.Size = new System.Drawing.Size(120, 20);
            this.num_y.TabIndex = 2;
            // 
            // num_r
            // 
            this.num_r.Location = new System.Drawing.Point(287, 59);
            this.num_r.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.num_r.Name = "num_r";
            this.num_r.Size = new System.Drawing.Size(120, 20);
            this.num_r.TabIndex = 3;
            // 
            // num_rr
            // 
            this.num_rr.Enabled = false;
            this.num_rr.Location = new System.Drawing.Point(414, 59);
            this.num_rr.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.num_rr.Name = "num_rr";
            this.num_rr.Size = new System.Drawing.Size(120, 20);
            this.num_rr.TabIndex = 4;
            // 
            // btn_rajzol
            // 
            this.btn_rajzol.Location = new System.Drawing.Point(33, 392);
            this.btn_rajzol.Name = "btn_rajzol";
            this.btn_rajzol.Size = new System.Drawing.Size(97, 23);
            this.btn_rajzol.TabIndex = 5;
            this.btn_rajzol.Text = "Rajzol";
            this.btn_rajzol.UseVisualStyleBackColor = true;
            this.btn_rajzol.Click += new System.EventHandler(this.btn_rajzol_Click);
            // 
            // btn_torol
            // 
            this.btn_torol.Location = new System.Drawing.Point(33, 421);
            this.btn_torol.Name = "btn_torol";
            this.btn_torol.Size = new System.Drawing.Size(97, 23);
            this.btn_torol.TabIndex = 6;
            this.btn_torol.Text = "Törlés";
            this.btn_torol.UseVisualStyleBackColor = true;
            this.btn_torol.Click += new System.EventHandler(this.btn_torol_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(160, 395);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 55);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Új alakzat";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(67, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Ellipszis";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(20, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(41, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Kör";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(134, 26);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(64, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Négyzet";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(204, 26);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(66, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Téglalap";
            this.radioButton4.UseVisualStyleBackColor = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // l_x
            // 
            this.l_x.AutoSize = true;
            this.l_x.Location = new System.Drawing.Point(33, 40);
            this.l_x.Name = "l_x";
            this.l_x.Size = new System.Drawing.Size(35, 13);
            this.l_x.TabIndex = 8;
            this.l_x.Text = "label1";
            // 
            // l_y
            // 
            this.l_y.AutoSize = true;
            this.l_y.Location = new System.Drawing.Point(160, 40);
            this.l_y.Name = "l_y";
            this.l_y.Size = new System.Drawing.Size(35, 13);
            this.l_y.TabIndex = 9;
            this.l_y.Text = "label2";
            // 
            // l_r1
            // 
            this.l_r1.AutoSize = true;
            this.l_r1.Location = new System.Drawing.Point(287, 40);
            this.l_r1.Name = "l_r1";
            this.l_r1.Size = new System.Drawing.Size(35, 13);
            this.l_r1.TabIndex = 10;
            this.l_r1.Text = "label3";
            // 
            // l_r2
            // 
            this.l_r2.AutoSize = true;
            this.l_r2.Location = new System.Drawing.Point(414, 40);
            this.l_r2.Name = "l_r2";
            this.l_r2.Size = new System.Drawing.Size(35, 13);
            this.l_r2.TabIndex = 11;
            this.l_r2.Text = "label4";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(276, 26);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(78, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.Text = "Háromszög";
            this.radioButton5.UseVisualStyleBackColor = true;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // num_cx
            // 
            this.num_cx.Enabled = false;
            this.num_cx.Location = new System.Drawing.Point(540, 85);
            this.num_cx.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.num_cx.Name = "num_cx";
            this.num_cx.Size = new System.Drawing.Size(60, 20);
            this.num_cx.TabIndex = 12;
            // 
            // num_cy
            // 
            this.num_cy.Enabled = false;
            this.num_cy.Location = new System.Drawing.Point(540, 138);
            this.num_cy.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.num_cy.Name = "num_cy";
            this.num_cy.Size = new System.Drawing.Size(60, 20);
            this.num_cy.TabIndex = 13;
            // 
            // l_cx
            // 
            this.l_cx.AutoSize = true;
            this.l_cx.Location = new System.Drawing.Point(540, 66);
            this.l_cx.Name = "l_cx";
            this.l_cx.Size = new System.Drawing.Size(35, 13);
            this.l_cx.TabIndex = 14;
            this.l_cx.Text = "label1";
            // 
            // l_cy
            // 
            this.l_cy.AutoSize = true;
            this.l_cy.Location = new System.Drawing.Point(540, 119);
            this.l_cy.Name = "l_cy";
            this.l_cy.Size = new System.Drawing.Size(35, 13);
            this.l_cy.TabIndex = 15;
            this.l_cy.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(612, 462);
            this.Controls.Add(this.l_cy);
            this.Controls.Add(this.l_cx);
            this.Controls.Add(this.num_cy);
            this.Controls.Add(this.num_cx);
            this.Controls.Add(this.l_r2);
            this.Controls.Add(this.l_r1);
            this.Controls.Add(this.l_y);
            this.Controls.Add(this.l_x);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_torol);
            this.Controls.Add(this.btn_rajzol);
            this.Controls.Add(this.num_rr);
            this.Controls.Add(this.num_r);
            this.Controls.Add(this.num_y);
            this.Controls.Add(this.num_x);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_rr)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_cx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_cy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown num_x;
        private System.Windows.Forms.NumericUpDown num_y;
        private System.Windows.Forms.NumericUpDown num_r;
        private System.Windows.Forms.NumericUpDown num_rr;
        private System.Windows.Forms.Button btn_rajzol;
        private System.Windows.Forms.Button btn_torol;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Label l_x;
        private System.Windows.Forms.Label l_y;
        private System.Windows.Forms.Label l_r1;
        private System.Windows.Forms.Label l_r2;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.NumericUpDown num_cx;
        private System.Windows.Forms.NumericUpDown num_cy;
        private System.Windows.Forms.Label l_cx;
        private System.Windows.Forms.Label l_cy;
    }
}

