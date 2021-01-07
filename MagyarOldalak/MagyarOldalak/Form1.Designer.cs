namespace MagyarOldalak
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btn_ok = new System.Windows.Forms.Button();
            this.cb_link = new System.Windows.Forms.ComboBox();
            this.btn_kj = new System.Windows.Forms.Button();
            this.cb_ie = new System.Windows.Forms.ComboBox();
            this.ofd_import = new System.Windows.Forms.OpenFileDialog();
            this.sfd_export = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(4, 64);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.ScriptErrorsSuppressed = true;
            this.webBrowser1.Size = new System.Drawing.Size(805, 401);
            this.webBrowser1.TabIndex = 0;
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(7, 35);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(116, 23);
            this.btn_ok.TabIndex = 1;
            this.btn_ok.Text = "Betölt";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // cb_link
            // 
            this.cb_link.FormattingEnabled = true;
            this.cb_link.Location = new System.Drawing.Point(129, 35);
            this.cb_link.Name = "cb_link";
            this.cb_link.Size = new System.Drawing.Size(541, 21);
            this.cb_link.TabIndex = 2;
            this.cb_link.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_link_KeyPress);
            // 
            // btn_kj
            // 
            this.btn_kj.Location = new System.Drawing.Point(697, 13);
            this.btn_kj.Name = "btn_kj";
            this.btn_kj.Size = new System.Drawing.Size(100, 23);
            this.btn_kj.TabIndex = 3;
            this.btn_kj.Text = "Könyvjezők";
            this.btn_kj.UseVisualStyleBackColor = true;
            this.btn_kj.Click += new System.EventHandler(this.btn_kj_Click);
            // 
            // cb_ie
            // 
            this.cb_ie.BackColor = System.Drawing.SystemColors.Window;
            this.cb_ie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ie.FormattingEnabled = true;
            this.cb_ie.Location = new System.Drawing.Point(697, 35);
            this.cb_ie.Name = "cb_ie";
            this.cb_ie.Size = new System.Drawing.Size(100, 21);
            this.cb_ie.TabIndex = 4;
            // 
            // ofd_import
            // 
            this.ofd_import.Title = "Könyvjelzők beolvasása fájlból";
            // 
            // sfd_export
            // 
            this.sfd_export.DefaultExt = "txt";
            this.sfd_export.Title = "Könyvjelzők mentése fájlba";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 477);
            this.Controls.Add(this.cb_ie);
            this.Controls.Add(this.btn_kj);
            this.Controls.Add(this.cb_link);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.webBrowser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Super Web Browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_link_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.ComboBox cb_link;
        private System.Windows.Forms.Button btn_kj;
        private System.Windows.Forms.ComboBox cb_ie;
        private System.Windows.Forms.OpenFileDialog ofd_import;
        private System.Windows.Forms.SaveFileDialog sfd_export;
    }
}

