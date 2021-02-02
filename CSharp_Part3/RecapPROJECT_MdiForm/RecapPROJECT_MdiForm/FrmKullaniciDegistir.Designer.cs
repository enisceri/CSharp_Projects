
namespace RecapPROJECT_MdiForm
{
    partial class FrmKullaniciDegistir
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
            this.btnKullaniciDegistir = new System.Windows.Forms.Button();
            this.tbxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblGorunecekKullanici = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnKullaniciDegistir
            // 
            this.btnKullaniciDegistir.Location = new System.Drawing.Point(243, 86);
            this.btnKullaniciDegistir.Name = "btnKullaniciDegistir";
            this.btnKullaniciDegistir.Size = new System.Drawing.Size(106, 39);
            this.btnKullaniciDegistir.TabIndex = 0;
            this.btnKullaniciDegistir.Text = "KULLANICI DEĞİŞ";
            this.btnKullaniciDegistir.UseVisualStyleBackColor = true;
            this.btnKullaniciDegistir.Click += new System.EventHandler(this.btnKullaniciDegistir_Click);
            // 
            // tbxKullaniciAdi
            // 
            this.tbxKullaniciAdi.Location = new System.Drawing.Point(382, 96);
            this.tbxKullaniciAdi.Name = "tbxKullaniciAdi";
            this.tbxKullaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.tbxKullaniciAdi.TabIndex = 1;
            this.tbxKullaniciAdi.Text = "abcdefg";
            // 
            // lblGorunecekKullanici
            // 
            this.lblGorunecekKullanici.AutoSize = true;
            this.lblGorunecekKullanici.Location = new System.Drawing.Point(396, 160);
            this.lblGorunecekKullanici.Name = "lblGorunecekKullanici";
            this.lblGorunecekKullanici.Size = new System.Drawing.Size(65, 13);
            this.lblGorunecekKullanici.TabIndex = 2;
            this.lblGorunecekKullanici.Text = "UNKNOWN";
            // 
            // FrmKullaniciDegistir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblGorunecekKullanici);
            this.Controls.Add(this.tbxKullaniciAdi);
            this.Controls.Add(this.btnKullaniciDegistir);
            this.Name = "FrmKullaniciDegistir";
            this.Text = "FrmKullaniciDegistir";
            this.Load += new System.EventHandler(this.FrmKullaniciDegistir_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKullaniciDegistir;
        private System.Windows.Forms.TextBox tbxKullaniciAdi;
        private System.Windows.Forms.Label lblGorunecekKullanici;
    }
}