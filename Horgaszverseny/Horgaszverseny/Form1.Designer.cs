namespace Horgaszverseny
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
            this.btn_gen = new System.Windows.Forms.Button();
            this.nud_horgaszok = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_halfajtak = new System.Windows.Forms.NumericUpDown();
            this.dgw_tablazat = new System.Windows.Forms.DataGridView();
            this.l_winer = new System.Windows.Forms.Label();
            this.l_loser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nud_horgaszok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_halfajtak)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_tablazat)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_gen
            // 
            this.btn_gen.Location = new System.Drawing.Point(15, 95);
            this.btn_gen.Name = "btn_gen";
            this.btn_gen.Size = new System.Drawing.Size(120, 23);
            this.btn_gen.TabIndex = 0;
            this.btn_gen.Text = "Generál";
            this.btn_gen.UseVisualStyleBackColor = true;
            this.btn_gen.Click += new System.EventHandler(this.btn_gen_Click);
            // 
            // nud_horgaszok
            // 
            this.nud_horgaszok.Location = new System.Drawing.Point(15, 29);
            this.nud_horgaszok.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_horgaszok.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nud_horgaszok.Name = "nud_horgaszok";
            this.nud_horgaszok.Size = new System.Drawing.Size(120, 20);
            this.nud_horgaszok.TabIndex = 1;
            this.nud_horgaszok.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Horgászok száma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Halfajták száma";
            // 
            // nud_halfajtak
            // 
            this.nud_halfajtak.Location = new System.Drawing.Point(15, 69);
            this.nud_halfajtak.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_halfajtak.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nud_halfajtak.Name = "nud_halfajtak";
            this.nud_halfajtak.Size = new System.Drawing.Size(120, 20);
            this.nud_halfajtak.TabIndex = 4;
            this.nud_halfajtak.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // dgw_tablazat
            // 
            this.dgw_tablazat.AllowUserToAddRows = false;
            this.dgw_tablazat.AllowUserToDeleteRows = false;
            this.dgw_tablazat.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgw_tablazat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgw_tablazat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_tablazat.Location = new System.Drawing.Point(173, 29);
            this.dgw_tablazat.Name = "dgw_tablazat";
            this.dgw_tablazat.Size = new System.Drawing.Size(541, 252);
            this.dgw_tablazat.TabIndex = 5;
            // 
            // l_winer
            // 
            this.l_winer.AutoSize = true;
            this.l_winer.Location = new System.Drawing.Point(173, 288);
            this.l_winer.Name = "l_winer";
            this.l_winer.Size = new System.Drawing.Size(23, 13);
            this.l_winer.TabIndex = 6;
            this.l_winer.Text = "win";
            // 
            // l_loser
            // 
            this.l_loser.AutoSize = true;
            this.l_loser.Location = new System.Drawing.Point(173, 312);
            this.l_loser.Name = "l_loser";
            this.l_loser.Size = new System.Drawing.Size(26, 13);
            this.l_loser.TabIndex = 7;
            this.l_loser.Text = "lose";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 359);
            this.Controls.Add(this.l_loser);
            this.Controls.Add(this.l_winer);
            this.Controls.Add(this.dgw_tablazat);
            this.Controls.Add(this.nud_halfajtak);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_horgaszok);
            this.Controls.Add(this.btn_gen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_horgaszok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_halfajtak)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_tablazat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_gen;
        private System.Windows.Forms.NumericUpDown nud_horgaszok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_halfajtak;
        private System.Windows.Forms.DataGridView dgw_tablazat;
        private System.Windows.Forms.Label l_winer;
        private System.Windows.Forms.Label l_loser;
    }
}

