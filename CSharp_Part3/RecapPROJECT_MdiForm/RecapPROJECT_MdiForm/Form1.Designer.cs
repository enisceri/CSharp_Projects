
namespace RecapPROJECT_MdiForm
{
    partial class FrmAnaSayfa
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
            this.pnlCalismaAlani = new System.Windows.Forms.Panel();
            this.btnAktifKullanici = new System.Windows.Forms.Button();
            this.btnKullaniciDegistir = new System.Windows.Forms.Button();
            this.pnlButonlar = new System.Windows.Forms.Panel();
            this.pnlButonlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCalismaAlani
            // 
            this.pnlCalismaAlani.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlCalismaAlani.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCalismaAlani.Location = new System.Drawing.Point(200, 0);
            this.pnlCalismaAlani.Name = "pnlCalismaAlani";
            this.pnlCalismaAlani.Size = new System.Drawing.Size(611, 450);
            this.pnlCalismaAlani.TabIndex = 1;
            // 
            // btnAktifKullanici
            // 
            this.btnAktifKullanici.Location = new System.Drawing.Point(41, 46);
            this.btnAktifKullanici.Name = "btnAktifKullanici";
            this.btnAktifKullanici.Size = new System.Drawing.Size(110, 70);
            this.btnAktifKullanici.TabIndex = 0;
            this.btnAktifKullanici.Text = "Aktif Kullanıcı";
            this.btnAktifKullanici.UseVisualStyleBackColor = true;
            this.btnAktifKullanici.Click += new System.EventHandler(this.btnAktifKullanici_Click);
            // 
            // btnKullaniciDegistir
            // 
            this.btnKullaniciDegistir.Location = new System.Drawing.Point(41, 167);
            this.btnKullaniciDegistir.Name = "btnKullaniciDegistir";
            this.btnKullaniciDegistir.Size = new System.Drawing.Size(110, 70);
            this.btnKullaniciDegistir.TabIndex = 1;
            this.btnKullaniciDegistir.Text = "Kullanıcı Değiştir";
            this.btnKullaniciDegistir.UseVisualStyleBackColor = true;
            this.btnKullaniciDegistir.Click += new System.EventHandler(this.btnKullaniciDegistir_Click);
            // 
            // pnlButonlar
            // 
            this.pnlButonlar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlButonlar.Controls.Add(this.btnKullaniciDegistir);
            this.pnlButonlar.Controls.Add(this.btnAktifKullanici);
            this.pnlButonlar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlButonlar.Location = new System.Drawing.Point(0, 0);
            this.pnlButonlar.Name = "pnlButonlar";
            this.pnlButonlar.Size = new System.Drawing.Size(200, 450);
            this.pnlButonlar.TabIndex = 0;
            // 
            // FrmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 450);
            this.Controls.Add(this.pnlCalismaAlani);
            this.Controls.Add(this.pnlButonlar);
            this.IsMdiContainer = true;
            this.Name = "FrmAnaSayfa";
            this.Text = "ANA SAYFA";
            this.Load += new System.EventHandler(this.FrmAnaSayfa_Load);
            this.pnlButonlar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCalismaAlani;
        private System.Windows.Forms.Button btnAktifKullanici;
        private System.Windows.Forms.Button btnKullaniciDegistir;
        private System.Windows.Forms.Panel pnlButonlar;
    }
}

