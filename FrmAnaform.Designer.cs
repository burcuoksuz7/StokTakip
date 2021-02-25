
namespace StokTakipProje
{
    partial class FrmAnaform
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
            this.BtnKategoriIslemleri = new System.Windows.Forms.Button();
            this.BtnUrunIslemleri = new System.Windows.Forms.Button();
            this.BtnIstatistikler = new System.Windows.Forms.Button();
            this.BtnMusteri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnKategoriIslemleri
            // 
            this.BtnKategoriIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnKategoriIslemleri.Location = new System.Drawing.Point(28, 28);
            this.BtnKategoriIslemleri.Name = "BtnKategoriIslemleri";
            this.BtnKategoriIslemleri.Size = new System.Drawing.Size(137, 119);
            this.BtnKategoriIslemleri.TabIndex = 0;
            this.BtnKategoriIslemleri.Text = "Kategori İşlemleri";
            this.BtnKategoriIslemleri.UseVisualStyleBackColor = true;
            this.BtnKategoriIslemleri.Click += new System.EventHandler(this.BtnKategoriIslemleri_Click);
            // 
            // BtnUrunIslemleri
            // 
            this.BtnUrunIslemleri.Location = new System.Drawing.Point(178, 28);
            this.BtnUrunIslemleri.Name = "BtnUrunIslemleri";
            this.BtnUrunIslemleri.Size = new System.Drawing.Size(137, 119);
            this.BtnUrunIslemleri.TabIndex = 1;
            this.BtnUrunIslemleri.Text = "Ürün İşlemleri";
            this.BtnUrunIslemleri.UseVisualStyleBackColor = true;
            this.BtnUrunIslemleri.Click += new System.EventHandler(this.BtnUrunIslemleri_Click);
            // 
            // BtnIstatistikler
            // 
            this.BtnIstatistikler.Location = new System.Drawing.Point(178, 153);
            this.BtnIstatistikler.Name = "BtnIstatistikler";
            this.BtnIstatistikler.Size = new System.Drawing.Size(137, 119);
            this.BtnIstatistikler.TabIndex = 2;
            this.BtnIstatistikler.Text = "İstatistikler";
            this.BtnIstatistikler.UseVisualStyleBackColor = true;
            this.BtnIstatistikler.Click += new System.EventHandler(this.BtnIstatistikler_Click);
            // 
            // BtnMusteri
            // 
            this.BtnMusteri.Location = new System.Drawing.Point(28, 153);
            this.BtnMusteri.Name = "BtnMusteri";
            this.BtnMusteri.Size = new System.Drawing.Size(137, 119);
            this.BtnMusteri.TabIndex = 3;
            this.BtnMusteri.Text = "Müşteriler";
            this.BtnMusteri.UseVisualStyleBackColor = true;
            this.BtnMusteri.Click += new System.EventHandler(this.BtnMusteri_Click);
            // 
            // FrmAnaform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 300);
            this.Controls.Add(this.BtnMusteri);
            this.Controls.Add(this.BtnIstatistikler);
            this.Controls.Add(this.BtnUrunIslemleri);
            this.Controls.Add(this.BtnKategoriIslemleri);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FrmAnaform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmAnaform_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnKategoriIslemleri;
        private System.Windows.Forms.Button BtnUrunIslemleri;
        private System.Windows.Forms.Button BtnIstatistikler;
        private System.Windows.Forms.Button BtnMusteri;
    }
}