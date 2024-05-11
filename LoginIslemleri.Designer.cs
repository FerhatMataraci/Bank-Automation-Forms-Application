namespace OdevCFinal
{
    partial class LoginIslemleri
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
            this.btnLogin = new System.Windows.Forms.Button();
            this.grpbxLogin = new System.Windows.Forms.GroupBox();
            this.btnKayıt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.txtMusteriNo = new System.Windows.Forms.TextBox();
            this.grpbxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Tan;
            this.btnLogin.Location = new System.Drawing.Point(49, 383);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(120, 61);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "GİRİŞ YAP";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.button1_Click);
            // 
            // grpbxLogin
            // 
            this.grpbxLogin.BackColor = System.Drawing.Color.Bisque;
            this.grpbxLogin.Controls.Add(this.btnKayıt);
            this.grpbxLogin.Controls.Add(this.button1);
            this.grpbxLogin.Controls.Add(this.label3);
            this.grpbxLogin.Controls.Add(this.btnLogin);
            this.grpbxLogin.Controls.Add(this.label4);
            this.grpbxLogin.Controls.Add(this.txtSifre);
            this.grpbxLogin.Controls.Add(this.txtMusteriNo);
            this.grpbxLogin.Cursor = System.Windows.Forms.Cursors.Cross;
            this.grpbxLogin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grpbxLogin.Location = new System.Drawing.Point(737, 253);
            this.grpbxLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbxLogin.Name = "grpbxLogin";
            this.grpbxLogin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpbxLogin.Size = new System.Drawing.Size(688, 493);
            this.grpbxLogin.TabIndex = 5;
            this.grpbxLogin.TabStop = false;
            this.grpbxLogin.Text = "Login";
            // 
            // btnKayıt
            // 
            this.btnKayıt.BackColor = System.Drawing.Color.Tan;
            this.btnKayıt.Location = new System.Drawing.Point(259, 383);
            this.btnKayıt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnKayıt.Name = "btnKayıt";
            this.btnKayıt.Size = new System.Drawing.Size(120, 61);
            this.btnKayıt.TabIndex = 10;
            this.btnKayıt.Text = "KAYIT OL";
            this.btnKayıt.UseVisualStyleBackColor = false;
            this.btnKayıt.Click += new System.EventHandler(this.btnKayıt_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tan;
            this.button1.Location = new System.Drawing.Point(466, 383);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 61);
            this.button1.TabIndex = 9;
            this.button1.Text = "ÇIKIŞ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 215);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Müşteri No";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(197, 215);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(390, 22);
            this.txtSifre.TabIndex = 6;
            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.Location = new System.Drawing.Point(197, 72);
            this.txtMusteriNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.Size = new System.Drawing.Size(390, 22);
            this.txtMusteriNo.TabIndex = 5;
            // 
            // LoginIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(1283, 675);
            this.Controls.Add(this.grpbxLogin);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "LoginIslemleri";
            this.Text = "LoginIslemleri";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.LoginIslemleri_Load);
            this.grpbxLogin.ResumeLayout(false);
            this.grpbxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.GroupBox grpbxLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.TextBox txtMusteriNo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnKayıt;
    }
}