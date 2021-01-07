namespace Reg2
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
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.tb_passWord = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_enter = new System.Windows.Forms.Button();
            this.btn_regLap = new System.Windows.Forms.Button();
            this.tb_passWord2 = new System.Windows.Forms.TextBox();
            this.tb_pwEmlek = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_pwHelp = new System.Windows.Forms.Button();
            this.tb_remUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_remText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_userName
            // 
            this.tb_userName.Location = new System.Drawing.Point(100, 24);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(142, 20);
            this.tb_userName.TabIndex = 0;
            this.tb_userName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_userName_KeyDown);
            // 
            // tb_passWord
            // 
            this.tb_passWord.Location = new System.Drawing.Point(100, 50);
            this.tb_passWord.Name = "tb_passWord";
            this.tb_passWord.PasswordChar = '*';
            this.tb_passWord.Size = new System.Drawing.Size(142, 20);
            this.tb_passWord.TabIndex = 1;
            this.tb_passWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_passWord_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Felhasználónév";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Jelszó";
            // 
            // btn_enter
            // 
            this.btn_enter.Location = new System.Drawing.Point(315, 24);
            this.btn_enter.Name = "btn_enter";
            this.btn_enter.Size = new System.Drawing.Size(93, 23);
            this.btn_enter.TabIndex = 4;
            this.btn_enter.Text = "Belépés";
            this.btn_enter.UseVisualStyleBackColor = true;
            this.btn_enter.Click += new System.EventHandler(this.btn_enter_Click);
            // 
            // btn_regLap
            // 
            this.btn_regLap.Location = new System.Drawing.Point(315, 50);
            this.btn_regLap.Name = "btn_regLap";
            this.btn_regLap.Size = new System.Drawing.Size(93, 23);
            this.btn_regLap.TabIndex = 5;
            this.btn_regLap.Text = "Regisztráció";
            this.btn_regLap.UseVisualStyleBackColor = true;
            this.btn_regLap.Click += new System.EventHandler(this.btn_regLap_Click);
            // 
            // tb_passWord2
            // 
            this.tb_passWord2.Location = new System.Drawing.Point(100, 77);
            this.tb_passWord2.Name = "tb_passWord2";
            this.tb_passWord2.PasswordChar = '*';
            this.tb_passWord2.Size = new System.Drawing.Size(142, 20);
            this.tb_passWord2.TabIndex = 6;
            // 
            // tb_pwEmlek
            // 
            this.tb_pwEmlek.Location = new System.Drawing.Point(100, 104);
            this.tb_pwEmlek.Name = "tb_pwEmlek";
            this.tb_pwEmlek.Size = new System.Drawing.Size(142, 20);
            this.tb_pwEmlek.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Jelszó újra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Emlékeztető";
            // 
            // btn_pwHelp
            // 
            this.btn_pwHelp.Location = new System.Drawing.Point(13, 163);
            this.btn_pwHelp.Name = "btn_pwHelp";
            this.btn_pwHelp.Size = new System.Drawing.Size(129, 23);
            this.btn_pwHelp.TabIndex = 10;
            this.btn_pwHelp.Text = "Elfelejtett jelszó";
            this.btn_pwHelp.UseVisualStyleBackColor = true;
            this.btn_pwHelp.Click += new System.EventHandler(this.btn_pwHelp_Click);
            // 
            // tb_remUser
            // 
            this.tb_remUser.Location = new System.Drawing.Point(100, 192);
            this.tb_remUser.Name = "tb_remUser";
            this.tb_remUser.Size = new System.Drawing.Size(142, 20);
            this.tb_remUser.TabIndex = 11;
            this.tb_remUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_remUser_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Felhasználónév";
            // 
            // tb_remText
            // 
            this.tb_remText.Location = new System.Drawing.Point(100, 219);
            this.tb_remText.Name = "tb_remText";
            this.tb_remText.ReadOnly = true;
            this.tb_remText.Size = new System.Drawing.Size(187, 20);
            this.tb_remText.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Emlékeztető";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 288);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_remText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_remUser);
            this.Controls.Add(this.btn_pwHelp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_pwEmlek);
            this.Controls.Add(this.tb_passWord2);
            this.Controls.Add(this.btn_regLap);
            this.Controls.Add(this.btn_enter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_passWord);
            this.Controls.Add(this.tb_userName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_userName;
        private System.Windows.Forms.TextBox tb_passWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_enter;
        private System.Windows.Forms.Button btn_regLap;
        private System.Windows.Forms.TextBox tb_passWord2;
        private System.Windows.Forms.TextBox tb_pwEmlek;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_pwHelp;
        private System.Windows.Forms.TextBox tb_remUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_remText;
        private System.Windows.Forms.Label label6;
    }
}

