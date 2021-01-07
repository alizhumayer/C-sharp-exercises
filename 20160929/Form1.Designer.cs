namespace _20160929
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
            this.btn_Bezar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btn_megnyitas = new System.Windows.Forms.Button();
            this.btn_Atlag = new System.Windows.Forms.Button();
            this.btn_sulyki = new System.Windows.Forms.Button();
            this.btn_legnhal = new System.Windows.Forms.Button();
            this.leghhal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_kiir = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btn_Bezar
            // 
            this.btn_Bezar.Location = new System.Drawing.Point(497, 13);
            this.btn_Bezar.Name = "btn_Bezar";
            this.btn_Bezar.Size = new System.Drawing.Size(132, 23);
            this.btn_Bezar.TabIndex = 0;
            this.btn_Bezar.Text = "Bezarás";
            this.btn_Bezar.UseVisualStyleBackColor = true;
            this.btn_Bezar.Click += new System.EventHandler(this.btn_Bezar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btn_megnyitas
            // 
            this.btn_megnyitas.Location = new System.Drawing.Point(24, 12);
            this.btn_megnyitas.Name = "btn_megnyitas";
            this.btn_megnyitas.Size = new System.Drawing.Size(155, 23);
            this.btn_megnyitas.TabIndex = 1;
            this.btn_megnyitas.Text = "Megnyitás";
            this.btn_megnyitas.UseVisualStyleBackColor = true;
            this.btn_megnyitas.Click += new System.EventHandler(this.btn_megnyitas_Click);
            // 
            // btn_Atlag
            // 
            this.btn_Atlag.Enabled = false;
            this.btn_Atlag.Location = new System.Drawing.Point(13, 520);
            this.btn_Atlag.Name = "btn_Atlag";
            this.btn_Atlag.Size = new System.Drawing.Size(173, 23);
            this.btn_Atlag.TabIndex = 2;
            this.btn_Atlag.Text = "Átlag";
            this.btn_Atlag.UseVisualStyleBackColor = true;
            this.btn_Atlag.Click += new System.EventHandler(this.btn_Atlag_Click);
            // 
            // btn_sulyki
            // 
            this.btn_sulyki.Enabled = false;
            this.btn_sulyki.Location = new System.Drawing.Point(208, 519);
            this.btn_sulyki.Name = "btn_sulyki";
            this.btn_sulyki.Size = new System.Drawing.Size(147, 23);
            this.btn_sulyki.TabIndex = 3;
            this.btn_sulyki.Text = "sulyok külön tömbbe";
            this.btn_sulyki.UseVisualStyleBackColor = true;
            this.btn_sulyki.Click += new System.EventHandler(this.btn_sulyki_Click);
            // 
            // btn_legnhal
            // 
            this.btn_legnhal.Enabled = false;
            this.btn_legnhal.Location = new System.Drawing.Point(376, 520);
            this.btn_legnhal.Name = "btn_legnhal";
            this.btn_legnhal.Size = new System.Drawing.Size(165, 23);
            this.btn_legnhal.TabIndex = 4;
            this.btn_legnhal.Text = "Legnehezebb hal";
            this.btn_legnhal.UseVisualStyleBackColor = true;
            this.btn_legnhal.Click += new System.EventHandler(this.btn_legnhal_Click);
            // 
            // leghhal
            // 
            this.leghhal.Enabled = false;
            this.leghhal.Location = new System.Drawing.Point(376, 491);
            this.leghhal.Name = "leghhal";
            this.leghhal.Size = new System.Drawing.Size(165, 23);
            this.leghhal.TabIndex = 5;
            this.leghhal.Text = "Leghosszabb hal";
            this.leghhal.UseVisualStyleBackColor = true;
            this.leghhal.Click += new System.EventHandler(this.leghhal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(547, 501);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // btn_kiir
            // 
            this.btn_kiir.Enabled = false;
            this.btn_kiir.Location = new System.Drawing.Point(24, 42);
            this.btn_kiir.Name = "btn_kiir";
            this.btn_kiir.Size = new System.Drawing.Size(155, 23);
            this.btn_kiir.TabIndex = 7;
            this.btn_kiir.Text = "Kiíratás fájlba";
            this.btn_kiir.UseVisualStyleBackColor = true;
            this.btn_kiir.Click += new System.EventHandler(this.btn_kiir_Click);
            // 
            // saveFileDialog1
            // 
            
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 576);
            this.ControlBox = false;
            this.Controls.Add(this.btn_kiir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leghhal);
            this.Controls.Add(this.btn_legnhal);
            this.Controls.Add(this.btn_sulyki);
            this.Controls.Add(this.btn_Atlag);
            this.Controls.Add(this.btn_megnyitas);
            this.Controls.Add(this.btn_Bezar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Halak és fogások";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Bezar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btn_megnyitas;
        private System.Windows.Forms.Button btn_Atlag;
        private System.Windows.Forms.Button btn_sulyki;
        private System.Windows.Forms.Button btn_legnhal;
        private System.Windows.Forms.Button leghhal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_kiir;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

