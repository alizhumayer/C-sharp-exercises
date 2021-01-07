namespace Idojaras
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.nud_faluk = new System.Windows.Forms.NumericUpDown();
            this.nud_days = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_melegMin = new System.Windows.Forms.NumericUpDown();
            this.btn_generate = new System.Windows.Forms.Button();
            this.btn_genOut = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.ofd_find = new System.Windows.Forms.OpenFileDialog();
            this.l_readDone = new System.Windows.Forms.Label();
            this.btn_longest = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.l_longH = new System.Windows.Forms.Label();
            this.l_longAvg = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.l_longLength = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.nud_faluk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_days)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_melegMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_faluk
            // 
            this.nud_faluk.Location = new System.Drawing.Point(29, 28);
            this.nud_faluk.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_faluk.Name = "nud_faluk";
            this.nud_faluk.Size = new System.Drawing.Size(120, 20);
            this.nud_faluk.TabIndex = 0;
            this.nud_faluk.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // nud_days
            // 
            this.nud_days.Location = new System.Drawing.Point(29, 67);
            this.nud_days.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nud_days.Name = "nud_days";
            this.nud_days.Size = new System.Drawing.Size(120, 20);
            this.nud_days.TabIndex = 1;
            this.nud_days.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Települések száma:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Napok száma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Meleg korlát:";
            // 
            // nud_melegMin
            // 
            this.nud_melegMin.Location = new System.Drawing.Point(29, 111);
            this.nud_melegMin.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nud_melegMin.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nud_melegMin.Name = "nud_melegMin";
            this.nud_melegMin.Size = new System.Drawing.Size(120, 20);
            this.nud_melegMin.TabIndex = 5;
            this.nud_melegMin.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(52, 137);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(75, 23);
            this.btn_generate.TabIndex = 6;
            this.btn_generate.Text = "Generál";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // btn_genOut
            // 
            this.btn_genOut.Location = new System.Drawing.Point(52, 167);
            this.btn_genOut.Name = "btn_genOut";
            this.btn_genOut.Size = new System.Drawing.Size(75, 23);
            this.btn_genOut.TabIndex = 7;
            this.btn_genOut.Text = "Ment";
            this.btn_genOut.UseVisualStyleBackColor = true;
            this.btn_genOut.Click += new System.EventHandler(this.btn_genOut_Click);
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(52, 196);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(75, 23);
            this.btn_read.TabIndex = 8;
            this.btn_read.Text = "Beolvas";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // ofd_find
            // 
            this.ofd_find.FileName = "openFileDialog1";
            this.ofd_find.Filter = "|*.txt";
            // 
            // l_readDone
            // 
            this.l_readDone.AutoSize = true;
            this.l_readDone.Location = new System.Drawing.Point(52, 226);
            this.l_readDone.Name = "l_readDone";
            this.l_readDone.Size = new System.Drawing.Size(95, 13);
            this.l_readDone.TabIndex = 9;
            this.l_readDone.Text = "Beolvasás sikeres!";
            // 
            // btn_longest
            // 
            this.btn_longest.Location = new System.Drawing.Point(186, 12);
            this.btn_longest.Name = "btn_longest";
            this.btn_longest.Size = new System.Drawing.Size(144, 23);
            this.btn_longest.TabIndex = 10;
            this.btn_longest.Text = "Leghoszabb hőség";
            this.btn_longest.UseVisualStyleBackColor = true;
            this.btn_longest.Click += new System.EventHandler(this.btn_longest_Click);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(179, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1, 271);
            this.label4.TabIndex = 11;
            // 
            // l_longH
            // 
            this.l_longH.AutoSize = true;
            this.l_longH.Location = new System.Drawing.Point(295, 42);
            this.l_longH.Name = "l_longH";
            this.l_longH.Size = new System.Drawing.Size(35, 13);
            this.l_longH.TabIndex = 12;
            this.l_longH.Text = "label5";
            // 
            // l_longAvg
            // 
            this.l_longAvg.AutoSize = true;
            this.l_longAvg.Location = new System.Drawing.Point(295, 92);
            this.l_longAvg.Name = "l_longAvg";
            this.l_longAvg.Size = new System.Drawing.Size(35, 13);
            this.l_longAvg.TabIndex = 13;
            this.l_longAvg.Text = "label5";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Helység száma:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sorozat hossza:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Hőmérséklet átlag:";
            // 
            // l_longLength
            // 
            this.l_longLength.AutoSize = true;
            this.l_longLength.Location = new System.Drawing.Point(295, 67);
            this.l_longLength.Name = "l_longLength";
            this.l_longLength.Size = new System.Drawing.Size(35, 13);
            this.l_longLength.TabIndex = 17;
            this.l_longLength.Text = "label8";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(52, 257);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 18;
            this.btn_reset.Text = "Új";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(354, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "A1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(300, 300);
            this.chart1.TabIndex = 19;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 324);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.l_longLength);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.l_longAvg);
            this.Controls.Add(this.l_longH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_longest);
            this.Controls.Add(this.l_readDone);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.btn_genOut);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.nud_melegMin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nud_days);
            this.Controls.Add(this.nud_faluk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_faluk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_days)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_melegMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_faluk;
        private System.Windows.Forms.NumericUpDown nud_days;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nud_melegMin;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Button btn_genOut;
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.OpenFileDialog ofd_find;
        private System.Windows.Forms.Label l_readDone;
        private System.Windows.Forms.Button btn_longest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label l_longH;
        private System.Windows.Forms.Label l_longAvg;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label l_longLength;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

