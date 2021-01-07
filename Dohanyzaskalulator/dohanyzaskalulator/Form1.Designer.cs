namespace dohanyzaskalulator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cigarettaszam = new System.Windows.Forms.NumericUpDown();
            this.cigiszam = new System.Windows.Forms.NumericUpDown();
            this.dobozar = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.cigarettaszam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cigiszam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobozar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(292, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "DOHÁNYZÁS ÁRA KALKULÁTOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(29, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1014, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "SZÁMOLJA KI, MENNYI PÉNZT KÖLT HAVI ÉS ÉVES SZINTEN CIGARETTÁRA!";
            // 
            // label3
            // 
            this.label3.AutoEllipsis = true;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(31, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "NAPONTA ELSZÍVOTT CIGARETTÁK SZÁMA";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(429, 369);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(314, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "CIGARETTÁK SZÁMA EGY DOBOZBAN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(797, 369);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(246, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "EGY DOBOZ CIGARETTA ÁRA";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(414, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 61);
            this.button1.TabIndex = 5;
            this.button1.Text = "Számítás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cigarettaszam
            // 
            this.cigarettaszam.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cigarettaszam.Location = new System.Drawing.Point(145, 224);
            this.cigarettaszam.Name = "cigarettaszam";
            this.cigarettaszam.Size = new System.Drawing.Size(120, 64);
            this.cigarettaszam.TabIndex = 6;
            this.cigarettaszam.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // cigiszam
            // 
            this.cigiszam.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cigiszam.Location = new System.Drawing.Point(499, 224);
            this.cigiszam.Name = "cigiszam";
            this.cigiszam.Size = new System.Drawing.Size(120, 64);
            this.cigiszam.TabIndex = 7;
            this.cigiszam.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // dobozar
            // 
            this.dobozar.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dobozar.Location = new System.Drawing.Point(718, 224);
            this.dobozar.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.dobozar.Name = "dobozar";
            this.dobozar.Size = new System.Drawing.Size(224, 64);
            this.dobozar.TabIndex = 8;
            this.dobozar.Value = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 611);
            this.Controls.Add(this.dobozar);
            this.Controls.Add(this.cigiszam);
            this.Controls.Add(this.cigarettaszam);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.cigarettaszam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cigiszam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dobozar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown cigarettaszam;
        private System.Windows.Forms.NumericUpDown cigiszam;
        private System.Windows.Forms.NumericUpDown dobozar;
    }
}

