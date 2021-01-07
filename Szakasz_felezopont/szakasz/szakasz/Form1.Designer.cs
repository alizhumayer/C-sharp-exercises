namespace szakasz
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
            this.a1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.a2 = new System.Windows.Forms.NumericUpDown();
            this.b2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.a1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1)).BeginInit();
            this.SuspendLayout();
            // 
            // a1
            // 
            this.a1.Location = new System.Drawing.Point(66, 26);
            this.a1.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.a1.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            -2147483648});
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(57, 20);
            this.a1.TabIndex = 0;
            this.a1.Value = new decimal(new int[] {
            4,
            0,
            0,
            -2147483648});
            this.a1.ValueChanged += new System.EventHandler(this.a1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "x1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "y1";
            // 
            // a2
            // 
            this.a2.Location = new System.Drawing.Point(66, 53);
            this.a2.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.a2.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            -2147483648});
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(57, 20);
            this.a2.TabIndex = 3;
            this.a2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.a2.ValueChanged += new System.EventHandler(this.a2_ValueChanged);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(340, 46);
            this.b2.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.b2.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            -2147483648});
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(57, 20);
            this.b2.TabIndex = 7;
            this.b2.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.b2.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "y2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "x2";
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(340, 19);
            this.b1.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.b1.Minimum = new decimal(new int[] {
            25,
            0,
            0,
            -2147483648});
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(57, 20);
            this.b1.TabIndex = 4;
            this.b1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.b1.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "A pont";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "B pont";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.a1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.a1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown a1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown a2;
        private System.Windows.Forms.NumericUpDown b2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown b1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

