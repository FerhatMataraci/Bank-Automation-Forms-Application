namespace OdevCFinal
{
    partial class ParaIslemleri
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
            this.btnExit = new System.Windows.Forms.Button();
            this.txtParaGiris = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYatırma = new System.Windows.Forms.Button();
            this.grpPara = new System.Windows.Forms.GroupBox();
            this.btnParaCek = new System.Windows.Forms.Button();
            this.grpPara.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Location = new System.Drawing.Point(681, 492);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 37);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "ÇIKIŞ";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtParaGiris
            // 
            this.txtParaGiris.BackColor = System.Drawing.SystemColors.Info;
            this.txtParaGiris.Location = new System.Drawing.Point(373, 74);
            this.txtParaGiris.Margin = new System.Windows.Forms.Padding(2);
            this.txtParaGiris.Name = "txtParaGiris";
            this.txtParaGiris.Size = new System.Drawing.Size(283, 22);
            this.txtParaGiris.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(78, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Para Tutarını Giriniz: ";
            // 
            // btnYatırma
            // 
            this.btnYatırma.BackColor = System.Drawing.SystemColors.Info;
            this.btnYatırma.Location = new System.Drawing.Point(83, 229);
            this.btnYatırma.Margin = new System.Windows.Forms.Padding(2);
            this.btnYatırma.Name = "btnYatırma";
            this.btnYatırma.Size = new System.Drawing.Size(258, 44);
            this.btnYatırma.TabIndex = 6;
            this.btnYatırma.Text = "Para Yatır";
            this.btnYatırma.UseVisualStyleBackColor = false;
            this.btnYatırma.Click += new System.EventHandler(this.btnYatırma_Click);
            // 
            // grpPara
            // 
            this.grpPara.BackColor = System.Drawing.SystemColors.MenuBar;
            this.grpPara.Controls.Add(this.btnParaCek);
            this.grpPara.Controls.Add(this.btnExit);
            this.grpPara.Controls.Add(this.label1);
            this.grpPara.Controls.Add(this.btnYatırma);
            this.grpPara.Controls.Add(this.txtParaGiris);
            this.grpPara.Location = new System.Drawing.Point(144, 32);
            this.grpPara.Margin = new System.Windows.Forms.Padding(2);
            this.grpPara.Name = "grpPara";
            this.grpPara.Padding = new System.Windows.Forms.Padding(2);
            this.grpPara.Size = new System.Drawing.Size(792, 533);
            this.grpPara.TabIndex = 7;
            this.grpPara.TabStop = false;
            this.grpPara.Text = "Para İşlemleri";
            // 
            // btnParaCek
            // 
            this.btnParaCek.BackColor = System.Drawing.SystemColors.Info;
            this.btnParaCek.Location = new System.Drawing.Point(459, 229);
            this.btnParaCek.Margin = new System.Windows.Forms.Padding(2);
            this.btnParaCek.Name = "btnParaCek";
            this.btnParaCek.Size = new System.Drawing.Size(258, 44);
            this.btnParaCek.TabIndex = 7;
            this.btnParaCek.Text = "Para Çek";
            this.btnParaCek.UseVisualStyleBackColor = false;
            this.btnParaCek.Click += new System.EventHandler(this.btnParaCek_Click);
            // 
            // ParaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1045, 611);
            this.Controls.Add(this.grpPara);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ParaIslemleri";
            this.Text = "ParaIslemleri";
            this.grpPara.ResumeLayout(false);
            this.grpPara.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtParaGiris;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnYatırma;
        private System.Windows.Forms.GroupBox grpPara;
        private System.Windows.Forms.Button btnParaCek;
    }
}