
namespace Library.WebFormsUI
{
    partial class frmAnaSayfa
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblKitapListesi = new System.Windows.Forms.Label();
            this.btnKitaplar = new System.Windows.Forms.Button();
            this.btnKategoriler = new System.Windows.Forms.Button();
            this.btnKullanicilar = new System.Windows.Forms.Button();
            this.pnlCalismaAlani = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.LightBlue;
            this.pnlMenu.Controls.Add(this.lblLogo);
            this.pnlMenu.Controls.Add(this.label2);
            this.pnlMenu.Controls.Add(this.label1);
            this.pnlMenu.Controls.Add(this.lblKitapListesi);
            this.pnlMenu.Controls.Add(this.btnKitaplar);
            this.pnlMenu.Controls.Add(this.btnKategoriler);
            this.pnlMenu.Controls.Add(this.btnKullanicilar);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 481);
            this.pnlMenu.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(60, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Kategoriler";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(61, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Kullanıcılar";
            // 
            // lblKitapListesi
            // 
            this.lblKitapListesi.AutoSize = true;
            this.lblKitapListesi.BackColor = System.Drawing.Color.DarkSlateGray;
            this.lblKitapListesi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitapListesi.ForeColor = System.Drawing.Color.Transparent;
            this.lblKitapListesi.Location = new System.Drawing.Point(72, 147);
            this.lblKitapListesi.Name = "lblKitapListesi";
            this.lblKitapListesi.Size = new System.Drawing.Size(70, 20);
            this.lblKitapListesi.TabIndex = 11;
            this.lblKitapListesi.Text = "Kitaplar";
            // 
            // btnKitaplar
            // 
            this.btnKitaplar.BackgroundImage = global::Library.WebFormsUI.Properties.Resources.kitapButon;
            this.btnKitaplar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKitaplar.Location = new System.Drawing.Point(40, 42);
            this.btnKitaplar.Name = "btnKitaplar";
            this.btnKitaplar.Size = new System.Drawing.Size(125, 125);
            this.btnKitaplar.TabIndex = 3;
            this.btnKitaplar.UseVisualStyleBackColor = true;
            this.btnKitaplar.Click += new System.EventHandler(this.btnKitaplar_Click);
            // 
            // btnKategoriler
            // 
            this.btnKategoriler.BackgroundImage = global::Library.WebFormsUI.Properties.Resources.kategoriButon;
            this.btnKategoriler.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKategoriler.Location = new System.Drawing.Point(40, 304);
            this.btnKategoriler.Name = "btnKategoriler";
            this.btnKategoriler.Size = new System.Drawing.Size(125, 125);
            this.btnKategoriler.TabIndex = 5;
            this.btnKategoriler.UseVisualStyleBackColor = true;
            this.btnKategoriler.Click += new System.EventHandler(this.btnKategoriler_Click);
            // 
            // btnKullanicilar
            // 
            this.btnKullanicilar.BackgroundImage = global::Library.WebFormsUI.Properties.Resources.profilButon;
            this.btnKullanicilar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKullanicilar.Location = new System.Drawing.Point(40, 173);
            this.btnKullanicilar.Name = "btnKullanicilar";
            this.btnKullanicilar.Size = new System.Drawing.Size(125, 125);
            this.btnKullanicilar.TabIndex = 4;
            this.btnKullanicilar.UseVisualStyleBackColor = true;
            this.btnKullanicilar.Click += new System.EventHandler(this.btnKullanicilar_Click);
            // 
            // pnlCalismaAlani
            // 
            this.pnlCalismaAlani.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCalismaAlani.Location = new System.Drawing.Point(200, 0);
            this.pnlCalismaAlani.Name = "pnlCalismaAlani";
            this.pnlCalismaAlani.Size = new System.Drawing.Size(813, 481);
            this.pnlCalismaAlani.TabIndex = 10;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblLogo.ForeColor = System.Drawing.Color.Blue;
            this.lblLogo.Location = new System.Drawing.Point(49, 459);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(104, 16);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "ÇERİ YAZILIM";
            // 
            // frmAnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 481);
            this.Controls.Add(this.pnlCalismaAlani);
            this.Controls.Add(this.pnlMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmAnaSayfa";
            this.Text = "Kitaplar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnKitaplar;
        private System.Windows.Forms.Button btnKullanicilar;
        private System.Windows.Forms.Button btnKategoriler;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblKitapListesi;
        private System.Windows.Forms.Panel pnlCalismaAlani;
        private System.Windows.Forms.Label lblLogo;
    }
}

