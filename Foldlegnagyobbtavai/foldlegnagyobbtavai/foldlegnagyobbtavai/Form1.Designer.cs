namespace foldlegnagyobbtavai
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tonevtextBox = new System.Windows.Forms.TextBox();
            this.toterulettextBox = new System.Windows.Forms.TextBox();
            this.toorszagtextBox = new System.Windows.Forms.TextBox();
            this.toteruletmaxtextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(257, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(308, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "adatok kiírása a tavak.csv-be";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tó neve";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(661, 34);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(457, 308);
            this.listBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(622, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tó területe (négyzetkilométerben, vagy egy minimum és egy maximum érték kötőjelle" +
    "l elválasztva ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tó országa(i)";
            // 
            // tonevtextBox
            // 
            this.tonevtextBox.Location = new System.Drawing.Point(135, 34);
            this.tonevtextBox.Name = "tonevtextBox";
            this.tonevtextBox.Size = new System.Drawing.Size(443, 22);
            this.tonevtextBox.TabIndex = 5;
            // 
            // toterulettextBox
            // 
            this.toterulettextBox.Location = new System.Drawing.Point(135, 145);
            this.toterulettextBox.Name = "toterulettextBox";
            this.toterulettextBox.Size = new System.Drawing.Size(172, 22);
            this.toterulettextBox.TabIndex = 6;
            // 
            // toorszagtextBox
            // 
            this.toorszagtextBox.Location = new System.Drawing.Point(135, 200);
            this.toorszagtextBox.Name = "toorszagtextBox";
            this.toorszagtextBox.Size = new System.Drawing.Size(443, 22);
            this.toorszagtextBox.TabIndex = 7;
            // 
            // toteruletmaxtextBox
            // 
            this.toteruletmaxtextBox.Location = new System.Drawing.Point(353, 145);
            this.toteruletmaxtextBox.Name = "toteruletmaxtextBox";
            this.toteruletmaxtextBox.Size = new System.Drawing.Size(172, 22);
            this.toteruletmaxtextBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toteruletmaxtextBox);
            this.Controls.Add(this.toorszagtextBox);
            this.Controls.Add(this.toterulettextBox);
            this.Controls.Add(this.tonevtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tonevtextBox;
        private System.Windows.Forms.TextBox toterulettextBox;
        private System.Windows.Forms.TextBox toorszagtextBox;
        private System.Windows.Forms.TextBox toteruletmaxtextBox;
        private System.Windows.Forms.Label label4;
    }
}

