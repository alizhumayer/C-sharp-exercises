namespace GiftApp
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
            this.LoadFromFileBtn = new System.Windows.Forms.Button();
            this.LoadedDataLb = new System.Windows.Forms.ListBox();
            this.AddToLbBtn = new System.Windows.Forms.Button();
            this.DataAddTb = new System.Windows.Forms.TextBox();
            this.AddedDataLb = new System.Windows.Forms.ListBox();
            this.LoadedFromFileDataLbl = new System.Windows.Forms.Label();
            this.AddedDataLbl = new System.Windows.Forms.Label();
            this.betoltdialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // LoadFromFileBtn
            // 
            this.LoadFromFileBtn.Location = new System.Drawing.Point(13, 13);
            this.LoadFromFileBtn.Name = "LoadFromFileBtn";
            this.LoadFromFileBtn.Size = new System.Drawing.Size(93, 23);
            this.LoadFromFileBtn.TabIndex = 0;
            this.LoadFromFileBtn.Text = "File beolvasása";
            this.LoadFromFileBtn.UseVisualStyleBackColor = true;
            this.LoadFromFileBtn.Click += new System.EventHandler(this.LoadFromFileBtn_Click);
            // 
            // LoadedDataLb
            // 
            this.LoadedDataLb.FormattingEnabled = true;
            this.LoadedDataLb.Location = new System.Drawing.Point(12, 78);
            this.LoadedDataLb.Name = "LoadedDataLb";
            this.LoadedDataLb.Size = new System.Drawing.Size(203, 290);
            this.LoadedDataLb.TabIndex = 1;
            // 
            // AddToLbBtn
            // 
            this.AddToLbBtn.Location = new System.Drawing.Point(282, 38);
            this.AddToLbBtn.Name = "AddToLbBtn";
            this.AddToLbBtn.Size = new System.Drawing.Size(75, 23);
            this.AddToLbBtn.TabIndex = 2;
            this.AddToLbBtn.Text = "Hozzáadás";
            this.AddToLbBtn.UseVisualStyleBackColor = true;
            this.AddToLbBtn.Click += new System.EventHandler(this.AddToLbBtn_Click);
            // 
            // DataAddTb
            // 
            this.DataAddTb.HideSelection = false;
            this.DataAddTb.Location = new System.Drawing.Point(272, 13);
            this.DataAddTb.Name = "DataAddTb";
            this.DataAddTb.Size = new System.Drawing.Size(100, 20);
            this.DataAddTb.TabIndex = 3;
            // 
            // AddedDataLb
            // 
            this.AddedDataLb.FormattingEnabled = true;
            this.AddedDataLb.Location = new System.Drawing.Point(222, 78);
            this.AddedDataLb.Name = "AddedDataLb";
            this.AddedDataLb.Size = new System.Drawing.Size(203, 290);
            this.AddedDataLb.TabIndex = 4;
            // 
            // LoadedFromFileDataLbl
            // 
            this.LoadedFromFileDataLbl.AutoSize = true;
            this.LoadedFromFileDataLbl.Location = new System.Drawing.Point(12, 62);
            this.LoadedFromFileDataLbl.Name = "LoadedFromFileDataLbl";
            this.LoadedFromFileDataLbl.Size = new System.Drawing.Size(128, 13);
            this.LoadedFromFileDataLbl.TabIndex = 9;
            this.LoadedFromFileDataLbl.Text = "Fileból beolvasott adatok:";
            // 
            // AddedDataLbl
            // 
            this.AddedDataLbl.AutoSize = true;
            this.AddedDataLbl.Location = new System.Drawing.Point(221, 62);
            this.AddedDataLbl.Name = "AddedDataLbl";
            this.AddedDataLbl.Size = new System.Drawing.Size(100, 13);
            this.AddedDataLbl.TabIndex = 10;
            this.AddedDataLbl.Text = "Hozzáadott adatok:";
            // 
            // betoltdialog
            // 
            this.betoltdialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.AddedDataLbl);
            this.Controls.Add(this.LoadedFromFileDataLbl);
            this.Controls.Add(this.AddedDataLb);
            this.Controls.Add(this.DataAddTb);
            this.Controls.Add(this.AddToLbBtn);
            this.Controls.Add(this.LoadedDataLb);
            this.Controls.Add(this.LoadFromFileBtn);
            this.Name = "Form1";
            this.Text = "Ajándékos Szoftver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadFromFileBtn;
        private System.Windows.Forms.ListBox LoadedDataLb;
        private System.Windows.Forms.Button AddToLbBtn;
        private System.Windows.Forms.TextBox DataAddTb;
        private System.Windows.Forms.ListBox AddedDataLb;
        private System.Windows.Forms.Label LoadedFromFileDataLbl;
        private System.Windows.Forms.Label AddedDataLbl;
        private System.Windows.Forms.OpenFileDialog betoltdialog;
    }
}

