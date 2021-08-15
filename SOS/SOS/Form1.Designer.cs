
namespace SOS
{
    partial class Form1
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
            this.SiraliPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Puan1 = new System.Windows.Forms.Label();
            this.Puan2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SiraliPanel
            // 
            this.SiraliPanel.Location = new System.Drawing.Point(2, 61);
            this.SiraliPanel.Name = "SiraliPanel";
            this.SiraliPanel.Size = new System.Drawing.Size(789, 811);
            this.SiraliPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "1. OYUNCU";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(581, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "2. OYUNCU";
            // 
            // Puan1
            // 
            this.Puan1.AutoSize = true;
            this.Puan1.Location = new System.Drawing.Point(118, 27);
            this.Puan1.Name = "Puan1";
            this.Puan1.Size = new System.Drawing.Size(0, 13);
            this.Puan1.TabIndex = 3;
            // 
            // Puan2
            // 
            this.Puan2.AutoSize = true;
            this.Puan2.Location = new System.Drawing.Point(697, 27);
            this.Puan2.Name = "Puan2";
            this.Puan2.Size = new System.Drawing.Size(0, 13);
            this.Puan2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 888);
            this.Controls.Add(this.Puan2);
            this.Controls.Add(this.Puan1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SiraliPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel SiraliPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Puan1;
        private System.Windows.Forms.Label Puan2;
    }
}

