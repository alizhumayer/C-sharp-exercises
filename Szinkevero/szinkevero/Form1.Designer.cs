namespace szinkevero
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
            this.meretScrollBar = new System.Windows.Forms.HScrollBar();
            this.negyzet = new System.Windows.Forms.Label();
            this.pirosScrollBar = new System.Windows.Forms.HScrollBar();
            this.zoldScrollBar = new System.Windows.Forms.HScrollBar();
            this.kekScrollBar = new System.Windows.Forms.HScrollBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.piros = new System.Windows.Forms.TextBox();
            this.zold = new System.Windows.Forms.TextBox();
            this.kek = new System.Windows.Forms.TextBox();
            this.negyzetoldal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // meretScrollBar
            // 
            this.meretScrollBar.Location = new System.Drawing.Point(77, 35);
            this.meretScrollBar.Maximum = 300;
            this.meretScrollBar.Minimum = 10;
            this.meretScrollBar.Name = "meretScrollBar";
            this.meretScrollBar.Size = new System.Drawing.Size(340, 26);
            this.meretScrollBar.TabIndex = 0;
            this.meretScrollBar.Value = 10;
            this.meretScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.meretScrollBar_Scroll);
            // 
            // negyzet
            // 
            this.negyzet.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.negyzet.Location = new System.Drawing.Point(74, 114);
            this.negyzet.MaximumSize = new System.Drawing.Size(300, 300);
            this.negyzet.Name = "negyzet";
            this.negyzet.Size = new System.Drawing.Size(10, 13);
            this.negyzet.TabIndex = 1;
            // 
            // pirosScrollBar
            // 
            this.pirosScrollBar.Location = new System.Drawing.Point(114, 314);
            this.pirosScrollBar.Maximum = 255;
            this.pirosScrollBar.Name = "pirosScrollBar";
            this.pirosScrollBar.Size = new System.Drawing.Size(247, 28);
            this.pirosScrollBar.TabIndex = 2;
            this.pirosScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pirosScrollBar_Scroll);
            // 
            // zoldScrollBar
            // 
            this.zoldScrollBar.Location = new System.Drawing.Point(114, 365);
            this.zoldScrollBar.Maximum = 255;
            this.zoldScrollBar.Name = "zoldScrollBar";
            this.zoldScrollBar.Size = new System.Drawing.Size(247, 28);
            this.zoldScrollBar.TabIndex = 3;
            this.zoldScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.zoldScrollBar_Scroll);
            // 
            // kekScrollBar
            // 
            this.kekScrollBar.Location = new System.Drawing.Point(114, 420);
            this.kekScrollBar.Maximum = 255;
            this.kekScrollBar.Name = "kekScrollBar";
            this.kekScrollBar.Size = new System.Drawing.Size(247, 28);
            this.kekScrollBar.TabIndex = 4;
            this.kekScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.kekScrollBar_Scroll);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(22, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Piros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(22, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Zöld";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(22, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kék";
            // 
            // piros
            // 
            this.piros.Location = new System.Drawing.Point(413, 321);
            this.piros.Name = "piros";
            this.piros.Size = new System.Drawing.Size(68, 20);
            this.piros.TabIndex = 8;
            // 
            // zold
            // 
            this.zold.Location = new System.Drawing.Point(413, 373);
            this.zold.Name = "zold";
            this.zold.Size = new System.Drawing.Size(68, 20);
            this.zold.TabIndex = 9;
            // 
            // kek
            // 
            this.kek.Location = new System.Drawing.Point(413, 428);
            this.kek.Name = "kek";
            this.kek.Size = new System.Drawing.Size(68, 20);
            this.kek.TabIndex = 10;
            // 
            // negyzetoldal
            // 
            this.negyzetoldal.AutoSize = true;
            this.negyzetoldal.Location = new System.Drawing.Point(258, 13);
            this.negyzetoldal.Name = "negyzetoldal";
            this.negyzetoldal.Size = new System.Drawing.Size(0, 13);
            this.negyzetoldal.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "A négyzet oldala";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 455);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.negyzetoldal);
            this.Controls.Add(this.kek);
            this.Controls.Add(this.zold);
            this.Controls.Add(this.piros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kekScrollBar);
            this.Controls.Add(this.zoldScrollBar);
            this.Controls.Add(this.pirosScrollBar);
            this.Controls.Add(this.negyzet);
            this.Controls.Add(this.meretScrollBar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HScrollBar meretScrollBar;
        private System.Windows.Forms.Label negyzet;
        private System.Windows.Forms.HScrollBar pirosScrollBar;
        private System.Windows.Forms.HScrollBar zoldScrollBar;
        private System.Windows.Forms.HScrollBar kekScrollBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox piros;
        private System.Windows.Forms.TextBox zold;
        private System.Windows.Forms.TextBox kek;
        private System.Windows.Forms.Label negyzetoldal;
        private System.Windows.Forms.Label label1;
    }
}

