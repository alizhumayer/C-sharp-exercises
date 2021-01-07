namespace hegyekmo
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.hegycsucsnevtextBox = new System.Windows.Forms.TextBox();
            this.hegysegtextBox = new System.Windows.Forms.TextBox();
            this.magassagtextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(261, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(484, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "adatok beszúrása a hegyekMo.txt-be ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hegycsúcs neve";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hegység";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Magasság";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(678, 26);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(665, 388);
            this.listBox1.TabIndex = 4;
            // 
            // hegycsucsnevtextBox
            // 
            this.hegycsucsnevtextBox.Location = new System.Drawing.Point(173, 40);
            this.hegycsucsnevtextBox.Name = "hegycsucsnevtextBox";
            this.hegycsucsnevtextBox.Size = new System.Drawing.Size(342, 22);
            this.hegycsucsnevtextBox.TabIndex = 5;
            // 
            // hegysegtextBox
            // 
            this.hegysegtextBox.Location = new System.Drawing.Point(173, 118);
            this.hegysegtextBox.Name = "hegysegtextBox";
            this.hegysegtextBox.Size = new System.Drawing.Size(342, 22);
            this.hegysegtextBox.TabIndex = 6;
            // 
            // magassagtextBox
            // 
            this.magassagtextBox.Location = new System.Drawing.Point(173, 206);
            this.magassagtextBox.Name = "magassagtextBox";
            this.magassagtextBox.Size = new System.Drawing.Size(342, 22);
            this.magassagtextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 555);
            this.Controls.Add(this.magassagtextBox);
            this.Controls.Add(this.hegysegtextBox);
            this.Controls.Add(this.hegycsucsnevtextBox);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox hegycsucsnevtextBox;
        private System.Windows.Forms.TextBox hegysegtextBox;
        private System.Windows.Forms.TextBox magassagtextBox;
    }
}

