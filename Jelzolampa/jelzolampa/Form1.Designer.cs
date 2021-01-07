namespace jelzolampa
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
            this.l_piros = new System.Windows.Forms.Label();
            this.l_zold = new System.Windows.Forms.Label();
            this.l_sarga = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_piros
            // 
            this.l_piros.BackColor = System.Drawing.SystemColors.Window;
            this.l_piros.Image = ((System.Drawing.Image)(resources.GetObject("l_piros.Image")));
            this.l_piros.Location = new System.Drawing.Point(13, 9);
            this.l_piros.Name = "l_piros";
            this.l_piros.Size = new System.Drawing.Size(100, 100);
            this.l_piros.TabIndex = 0;
            this.l_piros.Visible = false;
            // 
            // l_zold
            // 
            this.l_zold.BackColor = System.Drawing.SystemColors.Window;
            this.l_zold.Image = ((System.Drawing.Image)(resources.GetObject("l_zold.Image")));
            this.l_zold.Location = new System.Drawing.Point(13, 287);
            this.l_zold.Name = "l_zold";
            this.l_zold.Size = new System.Drawing.Size(100, 100);
            this.l_zold.TabIndex = 1;
            this.l_zold.Visible = false;
            // 
            // l_sarga
            // 
            this.l_sarga.BackColor = System.Drawing.SystemColors.Window;
            this.l_sarga.Image = ((System.Drawing.Image)(resources.GetObject("l_sarga.Image")));
            this.l_sarga.Location = new System.Drawing.Point(13, 145);
            this.l_sarga.Name = "l_sarga";
            this.l_sarga.Size = new System.Drawing.Size(100, 100);
            this.l_sarga.TabIndex = 2;
            this.l_sarga.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Átváltás";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 473);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.l_sarga);
            this.Controls.Add(this.l_zold);
            this.Controls.Add(this.l_piros);
            this.Name = "Form1";
            this.Text = "Közlekedési lámpa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label l_piros;
        private System.Windows.Forms.Label l_zold;
        private System.Windows.Forms.Label l_sarga;
        private System.Windows.Forms.Button button1;
    }
}

