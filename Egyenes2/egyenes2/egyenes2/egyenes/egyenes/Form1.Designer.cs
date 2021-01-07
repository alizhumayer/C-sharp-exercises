namespace egyenes
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
            this.m = new System.Windows.Forms.NumericUpDown();
            this.b = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m2 = new System.Windows.Forms.NumericUpDown();
            this.b2 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b2)).BeginInit();
            this.SuspendLayout();
            // 
            // m
            // 
            this.m.DecimalPlaces = 1;
            this.m.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.m.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.m.Location = new System.Drawing.Point(59, 21);
            this.m.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.m.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.m.Name = "m";
            this.m.Size = new System.Drawing.Size(50, 26);
            this.m.TabIndex = 0;
            this.m.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.m.ValueChanged += new System.EventHandler(this.m_ValueChanged);
            // 
            // b
            // 
            this.b.DecimalPlaces = 1;
            this.b.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.b.Location = new System.Drawing.Point(161, 21);
            this.b.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.b.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(49, 26);
            this.b.TabIndex = 1;
            this.b.ValueChanged += new System.EventHandler(this.b_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(28, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "y=m*x+b egyenes ábrázolása";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(28, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "m=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(134, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "b=";
            // 
            // m2
            // 
            this.m2.DecimalPlaces = 1;
            this.m2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.m2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.m2.Location = new System.Drawing.Point(311, 23);
            this.m2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.m2.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.m2.Name = "m2";
            this.m2.Size = new System.Drawing.Size(49, 26);
            this.m2.TabIndex = 5;
            this.m2.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.m2.ValueChanged += new System.EventHandler(this.m2_ValueChanged);
            // 
            // b2
            // 
            this.b2.DecimalPlaces = 1;
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.b2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.b2.Location = new System.Drawing.Point(413, 22);
            this.b2.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.b2.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            -2147483648});
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(49, 26);
            this.b2.TabIndex = 6;
            this.b2.ValueChanged += new System.EventHandler(this.b2_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(273, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "m2=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "b2=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(276, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.m2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b);
            this.Controls.Add(this.m);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.m)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown m;
        private System.Windows.Forms.NumericUpDown b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown m2;
        private System.Windows.Forms.NumericUpDown b2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

