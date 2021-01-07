namespace oszthato
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
            this.list_box_gener = new System.Windows.Forms.ListBox();
            this.general_button = new System.Windows.Forms.Button();
            this.list_box_eredmeny = new System.Windows.Forms.ListBox();
            this.mutat_button = new System.Windows.Forms.Button();
            this.chk_list_box = new System.Windows.Forms.CheckedListBox();
            this.es = new System.Windows.Forms.RadioButton();
            this.vagy = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // list_box_gener
            // 
            this.list_box_gener.FormattingEnabled = true;
            this.list_box_gener.Location = new System.Drawing.Point(13, 42);
            this.list_box_gener.Name = "list_box_gener";
            this.list_box_gener.Size = new System.Drawing.Size(120, 472);
            this.list_box_gener.TabIndex = 0;
            // 
            // general_button
            // 
            this.general_button.Location = new System.Drawing.Point(13, 13);
            this.general_button.Name = "general_button";
            this.general_button.Size = new System.Drawing.Size(120, 23);
            this.general_button.TabIndex = 1;
            this.general_button.Text = "Generál";
            this.general_button.UseVisualStyleBackColor = true;
            this.general_button.Click += new System.EventHandler(this.general_button_Click);
            // 
            // list_box_eredmeny
            // 
            this.list_box_eredmeny.FormattingEnabled = true;
            this.list_box_eredmeny.Location = new System.Drawing.Point(288, 42);
            this.list_box_eredmeny.Name = "list_box_eredmeny";
            this.list_box_eredmeny.Size = new System.Drawing.Size(120, 472);
            this.list_box_eredmeny.TabIndex = 2;
            // 
            // mutat_button
            // 
            this.mutat_button.Location = new System.Drawing.Point(139, 42);
            this.mutat_button.Name = "mutat_button";
            this.mutat_button.Size = new System.Drawing.Size(143, 23);
            this.mutat_button.TabIndex = 3;
            this.mutat_button.Text = "Mutat";
            this.mutat_button.UseVisualStyleBackColor = true;
            this.mutat_button.Click += new System.EventHandler(this.mutat_button_Click);
            // 
            // chk_list_box
            // 
            this.chk_list_box.FormattingEnabled = true;
            this.chk_list_box.Items.AddRange(new object[] {
            "páros számok",
            "páratlan számok",
            "3-mal osztható számok",
            "5-tel osztható számok",
            "7-tel osztható számok",
            "négyzetszámok",
            "primszámok"});
            this.chk_list_box.Location = new System.Drawing.Point(139, 71);
            this.chk_list_box.Name = "chk_list_box";
            this.chk_list_box.Size = new System.Drawing.Size(143, 319);
            this.chk_list_box.TabIndex = 4;
            // 
            // es
            // 
            this.es.AutoSize = true;
            this.es.Location = new System.Drawing.Point(164, 433);
            this.es.Name = "es";
            this.es.Size = new System.Drawing.Size(37, 17);
            this.es.TabIndex = 5;
            this.es.TabStop = true;
            this.es.Text = "És";
            this.es.UseVisualStyleBackColor = true;
            // 
            // vagy
            // 
            this.vagy.AutoSize = true;
            this.vagy.Location = new System.Drawing.Point(207, 433);
            this.vagy.Name = "vagy";
            this.vagy.Size = new System.Drawing.Size(49, 17);
            this.vagy.TabIndex = 6;
            this.vagy.TabStop = true;
            this.vagy.Text = "Vagy";
            this.vagy.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 552);
            this.Controls.Add(this.vagy);
            this.Controls.Add(this.es);
            this.Controls.Add(this.chk_list_box);
            this.Controls.Add(this.mutat_button);
            this.Controls.Add(this.list_box_eredmeny);
            this.Controls.Add(this.general_button);
            this.Controls.Add(this.list_box_gener);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox list_box_gener;
        private System.Windows.Forms.Button general_button;
        private System.Windows.Forms.ListBox list_box_eredmeny;
        private System.Windows.Forms.Button mutat_button;
        private System.Windows.Forms.CheckedListBox chk_list_box;
        private System.Windows.Forms.RadioButton es;
        private System.Windows.Forms.RadioButton vagy;
    }
}

