namespace elso
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
            this.nev = new System.Windows.Forms.TextBox();
            this.szul_ev = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bevitel = new System.Windows.Forms.Button();
            this.levf_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.darab_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.atlag_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nev
            // 
            this.nev.Location = new System.Drawing.Point(59, 52);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(100, 20);
            this.nev.TabIndex = 0;
            // 
            // szul_ev
            // 
            this.szul_ev.Location = new System.Drawing.Point(230, 51);
            this.szul_ev.Name = "szul_ev";
            this.szul_ev.Size = new System.Drawing.Size(100, 20);
            this.szul_ev.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Név:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Születési év:";
            // 
            // bevitel
            // 
            this.bevitel.Location = new System.Drawing.Point(376, 48);
            this.bevitel.Name = "bevitel";
            this.bevitel.Size = new System.Drawing.Size(75, 23);
            this.bevitel.TabIndex = 4;
            this.bevitel.Text = "Bevitel";
            this.bevitel.UseVisualStyleBackColor = true;
            this.bevitel.Click += new System.EventHandler(this.bevitel_Click);
            // 
            // levf_box
            // 
            this.levf_box.Location = new System.Drawing.Point(59, 116);
            this.levf_box.Name = "levf_box";
            this.levf_box.Size = new System.Drawing.Size(100, 20);
            this.levf_box.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Legfiatalabb kora:";
            // 
            // darab_box
            // 
            this.darab_box.Location = new System.Drawing.Point(59, 186);
            this.darab_box.Name = "darab_box";
            this.darab_box.Size = new System.Drawing.Size(100, 20);
            this.darab_box.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Felvett emberek száma:";
            // 
            // atlag_box
            // 
            this.atlag_box.Location = new System.Drawing.Point(59, 259);
            this.atlag_box.Name = "atlag_box";
            this.atlag_box.Size = new System.Drawing.Size(100, 20);
            this.atlag_box.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Átlag kor:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 367);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.atlag_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.darab_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.levf_box);
            this.Controls.Add(this.bevitel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.szul_ev);
            this.Controls.Add(this.nev);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nev;
        private System.Windows.Forms.TextBox szul_ev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bevitel;
        private System.Windows.Forms.TextBox levf_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox darab_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox atlag_box;
        private System.Windows.Forms.Label label5;
    }
}

