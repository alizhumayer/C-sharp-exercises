namespace SHA_256
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
            this.Input_box = new System.Windows.Forms.TextBox();
            this.SHA_btn = new System.Windows.Forms.Button();
            this.Output_box = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Input_box
            // 
            this.Input_box.Location = new System.Drawing.Point(13, 13);
            this.Input_box.Name = "Input_box";
            this.Input_box.Size = new System.Drawing.Size(100, 20);
            this.Input_box.TabIndex = 0;
            // 
            // SHA_btn
            // 
            this.SHA_btn.Location = new System.Drawing.Point(119, 12);
            this.SHA_btn.Name = "SHA_btn";
            this.SHA_btn.Size = new System.Drawing.Size(75, 23);
            this.SHA_btn.TabIndex = 1;
            this.SHA_btn.Text = "SHA256";
            this.SHA_btn.UseVisualStyleBackColor = true;
            this.SHA_btn.Click += new System.EventHandler(this.SHA_btn_Click);
            // 
            // Output_box
            // 
            this.Output_box.AutoSize = true;
            this.Output_box.Location = new System.Drawing.Point(13, 40);
            this.Output_box.Name = "Output_box";
            this.Output_box.Size = new System.Drawing.Size(35, 13);
            this.Output_box.TabIndex = 2;
            this.Output_box.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Output_box);
            this.Controls.Add(this.SHA_btn);
            this.Controls.Add(this.Input_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Input_box;
        private System.Windows.Forms.Button SHA_btn;
        private System.Windows.Forms.Label Output_box;
    }
}

