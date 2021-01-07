namespace Eratoszthenesz_szitaja
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
            this.btn_listaz = new System.Windows.Forms.Button();
            this.cb_max = new System.Windows.Forms.ComboBox();
            this.btn_do = new System.Windows.Forms.Button();
            this.cb_ie = new System.Windows.Forms.ComboBox();
            this.fd_load = new System.Windows.Forms.OpenFileDialog();
            this.fd_save = new System.Windows.Forms.SaveFileDialog();
            this.lb_primek = new System.Windows.Forms.ListBox();
            this.l_elemszam = new System.Windows.Forms.Label();
            this.l_szum = new System.Windows.Forms.Label();
            this.l_atlag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_listaz
            // 
            this.btn_listaz.Location = new System.Drawing.Point(156, 27);
            this.btn_listaz.Name = "btn_listaz";
            this.btn_listaz.Size = new System.Drawing.Size(80, 21);
            this.btn_listaz.TabIndex = 0;
            this.btn_listaz.Text = "Listáz";
            this.btn_listaz.UseVisualStyleBackColor = true;
            this.btn_listaz.Click += new System.EventHandler(this.btn_listaz_Click);
            // 
            // cb_max
            // 
            this.cb_max.FormattingEnabled = true;
            this.cb_max.Location = new System.Drawing.Point(27, 27);
            this.cb_max.Name = "cb_max";
            this.cb_max.Size = new System.Drawing.Size(111, 21);
            this.cb_max.TabIndex = 1;
            this.cb_max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_max_KeyPress);
            // 
            // btn_do
            // 
            this.btn_do.Location = new System.Drawing.Point(403, 27);
            this.btn_do.Name = "btn_do";
            this.btn_do.Size = new System.Drawing.Size(75, 21);
            this.btn_do.TabIndex = 2;
            this.btn_do.Text = "Végrehajt";
            this.btn_do.UseVisualStyleBackColor = true;
            this.btn_do.Click += new System.EventHandler(this.btn_do_Click);
            // 
            // cb_ie
            // 
            this.cb_ie.FormattingEnabled = true;
            this.cb_ie.Location = new System.Drawing.Point(310, 27);
            this.cb_ie.Name = "cb_ie";
            this.cb_ie.Size = new System.Drawing.Size(87, 21);
            this.cb_ie.TabIndex = 3;
            this.cb_ie.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_ie_KeyPress);
            // 
            // fd_load
            // 
            this.fd_load.FileName = "openFileDialog1";
            // 
            // lb_primek
            // 
            this.lb_primek.FormattingEnabled = true;
            this.lb_primek.Location = new System.Drawing.Point(27, 55);
            this.lb_primek.Name = "lb_primek";
            this.lb_primek.Size = new System.Drawing.Size(111, 316);
            this.lb_primek.TabIndex = 4;
            // 
            // l_elemszam
            // 
            this.l_elemszam.AutoSize = true;
            this.l_elemszam.Location = new System.Drawing.Point(145, 57);
            this.l_elemszam.Name = "l_elemszam";
            this.l_elemszam.Size = new System.Drawing.Size(0, 13);
            this.l_elemszam.TabIndex = 5;
            // 
            // l_szum
            // 
            this.l_szum.AutoSize = true;
            this.l_szum.Location = new System.Drawing.Point(145, 74);
            this.l_szum.Name = "l_szum";
            this.l_szum.Size = new System.Drawing.Size(0, 13);
            this.l_szum.TabIndex = 6;
            // 
            // l_atlag
            // 
            this.l_atlag.AutoSize = true;
            this.l_atlag.Location = new System.Drawing.Point(145, 91);
            this.l_atlag.Name = "l_atlag";
            this.l_atlag.Size = new System.Drawing.Size(0, 13);
            this.l_atlag.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 428);
            this.Controls.Add(this.l_atlag);
            this.Controls.Add(this.l_szum);
            this.Controls.Add(this.l_elemszam);
            this.Controls.Add(this.lb_primek);
            this.Controls.Add(this.cb_ie);
            this.Controls.Add(this.btn_do);
            this.Controls.Add(this.cb_max);
            this.Controls.Add(this.btn_listaz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_listaz;
        private System.Windows.Forms.ComboBox cb_max;
        private System.Windows.Forms.Button btn_do;
        private System.Windows.Forms.ComboBox cb_ie;
        private System.Windows.Forms.OpenFileDialog fd_load;
        private System.Windows.Forms.SaveFileDialog fd_save;
        private System.Windows.Forms.ListBox lb_primek;
        private System.Windows.Forms.Label l_elemszam;
        private System.Windows.Forms.Label l_szum;
        private System.Windows.Forms.Label l_atlag;
    }
}

