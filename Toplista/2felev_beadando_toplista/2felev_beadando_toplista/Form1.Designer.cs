namespace _2felev_beadando_toplista
{
    partial class Form1_toplista
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
            this.label1_betoltes = new System.Windows.Forms.Label();
            this.button1_betoltes = new System.Windows.Forms.Button();
            this.label1_valasztas = new System.Windows.Forms.Label();
            this.comboBox1_stilus = new System.Windows.Forms.ComboBox();
            this.button1_valasztas = new System.Windows.Forms.Button();
            this.listBox1_lista = new System.Windows.Forms.ListBox();
            this.button1_html = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1_betoltes
            // 
            this.label1_betoltes.AutoSize = true;
            this.label1_betoltes.Location = new System.Drawing.Point(15, 18);
            this.label1_betoltes.Name = "label1_betoltes";
            this.label1_betoltes.Size = new System.Drawing.Size(146, 13);
            this.label1_betoltes.TabIndex = 0;
            this.label1_betoltes.Text = "Töltse be a Zeneszámok fájlt!";
            // 
            // button1_betoltes
            // 
            this.button1_betoltes.Location = new System.Drawing.Point(182, 13);
            this.button1_betoltes.Name = "button1_betoltes";
            this.button1_betoltes.Size = new System.Drawing.Size(75, 23);
            this.button1_betoltes.TabIndex = 1;
            this.button1_betoltes.Text = "Betölt";
            this.button1_betoltes.UseVisualStyleBackColor = true;
            this.button1_betoltes.Click += new System.EventHandler(this.button1_betoltes_Click);
            // 
            // label1_valasztas
            // 
            this.label1_valasztas.AutoSize = true;
            this.label1_valasztas.Location = new System.Drawing.Point(15, 55);
            this.label1_valasztas.Name = "label1_valasztas";
            this.label1_valasztas.Size = new System.Drawing.Size(199, 13);
            this.label1_valasztas.TabIndex = 2;
            this.label1_valasztas.Text = "Válasszon az alábbi zenei stílusok közül!";
            // 
            // comboBox1_stilus
            // 
            this.comboBox1_stilus.Enabled = false;
            this.comboBox1_stilus.FormattingEnabled = true;
            this.comboBox1_stilus.Location = new System.Drawing.Point(18, 71);
            this.comboBox1_stilus.Name = "comboBox1_stilus";
            this.comboBox1_stilus.Size = new System.Drawing.Size(140, 21);
            this.comboBox1_stilus.TabIndex = 3;
            this.comboBox1_stilus.Text = "Válasszon stílust!";
            // 
            // button1_valasztas
            // 
            this.button1_valasztas.Enabled = false;
            this.button1_valasztas.Location = new System.Drawing.Point(182, 71);
            this.button1_valasztas.Name = "button1_valasztas";
            this.button1_valasztas.Size = new System.Drawing.Size(75, 23);
            this.button1_valasztas.TabIndex = 4;
            this.button1_valasztas.Text = "Választ";
            this.button1_valasztas.UseVisualStyleBackColor = true;
            this.button1_valasztas.Click += new System.EventHandler(this.button1_valasztas_Click);
            // 
            // listBox1_lista
            // 
            this.listBox1_lista.FormattingEnabled = true;
            this.listBox1_lista.Location = new System.Drawing.Point(18, 103);
            this.listBox1_lista.Name = "listBox1_lista";
            this.listBox1_lista.Size = new System.Drawing.Size(239, 225);
            this.listBox1_lista.TabIndex = 5;
            // 
            // button1_html
            // 
            this.button1_html.Enabled = false;
            this.button1_html.Location = new System.Drawing.Point(18, 336);
            this.button1_html.Name = "button1_html";
            this.button1_html.Size = new System.Drawing.Size(239, 23);
            this.button1_html.TabIndex = 6;
            this.button1_html.Text = "Megjelenítés HTML-ben";
            this.button1_html.UseVisualStyleBackColor = true;
            this.button1_html.Click += new System.EventHandler(this.button1_html_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1_toplista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 371);
            this.Controls.Add(this.button1_html);
            this.Controls.Add(this.listBox1_lista);
            this.Controls.Add(this.button1_valasztas);
            this.Controls.Add(this.comboBox1_stilus);
            this.Controls.Add(this.label1_valasztas);
            this.Controls.Add(this.button1_betoltes);
            this.Controls.Add(this.label1_betoltes);
            this.Name = "Form1_toplista";
            this.Text = "Toplista";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_betoltes;
        private System.Windows.Forms.Button button1_betoltes;
        private System.Windows.Forms.Label label1_valasztas;
        private System.Windows.Forms.ComboBox comboBox1_stilus;
        private System.Windows.Forms.Button button1_valasztas;
        private System.Windows.Forms.ListBox listBox1_lista;
        private System.Windows.Forms.Button button1_html;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

