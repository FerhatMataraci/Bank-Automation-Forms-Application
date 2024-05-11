namespace OdevCFinal
{
    partial class GelirGiderFormu
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
            this.lblGelir = new System.Windows.Forms.Label();
            this.lblGider = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblToplamPara = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGelir
            // 
            this.lblGelir.AutoSize = true;
            this.lblGelir.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGelir.Location = new System.Drawing.Point(367, 78);
            this.lblGelir.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGelir.Name = "lblGelir";
            this.lblGelir.Size = new System.Drawing.Size(546, 54);
            this.lblGelir.TabIndex = 1;
            this.lblGelir.Text = "GELİR GİDER DURUMU";
            // 
            // lblGider
            // 
            this.lblGider.AutoSize = true;
            this.lblGider.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblGider.Location = new System.Drawing.Point(367, 197);
            this.lblGider.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGider.Name = "lblGider";
            this.lblGider.Size = new System.Drawing.Size(546, 54);
            this.lblGider.TabIndex = 2;
            this.lblGider.Text = "GELİR GİDER DURUMU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(46, 78);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "Gelen para:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(46, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(267, 54);
            this.label2.TabIndex = 5;
            this.label2.Text = "Giden para:";
            // 
            // lblToplamPara
            // 
            this.lblToplamPara.AutoSize = true;
            this.lblToplamPara.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamPara.Location = new System.Drawing.Point(367, 351);
            this.lblToplamPara.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblToplamPara.Name = "lblToplamPara";
            this.lblToplamPara.Size = new System.Drawing.Size(469, 54);
            this.lblToplamPara.TabIndex = 6;
            this.lblToplamPara.Text = "Toplam Para Durumu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(46, 351);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(298, 54);
            this.label3.TabIndex = 7;
            this.label3.Text = "Toplam para:";
            // 
            // GelirGiderFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 675);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblToplamPara);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblGider);
            this.Controls.Add(this.lblGelir);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GelirGiderFormu";
            this.Text = "GelirGiderFormu";
            this.Load += new System.EventHandler(this.GelirGiderFormu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGelir;
        private System.Windows.Forms.Label lblGider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblToplamPara;
        private System.Windows.Forms.Label label3;
    }
}