namespace harom_halmaz
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
            this.num_A = new System.Windows.Forms.NumericUpDown();
            this.num_B = new System.Windows.Forms.NumericUpDown();
            this.num_C = new System.Windows.Forms.NumericUpDown();
            this.btn_rajz = new System.Windows.Forms.Button();
            this.l_A = new System.Windows.Forms.Label();
            this.l_B = new System.Windows.Forms.Label();
            this.l_C = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_A)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_B)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_C)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 554);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // num_A
            // 
            this.num_A.Location = new System.Drawing.Point(12, 12);
            this.num_A.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_A.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_A.Name = "num_A";
            this.num_A.Size = new System.Drawing.Size(120, 20);
            this.num_A.TabIndex = 1;
            this.num_A.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // num_B
            // 
            this.num_B.Location = new System.Drawing.Point(139, 12);
            this.num_B.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_B.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_B.Name = "num_B";
            this.num_B.Size = new System.Drawing.Size(120, 20);
            this.num_B.TabIndex = 2;
            this.num_B.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // num_C
            // 
            this.num_C.Location = new System.Drawing.Point(266, 12);
            this.num_C.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.num_C.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_C.Name = "num_C";
            this.num_C.Size = new System.Drawing.Size(120, 20);
            this.num_C.TabIndex = 3;
            this.num_C.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_rajz
            // 
            this.btn_rajz.Location = new System.Drawing.Point(12, 596);
            this.btn_rajz.Name = "btn_rajz";
            this.btn_rajz.Size = new System.Drawing.Size(174, 23);
            this.btn_rajz.TabIndex = 4;
            this.btn_rajz.Text = "Halmazok rajzolása";
            this.btn_rajz.UseVisualStyleBackColor = true;
            this.btn_rajz.Click += new System.EventHandler(this.btn_rajz_Click);
            // 
            // l_A
            // 
            this.l_A.AutoSize = true;
            this.l_A.Location = new System.Drawing.Point(213, 605);
            this.l_A.Name = "l_A";
            this.l_A.Size = new System.Drawing.Size(20, 13);
            this.l_A.TabIndex = 6;
            this.l_A.Text = "A=";
            // 
            // l_B
            // 
            this.l_B.AutoSize = true;
            this.l_B.Location = new System.Drawing.Point(213, 628);
            this.l_B.Name = "l_B";
            this.l_B.Size = new System.Drawing.Size(20, 13);
            this.l_B.TabIndex = 7;
            this.l_B.Text = "B=";
            // 
            // l_C
            // 
            this.l_C.AutoSize = true;
            this.l_C.Location = new System.Drawing.Point(213, 651);
            this.l_C.Name = "l_C";
            this.l_C.Size = new System.Drawing.Size(20, 13);
            this.l_C.TabIndex = 8;
            this.l_C.Text = "C=";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(582, 682);
            this.Controls.Add(this.l_C);
            this.Controls.Add(this.l_B);
            this.Controls.Add(this.l_A);
            this.Controls.Add(this.btn_rajz);
            this.Controls.Add(this.num_C);
            this.Controls.Add(this.num_B);
            this.Controls.Add(this.num_A);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "3 Halmaz rajzolva";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_A)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_B)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_C)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown num_A;
        private System.Windows.Forms.NumericUpDown num_B;
        private System.Windows.Forms.NumericUpDown num_C;
        private System.Windows.Forms.Button btn_rajz;
        private System.Windows.Forms.Label l_A;
        private System.Windows.Forms.Label l_B;
        private System.Windows.Forms.Label l_C;
    }
}

