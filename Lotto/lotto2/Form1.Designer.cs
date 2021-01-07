namespace lotto2
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
            this.btn_feltoltes = new System.Windows.Forms.Button();
            this.be = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_feltoltes
            // 
            this.btn_feltoltes.Location = new System.Drawing.Point(13, 13);
            this.btn_feltoltes.Name = "btn_feltoltes";
            this.btn_feltoltes.Size = new System.Drawing.Size(120, 23);
            this.btn_feltoltes.TabIndex = 0;
            this.btn_feltoltes.Text = "Feltöltés";
            this.btn_feltoltes.UseVisualStyleBackColor = true;
            this.btn_feltoltes.Click += new System.EventHandler(this.btn_feltoltes_Click);
            // 
            // be
            // 
            this.be.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(140, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 383);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_feltoltes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_feltoltes;
        private System.Windows.Forms.OpenFileDialog be;
        private System.Windows.Forms.Label label1;
    }
}

