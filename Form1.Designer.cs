namespace OdevCFinal
{
    partial class FrmBankaArayuz
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bankaİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paraİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.havaleİşlemleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gelirGiderRaporlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hesapSilmeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hakkındaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iletişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bankaTarihiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sSSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lvHesapHareketi = new System.Windows.Forms.ListView();
            this.lblMusteriNo = new System.Windows.Forms.Label();
            this.lblTcKimlikNo = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSicilNo = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bankaİşlemleriToolStripMenuItem,
            this.hakkındaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1283, 26);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bankaİşlemleriToolStripMenuItem
            // 
            this.bankaİşlemleriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paraİşlemleriToolStripMenuItem,
            this.havaleİşlemleriToolStripMenuItem,
            this.gelirGiderRaporlarıToolStripMenuItem,
            this.hesapSilmeToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.bankaİşlemleriToolStripMenuItem.Name = "bankaİşlemleriToolStripMenuItem";
            this.bankaİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.bankaİşlemleriToolStripMenuItem.Text = "Banka İşlemleri";
            // 
            // paraİşlemleriToolStripMenuItem
            // 
            this.paraİşlemleriToolStripMenuItem.Name = "paraİşlemleriToolStripMenuItem";
            this.paraİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.paraİşlemleriToolStripMenuItem.Text = "Para İşlemleri";
            this.paraİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.paraİşlemleriToolStripMenuItem_Click);
            // 
            // havaleİşlemleriToolStripMenuItem
            // 
            this.havaleİşlemleriToolStripMenuItem.Name = "havaleİşlemleriToolStripMenuItem";
            this.havaleİşlemleriToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.havaleİşlemleriToolStripMenuItem.Text = "Havale İşlemleri";
            this.havaleİşlemleriToolStripMenuItem.Click += new System.EventHandler(this.havaleİşlemleriToolStripMenuItem_Click);
            // 
            // gelirGiderRaporlarıToolStripMenuItem
            // 
            this.gelirGiderRaporlarıToolStripMenuItem.Name = "gelirGiderRaporlarıToolStripMenuItem";
            this.gelirGiderRaporlarıToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.gelirGiderRaporlarıToolStripMenuItem.Text = "Gelir-Gider Raporları";
            this.gelirGiderRaporlarıToolStripMenuItem.Click += new System.EventHandler(this.gelirGiderRaporlarıToolStripMenuItem_Click);
            // 
            // hesapSilmeToolStripMenuItem
            // 
            this.hesapSilmeToolStripMenuItem.Name = "hesapSilmeToolStripMenuItem";
            this.hesapSilmeToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.hesapSilmeToolStripMenuItem.Text = "Hesap Silme";
            this.hesapSilmeToolStripMenuItem.Click += new System.EventHandler(this.hesapSilmeToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // hakkındaToolStripMenuItem
            // 
            this.hakkındaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iletişimToolStripMenuItem,
            this.bankaTarihiToolStripMenuItem,
            this.sSSToolStripMenuItem});
            this.hakkındaToolStripMenuItem.Name = "hakkındaToolStripMenuItem";
            this.hakkındaToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.hakkındaToolStripMenuItem.Text = "Hakkında";
            // 
            // iletişimToolStripMenuItem
            // 
            this.iletişimToolStripMenuItem.Name = "iletişimToolStripMenuItem";
            this.iletişimToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.iletişimToolStripMenuItem.Text = "İletişim";
            // 
            // bankaTarihiToolStripMenuItem
            // 
            this.bankaTarihiToolStripMenuItem.Name = "bankaTarihiToolStripMenuItem";
            this.bankaTarihiToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.bankaTarihiToolStripMenuItem.Text = "Banka Tarihi";
            // 
            // sSSToolStripMenuItem
            // 
            this.sSSToolStripMenuItem.Name = "sSSToolStripMenuItem";
            this.sSSToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.sSSToolStripMenuItem.Text = "S.S.S.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(44, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 69);
            this.label1.TabIndex = 3;
            this.label1.Text = "HESAP BİLGİLERİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Bisque;
            this.label2.Location = new System.Drawing.Point(85, 280);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "BAKİYE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Bisque;
            this.label3.Location = new System.Drawing.Point(53, 223);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "MÜŞTERİ NO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Bisque;
            this.label4.Location = new System.Drawing.Point(53, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "TC Kimlik No";
            // 
            // lvHesapHareketi
            // 
            this.lvHesapHareketi.HideSelection = false;
            this.lvHesapHareketi.Location = new System.Drawing.Point(907, 128);
            this.lvHesapHareketi.Name = "lvHesapHareketi";
            this.lvHesapHareketi.Size = new System.Drawing.Size(473, 393);
            this.lvHesapHareketi.TabIndex = 8;
            this.lvHesapHareketi.UseCompatibleStateImageBehavior = false;
            this.lvHesapHareketi.View = System.Windows.Forms.View.List;
            // 
            // lblMusteriNo
            // 
            this.lblMusteriNo.AutoSize = true;
            this.lblMusteriNo.BackColor = System.Drawing.Color.OliveDrab;
            this.lblMusteriNo.Location = new System.Drawing.Point(175, 223);
            this.lblMusteriNo.Name = "lblMusteriNo";
            this.lblMusteriNo.Size = new System.Drawing.Size(79, 17);
            this.lblMusteriNo.TabIndex = 10;
            this.lblMusteriNo.Text = "Müşteri NO";
            // 
            // lblTcKimlikNo
            // 
            this.lblTcKimlikNo.AutoSize = true;
            this.lblTcKimlikNo.BackColor = System.Drawing.Color.OliveDrab;
            this.lblTcKimlikNo.Location = new System.Drawing.Point(175, 168);
            this.lblTcKimlikNo.Name = "lblTcKimlikNo";
            this.lblTcKimlikNo.Size = new System.Drawing.Size(49, 17);
            this.lblTcKimlikNo.TabIndex = 11;
            this.lblTcKimlikNo.Text = "Tc NO";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.BackColor = System.Drawing.Color.OliveDrab;
            this.lblBakiye.Location = new System.Drawing.Point(175, 280);
            this.lblBakiye.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(56, 17);
            this.lblBakiye.TabIndex = 12;
            this.lblBakiye.Text = "BAKİYE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Bisque;
            this.label5.Location = new System.Drawing.Point(64, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "AD SOYAD:";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.BackColor = System.Drawing.Color.OliveDrab;
            this.lblAdSoyad.Location = new System.Drawing.Point(175, 332);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(83, 17);
            this.lblAdSoyad.TabIndex = 14;
            this.lblAdSoyad.Text = "AD SOYAD:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Bisque;
            this.label6.Location = new System.Drawing.Point(85, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Sicil No";
            // 
            // lblSicilNo
            // 
            this.lblSicilNo.AutoSize = true;
            this.lblSicilNo.BackColor = System.Drawing.Color.OliveDrab;
            this.lblSicilNo.Location = new System.Drawing.Point(175, 389);
            this.lblSicilNo.Name = "lblSicilNo";
            this.lblSicilNo.Size = new System.Drawing.Size(55, 17);
            this.lblSicilNo.TabIndex = 16;
            this.lblSicilNo.Text = "Sicil No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(895, 35);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(665, 69);
            this.label7.TabIndex = 18;
            this.label7.Text = "HESAP HAREKETLERİ";
            // 
            // FrmBankaArayuz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1283, 675);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblSicilNo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.lblTcKimlikNo);
            this.Controls.Add(this.lblMusteriNo);
            this.Controls.Add(this.lvHesapHareketi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmBankaArayuz";
            this.Text = "BANKA X";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBankaArayuz_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bankaİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paraİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem havaleİşlemleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gelirGiderRaporlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hesapSilmeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hakkındaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iletişimToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bankaTarihiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sSSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView lvHesapHareketi;
        private System.Windows.Forms.Label lblMusteriNo;
        private System.Windows.Forms.Label lblTcKimlikNo;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSicilNo;
        private System.Windows.Forms.Label label7;
    }
}

