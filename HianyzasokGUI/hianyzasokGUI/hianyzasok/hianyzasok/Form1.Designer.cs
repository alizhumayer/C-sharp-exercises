namespace hianyzasok
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nevtextBox = new System.Windows.Forms.TextBox();
            this.osztalytextBox = new System.Windows.Forms.TextBox();
            this.elsotextBox = new System.Windows.Forms.TextBox();
            this.utolsotextBox = new System.Windows.Forms.TextBox();
            this.mulasztotttextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(667, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(568, 452);
            this.listBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(667, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "2017 szeptemberi hányzások listája";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Név";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Osztály";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Első nap";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Utolsó nap";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mulasztott órák";
            // 
            // nevtextBox
            // 
            this.nevtextBox.Location = new System.Drawing.Point(196, 64);
            this.nevtextBox.Name = "nevtextBox";
            this.nevtextBox.Size = new System.Drawing.Size(301, 22);
            this.nevtextBox.TabIndex = 7;
            // 
            // osztalytextBox
            // 
            this.osztalytextBox.Location = new System.Drawing.Point(196, 118);
            this.osztalytextBox.Name = "osztalytextBox";
            this.osztalytextBox.Size = new System.Drawing.Size(301, 22);
            this.osztalytextBox.TabIndex = 8;
            // 
            // elsotextBox
            // 
            this.elsotextBox.Location = new System.Drawing.Point(196, 185);
            this.elsotextBox.Name = "elsotextBox";
            this.elsotextBox.Size = new System.Drawing.Size(301, 22);
            this.elsotextBox.TabIndex = 9;
            // 
            // utolsotextBox
            // 
            this.utolsotextBox.Location = new System.Drawing.Point(196, 254);
            this.utolsotextBox.Name = "utolsotextBox";
            this.utolsotextBox.Size = new System.Drawing.Size(301, 22);
            this.utolsotextBox.TabIndex = 10;
            // 
            // mulasztotttextBox
            // 
            this.mulasztotttextBox.Location = new System.Drawing.Point(196, 321);
            this.mulasztotttextBox.Name = "mulasztotttextBox";
            this.mulasztotttextBox.Size = new System.Drawing.Size(301, 22);
            this.mulasztotttextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(196, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(301, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "hiányzás rögzítése a szeptember.csv-be";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 560);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mulasztotttextBox);
            this.Controls.Add(this.utolsotextBox);
            this.Controls.Add(this.elsotextBox);
            this.Controls.Add(this.osztalytextBox);
            this.Controls.Add(this.nevtextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nevtextBox;
        private System.Windows.Forms.TextBox osztalytextBox;
        private System.Windows.Forms.TextBox elsotextBox;
        private System.Windows.Forms.TextBox utolsotextBox;
        private System.Windows.Forms.TextBox mulasztotttextBox;
        private System.Windows.Forms.Button button1;
    }
}

