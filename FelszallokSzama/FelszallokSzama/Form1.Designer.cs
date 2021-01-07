namespace FelszallokSzama
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
            this.btn_do = new System.Windows.Forms.Button();
            this.ofd_beolvas = new System.Windows.Forms.OpenFileDialog();
            this.l_eredm = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_do
            // 
            this.btn_do.Location = new System.Drawing.Point(13, 13);
            this.btn_do.Name = "btn_do";
            this.btn_do.Size = new System.Drawing.Size(100, 23);
            this.btn_do.TabIndex = 0;
            this.btn_do.Text = "Beolvas és DO";
            this.btn_do.UseVisualStyleBackColor = true;
            this.btn_do.Click += new System.EventHandler(this.btn_do_Click);
            // 
            // ofd_beolvas
            // 
            this.ofd_beolvas.FileName = "openFileDialog1";
            // 
            // l_eredm
            // 
            this.l_eredm.AutoSize = true;
            this.l_eredm.Location = new System.Drawing.Point(13, 43);
            this.l_eredm.Name = "l_eredm";
            this.l_eredm.Size = new System.Drawing.Size(35, 13);
            this.l_eredm.TabIndex = 1;
            this.l_eredm.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 381);
            this.Controls.Add(this.l_eredm);
            this.Controls.Add(this.btn_do);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Button btn_do;
        private System.Windows.Forms.OpenFileDialog ofd_beolvas;
        private System.Windows.Forms.Label l_eredm;
        }
    }

