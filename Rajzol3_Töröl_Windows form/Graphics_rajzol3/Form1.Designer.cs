namespace Graphics_rajzol3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btn_szinez = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_torol = new System.Windows.Forms.Button();
            this.btn_torol2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 300);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(419, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(400, 300);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseDown);
            // 
            // btn_szinez
            // 
            this.btn_szinez.Location = new System.Drawing.Point(13, 513);
            this.btn_szinez.Name = "btn_szinez";
            this.btn_szinez.Size = new System.Drawing.Size(75, 23);
            this.btn_szinez.TabIndex = 2;
            this.btn_szinez.Text = "Színez";
            this.btn_szinez.UseVisualStyleBackColor = true;
            this.btn_szinez.Click += new System.EventHandler(this.btn_szinez_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button1_MouseUp);
            // 
            // btn_torol
            // 
            this.btn_torol.Location = new System.Drawing.Point(82, 319);
            this.btn_torol.Name = "btn_torol";
            this.btn_torol.Size = new System.Drawing.Size(98, 23);
            this.btn_torol.TabIndex = 4;
            this.btn_torol.Text = "Töröl 1";
            this.btn_torol.UseVisualStyleBackColor = true;
            this.btn_torol.Click += new System.EventHandler(this.btn_torol_Click);
            // 
            // btn_torol2
            // 
            this.btn_torol2.Location = new System.Drawing.Point(559, 319);
            this.btn_torol2.Name = "btn_torol2";
            this.btn_torol2.Size = new System.Drawing.Size(75, 23);
            this.btn_torol2.TabIndex = 5;
            this.btn_torol2.Text = "Töröl 2";
            this.btn_torol2.UseVisualStyleBackColor = true;
            this.btn_torol2.Click += new System.EventHandler(this.btn_torol2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 560);
            this.Controls.Add(this.btn_torol2);
            this.Controls.Add(this.btn_torol);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_szinez);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btn_szinez;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_torol;
        private System.Windows.Forms.Button btn_torol2;
    }
}

