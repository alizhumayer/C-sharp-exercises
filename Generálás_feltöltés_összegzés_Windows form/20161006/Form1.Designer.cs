namespace _20161006
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
            this.mentes = new System.Windows.Forms.SaveFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.megnyitas = new System.Windows.Forms.OpenFileDialog();
            this.osszeg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_min = new System.Windows.Forms.Button();
            this.btn_vane = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generálás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mentes
            // 
            this.mentes.Filter = "|*.txt";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(138, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Feltolés";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // megnyitas
            // 
            this.megnyitas.FileName = "openFileDialog1";
            this.megnyitas.Filter = "|*.txt";
            // 
            // osszeg
            // 
            this.osszeg.Enabled = false;
            this.osszeg.Location = new System.Drawing.Point(354, 12);
            this.osszeg.Name = "osszeg";
            this.osszeg.Size = new System.Drawing.Size(154, 23);
            this.osszeg.TabIndex = 2;
            this.osszeg.Text = "Összegzés";
            this.osszeg.UseVisualStyleBackColor = true;
            this.osszeg.Click += new System.EventHandler(this.osszeg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(351, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_min
            // 
            this.btn_min.Enabled = false;
            this.btn_min.Location = new System.Drawing.Point(354, 42);
            this.btn_min.Name = "btn_min";
            this.btn_min.Size = new System.Drawing.Size(154, 23);
            this.btn_min.TabIndex = 4;
            this.btn_min.Text = "Minimum";
            this.btn_min.UseVisualStyleBackColor = true;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_vane
            // 
            this.btn_vane.Location = new System.Drawing.Point(354, 72);
            this.btn_vane.Name = "btn_vane";
            this.btn_vane.Size = new System.Drawing.Size(154, 23);
            this.btn_vane.TabIndex = 5;
            this.btn_vane.Text = "Eldöntés";
            this.btn_vane.UseVisualStyleBackColor = true;
            this.btn_vane.Click += new System.EventHandler(this.btn_vane_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 232);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(480, 259);
            this.dataGridView1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 558);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_vane);
            this.Controls.Add(this.btn_min);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.osszeg);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog mentes;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog megnyitas;
        private System.Windows.Forms.Button osszeg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_min;
        private System.Windows.Forms.Button btn_vane;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

