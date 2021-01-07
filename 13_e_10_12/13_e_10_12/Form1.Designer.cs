namespace _13_e_10_12
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
            this.nm_elso = new System.Windows.Forms.NumericUpDown();
            this.nm_masodik = new System.Windows.Forms.NumericUpDown();
            this.nm_harmadik = new System.Windows.Forms.NumericUpDown();
            this.nm_negyedik = new System.Windows.Forms.NumericUpDown();
            this.nm_mask = new System.Windows.Forms.NumericUpDown();
            this.btn_számol = new System.Windows.Forms.Button();
            this.lbl_na = new System.Windows.Forms.Label();
            this.lbl_first = new System.Windows.Forms.Label();
            this.lbl_last = new System.Windows.Forms.Label();
            this.lbl_bc = new System.Windows.Forms.Label();
            this.DGV = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nm_elso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_masodik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_harmadik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_negyedik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_mask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // nm_elso
            // 
            this.nm_elso.Location = new System.Drawing.Point(64, 45);
            this.nm_elso.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nm_elso.Name = "nm_elso";
            this.nm_elso.Size = new System.Drawing.Size(99, 20);
            this.nm_elso.TabIndex = 0;
            this.nm_elso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nm_masodik
            // 
            this.nm_masodik.Location = new System.Drawing.Point(185, 45);
            this.nm_masodik.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nm_masodik.Name = "nm_masodik";
            this.nm_masodik.Size = new System.Drawing.Size(99, 20);
            this.nm_masodik.TabIndex = 0;
            this.nm_masodik.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nm_harmadik
            // 
            this.nm_harmadik.Location = new System.Drawing.Point(290, 45);
            this.nm_harmadik.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nm_harmadik.Name = "nm_harmadik";
            this.nm_harmadik.Size = new System.Drawing.Size(99, 20);
            this.nm_harmadik.TabIndex = 0;
            this.nm_harmadik.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nm_negyedik
            // 
            this.nm_negyedik.Location = new System.Drawing.Point(395, 45);
            this.nm_negyedik.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nm_negyedik.Name = "nm_negyedik";
            this.nm_negyedik.Size = new System.Drawing.Size(99, 20);
            this.nm_negyedik.TabIndex = 0;
            this.nm_negyedik.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nm_mask
            // 
            this.nm_mask.Location = new System.Drawing.Point(529, 44);
            this.nm_mask.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nm_mask.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nm_mask.Name = "nm_mask";
            this.nm_mask.Size = new System.Drawing.Size(120, 20);
            this.nm_mask.TabIndex = 1;
            this.nm_mask.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nm_mask.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btn_számol
            // 
            this.btn_számol.Location = new System.Drawing.Point(610, 95);
            this.btn_számol.Name = "btn_számol";
            this.btn_számol.Size = new System.Drawing.Size(75, 23);
            this.btn_számol.TabIndex = 2;
            this.btn_számol.Text = "Számol";
            this.btn_számol.UseVisualStyleBackColor = true;
            this.btn_számol.Click += new System.EventHandler(this.btn_számol_Click);
            // 
            // lbl_na
            // 
            this.lbl_na.AutoSize = true;
            this.lbl_na.Location = new System.Drawing.Point(64, 164);
            this.lbl_na.Name = "lbl_na";
            this.lbl_na.Size = new System.Drawing.Size(24, 13);
            this.lbl_na.TabIndex = 3;
            this.lbl_na.Text = "Na:";
            // 
            // lbl_first
            // 
            this.lbl_first.AutoSize = true;
            this.lbl_first.Location = new System.Drawing.Point(67, 201);
            this.lbl_first.Name = "lbl_first";
            this.lbl_first.Size = new System.Drawing.Size(29, 13);
            this.lbl_first.TabIndex = 4;
            this.lbl_first.Text = "First:";
            // 
            // lbl_last
            // 
            this.lbl_last.AutoSize = true;
            this.lbl_last.Location = new System.Drawing.Point(64, 229);
            this.lbl_last.Name = "lbl_last";
            this.lbl_last.Size = new System.Drawing.Size(30, 13);
            this.lbl_last.TabIndex = 5;
            this.lbl_last.Text = "Last:";
            // 
            // lbl_bc
            // 
            this.lbl_bc.AutoSize = true;
            this.lbl_bc.Location = new System.Drawing.Point(67, 258);
            this.lbl_bc.Name = "lbl_bc";
            this.lbl_bc.Size = new System.Drawing.Size(24, 13);
            this.lbl_bc.TabIndex = 6;
            this.lbl_bc.Text = "BC:";
            // 
            // DGV
            // 
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(331, 188);
            this.DGV.Name = "DGV";
            this.DGV.Size = new System.Drawing.Size(304, 156);
            this.DGV.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 425);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.lbl_bc);
            this.Controls.Add(this.lbl_last);
            this.Controls.Add(this.lbl_first);
            this.Controls.Add(this.lbl_na);
            this.Controls.Add(this.btn_számol);
            this.Controls.Add(this.nm_mask);
            this.Controls.Add(this.nm_negyedik);
            this.Controls.Add(this.nm_harmadik);
            this.Controls.Add(this.nm_masodik);
            this.Controls.Add(this.nm_elso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nm_elso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_masodik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_harmadik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_negyedik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nm_mask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nm_elso;
        private System.Windows.Forms.NumericUpDown nm_masodik;
        private System.Windows.Forms.NumericUpDown nm_harmadik;
        private System.Windows.Forms.NumericUpDown nm_negyedik;
        private System.Windows.Forms.NumericUpDown nm_mask;
        private System.Windows.Forms.Button btn_számol;
        private System.Windows.Forms.Label lbl_na;
        private System.Windows.Forms.Label lbl_first;
        private System.Windows.Forms.Label lbl_last;
        private System.Windows.Forms.Label lbl_bc;
        private System.Windows.Forms.DataGridView DGV;
    }
}

