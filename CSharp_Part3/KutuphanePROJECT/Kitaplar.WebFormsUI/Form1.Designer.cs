
namespace Kitaplar.WebFormsUI
{
    partial class Form1
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
            this.gbxAra = new System.Windows.Forms.GroupBox();
            this.gbxAraKitap = new System.Windows.Forms.GroupBox();
            this.tbxAraKitap = new System.Windows.Forms.TextBox();
            this.lblAraKitap = new System.Windows.Forms.Label();
            this.gbxAraKategori = new System.Windows.Forms.GroupBox();
            this.lblAraKategori = new System.Windows.Forms.Label();
            this.cbxAraKategori = new System.Windows.Forms.ComboBox();
            this.dgwKitaplar = new System.Windows.Forms.DataGridView();
            this.gbxKitapEkle = new System.Windows.Forms.GroupBox();
            this.cbxEkleKategori = new System.Windows.Forms.ComboBox();
            this.tbxEkleCiltNo = new System.Windows.Forms.TextBox();
            this.tbxEkleBaskiNo = new System.Windows.Forms.TextBox();
            this.tbxEkleYayinEvi = new System.Windows.Forms.TextBox();
            this.tbxEkleSayfa = new System.Windows.Forms.TextBox();
            this.tbxEkleYazar = new System.Windows.Forms.TextBox();
            this.tbxEkleKitapAd = new System.Windows.Forms.TextBox();
            this.lblEkleCiltNo = new System.Windows.Forms.Label();
            this.lblEkleBaskiNo = new System.Windows.Forms.Label();
            this.lblEkleYayinEvi = new System.Windows.Forms.Label();
            this.lblEkleKategoriId = new System.Windows.Forms.Label();
            this.lblEkleSayfa = new System.Windows.Forms.Label();
            this.lblEkleYazar = new System.Windows.Forms.Label();
            this.lblEkleKitapAd = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.btnEkleKitap = new System.Windows.Forms.Button();
            this.gbxAra.SuspendLayout();
            this.gbxAraKitap.SuspendLayout();
            this.gbxAraKategori.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKitaplar)).BeginInit();
            this.gbxKitapEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxAra
            // 
            this.gbxAra.BackColor = System.Drawing.SystemColors.Control;
            this.gbxAra.Controls.Add(this.gbxAraKitap);
            this.gbxAra.Controls.Add(this.gbxAraKategori);
            this.gbxAra.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxAra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbxAra.Location = new System.Drawing.Point(12, 12);
            this.gbxAra.Name = "gbxAra";
            this.gbxAra.Size = new System.Drawing.Size(843, 146);
            this.gbxAra.TabIndex = 0;
            this.gbxAra.TabStop = false;
            this.gbxAra.Text = "Kitap Arama";
            // 
            // gbxAraKitap
            // 
            this.gbxAraKitap.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbxAraKitap.Controls.Add(this.tbxAraKitap);
            this.gbxAraKitap.Controls.Add(this.lblAraKitap);
            this.gbxAraKitap.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxAraKitap.Location = new System.Drawing.Point(427, 24);
            this.gbxAraKitap.Name = "gbxAraKitap";
            this.gbxAraKitap.Size = new System.Drawing.Size(391, 100);
            this.gbxAraKitap.TabIndex = 1;
            this.gbxAraKitap.TabStop = false;
            this.gbxAraKitap.Text = "Kitap Adına Göre Ara";
            // 
            // tbxAraKitap
            // 
            this.tbxAraKitap.Location = new System.Drawing.Point(85, 40);
            this.tbxAraKitap.Name = "tbxAraKitap";
            this.tbxAraKitap.Size = new System.Drawing.Size(186, 23);
            this.tbxAraKitap.TabIndex = 3;
            // 
            // lblAraKitap
            // 
            this.lblAraKitap.AutoSize = true;
            this.lblAraKitap.ForeColor = System.Drawing.Color.Black;
            this.lblAraKitap.Location = new System.Drawing.Point(6, 43);
            this.lblAraKitap.Name = "lblAraKitap";
            this.lblAraKitap.Size = new System.Drawing.Size(45, 16);
            this.lblAraKitap.TabIndex = 2;
            this.lblAraKitap.Text = "Kitap :";
            this.lblAraKitap.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // gbxAraKategori
            // 
            this.gbxAraKategori.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.gbxAraKategori.Controls.Add(this.lblAraKategori);
            this.gbxAraKategori.Controls.Add(this.cbxAraKategori);
            this.gbxAraKategori.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbxAraKategori.Location = new System.Drawing.Point(30, 24);
            this.gbxAraKategori.Name = "gbxAraKategori";
            this.gbxAraKategori.Size = new System.Drawing.Size(391, 100);
            this.gbxAraKategori.TabIndex = 0;
            this.gbxAraKategori.TabStop = false;
            this.gbxAraKategori.Text = "Kategoriye Göre Ara";
            // 
            // lblAraKategori
            // 
            this.lblAraKategori.AutoSize = true;
            this.lblAraKategori.ForeColor = System.Drawing.Color.Black;
            this.lblAraKategori.Location = new System.Drawing.Point(6, 43);
            this.lblAraKategori.Name = "lblAraKategori";
            this.lblAraKategori.Size = new System.Drawing.Size(64, 16);
            this.lblAraKategori.TabIndex = 1;
            this.lblAraKategori.Text = "Kategori :";
            // 
            // cbxAraKategori
            // 
            this.cbxAraKategori.FormattingEnabled = true;
            this.cbxAraKategori.Location = new System.Drawing.Point(93, 40);
            this.cbxAraKategori.Name = "cbxAraKategori";
            this.cbxAraKategori.Size = new System.Drawing.Size(121, 24);
            this.cbxAraKategori.TabIndex = 0;
            // 
            // dgwKitaplar
            // 
            this.dgwKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgwKitaplar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwKitaplar.Location = new System.Drawing.Point(12, 173);
            this.dgwKitaplar.Name = "dgwKitaplar";
            this.dgwKitaplar.Size = new System.Drawing.Size(843, 198);
            this.dgwKitaplar.TabIndex = 1;
            // 
            // gbxKitapEkle
            // 
            this.gbxKitapEkle.Controls.Add(this.btnEkleKitap);
            this.gbxKitapEkle.Controls.Add(this.textBoxID);
            this.gbxKitapEkle.Controls.Add(this.cbxEkleKategori);
            this.gbxKitapEkle.Controls.Add(this.tbxEkleCiltNo);
            this.gbxKitapEkle.Controls.Add(this.tbxEkleBaskiNo);
            this.gbxKitapEkle.Controls.Add(this.tbxEkleYayinEvi);
            this.gbxKitapEkle.Controls.Add(this.tbxEkleSayfa);
            this.gbxKitapEkle.Controls.Add(this.tbxEkleYazar);
            this.gbxKitapEkle.Controls.Add(this.tbxEkleKitapAd);
            this.gbxKitapEkle.Controls.Add(this.lblEkleCiltNo);
            this.gbxKitapEkle.Controls.Add(this.lblEkleBaskiNo);
            this.gbxKitapEkle.Controls.Add(this.lblEkleYayinEvi);
            this.gbxKitapEkle.Controls.Add(this.lblEkleKategoriId);
            this.gbxKitapEkle.Controls.Add(this.lblEkleSayfa);
            this.gbxKitapEkle.Controls.Add(this.lblEkleYazar);
            this.gbxKitapEkle.Controls.Add(this.lblEkleKitapAd);
            this.gbxKitapEkle.Location = new System.Drawing.Point(12, 377);
            this.gbxKitapEkle.Name = "gbxKitapEkle";
            this.gbxKitapEkle.Size = new System.Drawing.Size(435, 237);
            this.gbxKitapEkle.TabIndex = 2;
            this.gbxKitapEkle.TabStop = false;
            this.gbxKitapEkle.Text = "Kitap Ekle";
            // 
            // cbxEkleKategori
            // 
            this.cbxEkleKategori.FormattingEnabled = true;
            this.cbxEkleKategori.Location = new System.Drawing.Point(305, 86);
            this.cbxEkleKategori.Name = "cbxEkleKategori";
            this.cbxEkleKategori.Size = new System.Drawing.Size(100, 21);
            this.cbxEkleKategori.TabIndex = 14;
            // 
            // tbxEkleCiltNo
            // 
            this.tbxEkleCiltNo.Location = new System.Drawing.Point(89, 180);
            this.tbxEkleCiltNo.Name = "tbxEkleCiltNo";
            this.tbxEkleCiltNo.Size = new System.Drawing.Size(100, 20);
            this.tbxEkleCiltNo.TabIndex = 13;
            // 
            // tbxEkleBaskiNo
            // 
            this.tbxEkleBaskiNo.Location = new System.Drawing.Point(305, 137);
            this.tbxEkleBaskiNo.Name = "tbxEkleBaskiNo";
            this.tbxEkleBaskiNo.Size = new System.Drawing.Size(100, 20);
            this.tbxEkleBaskiNo.TabIndex = 12;
            // 
            // tbxEkleYayinEvi
            // 
            this.tbxEkleYayinEvi.Location = new System.Drawing.Point(90, 137);
            this.tbxEkleYayinEvi.Name = "tbxEkleYayinEvi";
            this.tbxEkleYayinEvi.Size = new System.Drawing.Size(100, 20);
            this.tbxEkleYayinEvi.TabIndex = 11;
            // 
            // tbxEkleSayfa
            // 
            this.tbxEkleSayfa.Location = new System.Drawing.Point(89, 86);
            this.tbxEkleSayfa.Name = "tbxEkleSayfa";
            this.tbxEkleSayfa.Size = new System.Drawing.Size(100, 20);
            this.tbxEkleSayfa.TabIndex = 9;
            // 
            // tbxEkleYazar
            // 
            this.tbxEkleYazar.Location = new System.Drawing.Point(305, 34);
            this.tbxEkleYazar.Name = "tbxEkleYazar";
            this.tbxEkleYazar.Size = new System.Drawing.Size(100, 20);
            this.tbxEkleYazar.TabIndex = 8;
            // 
            // tbxEkleKitapAd
            // 
            this.tbxEkleKitapAd.Location = new System.Drawing.Point(89, 34);
            this.tbxEkleKitapAd.Name = "tbxEkleKitapAd";
            this.tbxEkleKitapAd.Size = new System.Drawing.Size(100, 20);
            this.tbxEkleKitapAd.TabIndex = 7;
            // 
            // lblEkleCiltNo
            // 
            this.lblEkleCiltNo.AutoSize = true;
            this.lblEkleCiltNo.Location = new System.Drawing.Point(16, 183);
            this.lblEkleCiltNo.Name = "lblEkleCiltNo";
            this.lblEkleCiltNo.Size = new System.Drawing.Size(44, 13);
            this.lblEkleCiltNo.TabIndex = 6;
            this.lblEkleCiltNo.Text = "Cilt No :";
            // 
            // lblEkleBaskiNo
            // 
            this.lblEkleBaskiNo.AutoSize = true;
            this.lblEkleBaskiNo.Location = new System.Drawing.Point(222, 140);
            this.lblEkleBaskiNo.Name = "lblEkleBaskiNo";
            this.lblEkleBaskiNo.Size = new System.Drawing.Size(56, 13);
            this.lblEkleBaskiNo.TabIndex = 5;
            this.lblEkleBaskiNo.Text = "Baskı No :";
            // 
            // lblEkleYayinEvi
            // 
            this.lblEkleYayinEvi.AutoSize = true;
            this.lblEkleYayinEvi.Location = new System.Drawing.Point(16, 140);
            this.lblEkleYayinEvi.Name = "lblEkleYayinEvi";
            this.lblEkleYayinEvi.Size = new System.Drawing.Size(57, 13);
            this.lblEkleYayinEvi.TabIndex = 4;
            this.lblEkleYayinEvi.Text = "Yayın Evi :";
            // 
            // lblEkleKategoriId
            // 
            this.lblEkleKategoriId.AutoSize = true;
            this.lblEkleKategoriId.Location = new System.Drawing.Point(222, 93);
            this.lblEkleKategoriId.Name = "lblEkleKategoriId";
            this.lblEkleKategoriId.Size = new System.Drawing.Size(52, 13);
            this.lblEkleKategoriId.TabIndex = 3;
            this.lblEkleKategoriId.Text = "Kategori :";
            // 
            // lblEkleSayfa
            // 
            this.lblEkleSayfa.AutoSize = true;
            this.lblEkleSayfa.Location = new System.Drawing.Point(16, 89);
            this.lblEkleSayfa.Name = "lblEkleSayfa";
            this.lblEkleSayfa.Size = new System.Drawing.Size(40, 13);
            this.lblEkleSayfa.TabIndex = 2;
            this.lblEkleSayfa.Text = "Sayfa :";
            // 
            // lblEkleYazar
            // 
            this.lblEkleYazar.AutoSize = true;
            this.lblEkleYazar.Location = new System.Drawing.Point(222, 37);
            this.lblEkleYazar.Name = "lblEkleYazar";
            this.lblEkleYazar.Size = new System.Drawing.Size(40, 13);
            this.lblEkleYazar.TabIndex = 1;
            this.lblEkleYazar.Text = "Yazar :";
            // 
            // lblEkleKitapAd
            // 
            this.lblEkleKitapAd.AutoSize = true;
            this.lblEkleKitapAd.Location = new System.Drawing.Point(16, 37);
            this.lblEkleKitapAd.Name = "lblEkleKitapAd";
            this.lblEkleKitapAd.Size = new System.Drawing.Size(53, 13);
            this.lblEkleKitapAd.TabIndex = 0;
            this.lblEkleKitapAd.Text = "Kitap Ad :";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(491, 377);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 193);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kitap Güncelle";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(305, 183);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 20);
            this.textBoxID.TabIndex = 15;
            // 
            // btnEkleKitap
            // 
            this.btnEkleKitap.Location = new System.Drawing.Point(212, 181);
            this.btnEkleKitap.Name = "btnEkleKitap";
            this.btnEkleKitap.Size = new System.Drawing.Size(75, 23);
            this.btnEkleKitap.TabIndex = 16;
            this.btnEkleKitap.Text = "Ekle";
            this.btnEkleKitap.UseVisualStyleBackColor = true;
            this.btnEkleKitap.Click += new System.EventHandler(this.btnEkleKitap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 626);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxKitapEkle);
            this.Controls.Add(this.dgwKitaplar);
            this.Controls.Add(this.gbxAra);
            this.Name = "Form1";
            this.Text = "Kitaplar";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxAra.ResumeLayout(false);
            this.gbxAraKitap.ResumeLayout(false);
            this.gbxAraKitap.PerformLayout();
            this.gbxAraKategori.ResumeLayout(false);
            this.gbxAraKategori.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwKitaplar)).EndInit();
            this.gbxKitapEkle.ResumeLayout(false);
            this.gbxKitapEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxAra;
        private System.Windows.Forms.GroupBox gbxAraKategori;
        private System.Windows.Forms.GroupBox gbxAraKitap;
        private System.Windows.Forms.DataGridView dgwKitaplar;
        private System.Windows.Forms.GroupBox gbxKitapEkle;
        private System.Windows.Forms.Label lblAraKategori;
        private System.Windows.Forms.ComboBox cbxAraKategori;
        private System.Windows.Forms.TextBox tbxAraKitap;
        private System.Windows.Forms.Label lblAraKitap;
        private System.Windows.Forms.Label lblEkleYazar;
        private System.Windows.Forms.Label lblEkleKitapAd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEkleBaskiNo;
        private System.Windows.Forms.Label lblEkleYayinEvi;
        private System.Windows.Forms.Label lblEkleKategoriId;
        private System.Windows.Forms.Label lblEkleSayfa;
        private System.Windows.Forms.Label lblEkleCiltNo;
        private System.Windows.Forms.TextBox tbxEkleCiltNo;
        private System.Windows.Forms.TextBox tbxEkleBaskiNo;
        private System.Windows.Forms.TextBox tbxEkleYayinEvi;
        private System.Windows.Forms.TextBox tbxEkleSayfa;
        private System.Windows.Forms.TextBox tbxEkleYazar;
        private System.Windows.Forms.TextBox tbxEkleKitapAd;
        private System.Windows.Forms.ComboBox cbxEkleKategori;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Button btnEkleKitap;
    }
}

