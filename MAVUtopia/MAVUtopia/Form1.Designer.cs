namespace MAVUtopia
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
            this.btn_read = new System.Windows.Forms.Button();
            this.ofd_beolvas = new System.Windows.Forms.OpenFileDialog();
            this.btn_do = new System.Windows.Forms.Button();
            this.l_eredm = new System.Windows.Forms.Label();
            this.l_lefutasiIdo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_read
            // 
            this.btn_read.Location = new System.Drawing.Point(13, 13);
            this.btn_read.Name = "btn_read";
            this.btn_read.Size = new System.Drawing.Size(113, 23);
            this.btn_read.TabIndex = 0;
            this.btn_read.Text = "Beolvas";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // ofd_beolvas
            // 
            this.ofd_beolvas.FileName = "openFileDialog1";
            // 
            // btn_do
            // 
            this.btn_do.Location = new System.Drawing.Point(13, 43);
            this.btn_do.Name = "btn_do";
            this.btn_do.Size = new System.Drawing.Size(113, 23);
            this.btn_do.TabIndex = 1;
            this.btn_do.Text = "Számít";
            this.btn_do.UseVisualStyleBackColor = true;
            this.btn_do.Click += new System.EventHandler(this.btn_do_Click);
            // 
            // l_eredm
            // 
            this.l_eredm.AutoSize = true;
            this.l_eredm.Location = new System.Drawing.Point(12, 69);
            this.l_eredm.Name = "l_eredm";
            this.l_eredm.Size = new System.Drawing.Size(37, 13);
            this.l_eredm.TabIndex = 2;
            this.l_eredm.Text = "Eredm";
            // 
            // l_lefutasiIdo
            // 
            this.l_lefutasiIdo.AutoSize = true;
            this.l_lefutasiIdo.Location = new System.Drawing.Point(12, 82);
            this.l_lefutasiIdo.Name = "l_lefutasiIdo";
            this.l_lefutasiIdo.Size = new System.Drawing.Size(61, 13);
            this.l_lefutasiIdo.TabIndex = 3;
            this.l_lefutasiIdo.Text = "Lefutasi ido";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 380);
            this.Controls.Add(this.l_lefutasiIdo);
            this.Controls.Add(this.l_eredm);
            this.Controls.Add(this.btn_do);
            this.Controls.Add(this.btn_read);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Button btn_read;
        private System.Windows.Forms.OpenFileDialog ofd_beolvas;
        private System.Windows.Forms.Button btn_do;
        private System.Windows.Forms.Label l_eredm;
        private System.Windows.Forms.Label l_lefutasiIdo;
    }
    }

