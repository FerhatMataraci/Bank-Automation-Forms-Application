namespace OdevCFinal
{
    partial class HavaleIslemleri
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
            this.btnHavale = new System.Windows.Forms.Button();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.txtMusteriNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHavale
            // 
            this.btnHavale.BackColor = System.Drawing.Color.Firebrick;
            this.btnHavale.ForeColor = System.Drawing.Color.RosyBrown;
            this.btnHavale.Location = new System.Drawing.Point(369, 303);
            this.btnHavale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHavale.Name = "btnHavale";
            this.btnHavale.Size = new System.Drawing.Size(201, 93);
            this.btnHavale.TabIndex = 0;
            this.btnHavale.Text = "HAVALE ET";
            this.btnHavale.UseVisualStyleBackColor = false;
            this.btnHavale.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(367, 137);
            this.txtMiktar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(204, 22);
            this.txtMiktar.TabIndex = 1;
            // 
            // txtMusteriNo
            // 
            this.txtMusteriNo.Location = new System.Drawing.Point(369, 202);
            this.txtMusteriNo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMusteriNo.Name = "txtMusteriNo";
            this.txtMusteriNo.Size = new System.Drawing.Size(203, 22);
            this.txtMusteriNo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Location = new System.Drawing.Point(273, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Para Miktarı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.LightCoral;
            this.label2.Location = new System.Drawing.Point(273, 205);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Müşteri No:";
            // 
            // HavaleIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1003, 552);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMusteriNo);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.btnHavale);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HavaleIslemleri";
            this.Text = "HavaleIslemleri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHavale;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.TextBox txtMusteriNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}