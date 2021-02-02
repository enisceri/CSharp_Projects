
namespace Library.WebFormsUI
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
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.gbxAraKategori = new System.Windows.Forms.GroupBox();
            this.cbxAraKategori = new System.Windows.Forms.ComboBox();
            this.lblAraKategori = new System.Windows.Forms.Label();
            this.gbxAraKitap = new System.Windows.Forms.GroupBox();
            this.tbxAraKitapAd = new System.Windows.Forms.TextBox();
            this.lblAraKitapAd = new System.Windows.Forms.Label();
            this.gbxEkle = new System.Windows.Forms.GroupBox();
            this.btnEkleKitap = new System.Windows.Forms.Button();
            this.cbxEkleKategori = new System.Windows.Forms.ComboBox();
            this.tbxEkleCiltNo = new System.Windows.Forms.TextBox();
            this.tbxEkleBaskiNo = new System.Windows.Forms.TextBox();
            this.tbxEkleYayinEvi = new System.Windows.Forms.TextBox();
            this.tbxEkleSayfaSayisi = new System.Windows.Forms.TextBox();
            this.tbxEkleYazar = new System.Windows.Forms.TextBox();
            this.tbxEkleKitapAd = new System.Windows.Forms.TextBox();
            this.lblEklePublisher = new System.Windows.Forms.Label();
            this.lblEkleNumberOfVolumes = new System.Windows.Forms.Label();
            this.lblEklePrintNo = new System.Windows.Forms.Label();
            this.lblEkleNumberOfPages = new System.Windows.Forms.Label();
            this.lblEkleKategori = new System.Windows.Forms.Label();
            this.lblEkleYazar = new System.Windows.Forms.Label();
            this.lblEkleBookName = new System.Windows.Forms.Label();
            this.gbxGuncelle = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cbxGuncelleKategori = new System.Windows.Forms.ComboBox();
            this.tbxGuncelleCiltNo = new System.Windows.Forms.TextBox();
            this.tbxGuncelleBaskiSayisi = new System.Windows.Forms.TextBox();
            this.tbxGuncelleYayinEvi = new System.Windows.Forms.TextBox();
            this.tbxGuncelleSayfaSayisi = new System.Windows.Forms.TextBox();
            this.tbxGuncelleYazar = new System.Windows.Forms.TextBox();
            this.tbxGuncelleKitapAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gbxSil = new System.Windows.Forms.GroupBox();
            this.bntSil = new System.Windows.Forms.Button();
            this.gbxAraYazar = new System.Windows.Forms.GroupBox();
            this.tbxAraYazar = new System.Windows.Forms.TextBox();
            this.lblAraYazarAdi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.gbxAraKategori.SuspendLayout();
            this.gbxAraKitap.SuspendLayout();
            this.gbxEkle.SuspendLayout();
            this.gbxGuncelle.SuspendLayout();
            this.gbxSil.SuspendLayout();
            this.gbxAraYazar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(33, 117);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.Size = new System.Drawing.Size(939, 138);
            this.dgvBooks.TabIndex = 0;
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellClick);
            // 
            // gbxAraKategori
            // 
            this.gbxAraKategori.Controls.Add(this.cbxAraKategori);
            this.gbxAraKategori.Controls.Add(this.lblAraKategori);
            this.gbxAraKategori.Location = new System.Drawing.Point(33, 12);
            this.gbxAraKategori.Name = "gbxAraKategori";
            this.gbxAraKategori.Size = new System.Drawing.Size(238, 99);
            this.gbxAraKategori.TabIndex = 1;
            this.gbxAraKategori.TabStop = false;
            this.gbxAraKategori.Text = "Kategoriye Göre Ara";
            // 
            // cbxAraKategori
            // 
            this.cbxAraKategori.FormattingEnabled = true;
            this.cbxAraKategori.Location = new System.Drawing.Point(88, 38);
            this.cbxAraKategori.Name = "cbxAraKategori";
            this.cbxAraKategori.Size = new System.Drawing.Size(121, 21);
            this.cbxAraKategori.TabIndex = 1;
            this.cbxAraKategori.SelectedIndexChanged += new System.EventHandler(this.cbxAraKategori_SelectedIndexChanged);
            // 
            // lblAraKategori
            // 
            this.lblAraKategori.AutoSize = true;
            this.lblAraKategori.Location = new System.Drawing.Point(17, 41);
            this.lblAraKategori.Name = "lblAraKategori";
            this.lblAraKategori.Size = new System.Drawing.Size(52, 13);
            this.lblAraKategori.TabIndex = 0;
            this.lblAraKategori.Text = "Kategori :";
            // 
            // gbxAraKitap
            // 
            this.gbxAraKitap.Controls.Add(this.tbxAraKitapAd);
            this.gbxAraKitap.Controls.Add(this.lblAraKitapAd);
            this.gbxAraKitap.Location = new System.Drawing.Point(277, 12);
            this.gbxAraKitap.Name = "gbxAraKitap";
            this.gbxAraKitap.Size = new System.Drawing.Size(259, 99);
            this.gbxAraKitap.TabIndex = 2;
            this.gbxAraKitap.TabStop = false;
            this.gbxAraKitap.Text = "Kitap Adına Göre Ara";
            // 
            // tbxAraKitapAd
            // 
            this.tbxAraKitapAd.Location = new System.Drawing.Point(94, 38);
            this.tbxAraKitapAd.Name = "tbxAraKitapAd";
            this.tbxAraKitapAd.Size = new System.Drawing.Size(148, 20);
            this.tbxAraKitapAd.TabIndex = 2;
            this.tbxAraKitapAd.TextChanged += new System.EventHandler(this.tbxAraKitapAd_TextChanged);
            // 
            // lblAraKitapAd
            // 
            this.lblAraKitapAd.AutoSize = true;
            this.lblAraKitapAd.Location = new System.Drawing.Point(15, 41);
            this.lblAraKitapAd.Name = "lblAraKitapAd";
            this.lblAraKitapAd.Size = new System.Drawing.Size(55, 13);
            this.lblAraKitapAd.TabIndex = 1;
            this.lblAraKitapAd.Text = "Kitap Adı :";
            // 
            // gbxEkle
            // 
            this.gbxEkle.Controls.Add(this.btnEkleKitap);
            this.gbxEkle.Controls.Add(this.cbxEkleKategori);
            this.gbxEkle.Controls.Add(this.tbxEkleCiltNo);
            this.gbxEkle.Controls.Add(this.tbxEkleBaskiNo);
            this.gbxEkle.Controls.Add(this.tbxEkleYayinEvi);
            this.gbxEkle.Controls.Add(this.tbxEkleSayfaSayisi);
            this.gbxEkle.Controls.Add(this.tbxEkleYazar);
            this.gbxEkle.Controls.Add(this.tbxEkleKitapAd);
            this.gbxEkle.Controls.Add(this.lblEklePublisher);
            this.gbxEkle.Controls.Add(this.lblEkleNumberOfVolumes);
            this.gbxEkle.Controls.Add(this.lblEklePrintNo);
            this.gbxEkle.Controls.Add(this.lblEkleNumberOfPages);
            this.gbxEkle.Controls.Add(this.lblEkleKategori);
            this.gbxEkle.Controls.Add(this.lblEkleYazar);
            this.gbxEkle.Controls.Add(this.lblEkleBookName);
            this.gbxEkle.Location = new System.Drawing.Point(33, 271);
            this.gbxEkle.Name = "gbxEkle";
            this.gbxEkle.Size = new System.Drawing.Size(433, 198);
            this.gbxEkle.TabIndex = 3;
            this.gbxEkle.TabStop = false;
            this.gbxEkle.Text = "Kitap Ekle";
            // 
            // btnEkleKitap
            // 
            this.btnEkleKitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkleKitap.Location = new System.Drawing.Point(306, 166);
            this.btnEkleKitap.Name = "btnEkleKitap";
            this.btnEkleKitap.Size = new System.Drawing.Size(121, 23);
            this.btnEkleKitap.TabIndex = 15;
            this.btnEkleKitap.Text = "EKLE";
            this.btnEkleKitap.UseVisualStyleBackColor = true;
            this.btnEkleKitap.Click += new System.EventHandler(this.btnEkleKitap_Click);
            // 
            // cbxEkleKategori
            // 
            this.cbxEkleKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxEkleKategori.FormattingEnabled = true;
            this.cbxEkleKategori.Location = new System.Drawing.Point(88, 77);
            this.cbxEkleKategori.Name = "cbxEkleKategori";
            this.cbxEkleKategori.Size = new System.Drawing.Size(121, 21);
            this.cbxEkleKategori.TabIndex = 14;
            // 
            // tbxEkleCiltNo
            // 
            this.tbxEkleCiltNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxEkleCiltNo.Location = new System.Drawing.Point(88, 169);
            this.tbxEkleCiltNo.Name = "tbxEkleCiltNo";
            this.tbxEkleCiltNo.Size = new System.Drawing.Size(121, 20);
            this.tbxEkleCiltNo.TabIndex = 13;
            // 
            // tbxEkleBaskiNo
            // 
            this.tbxEkleBaskiNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxEkleBaskiNo.Location = new System.Drawing.Point(306, 125);
            this.tbxEkleBaskiNo.Name = "tbxEkleBaskiNo";
            this.tbxEkleBaskiNo.Size = new System.Drawing.Size(121, 20);
            this.tbxEkleBaskiNo.TabIndex = 12;
            // 
            // tbxEkleYayinEvi
            // 
            this.tbxEkleYayinEvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxEkleYayinEvi.Location = new System.Drawing.Point(88, 125);
            this.tbxEkleYayinEvi.Name = "tbxEkleYayinEvi";
            this.tbxEkleYayinEvi.Size = new System.Drawing.Size(121, 20);
            this.tbxEkleYayinEvi.TabIndex = 11;
            // 
            // tbxEkleSayfaSayisi
            // 
            this.tbxEkleSayfaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxEkleSayfaSayisi.Location = new System.Drawing.Point(306, 78);
            this.tbxEkleSayfaSayisi.Name = "tbxEkleSayfaSayisi";
            this.tbxEkleSayfaSayisi.Size = new System.Drawing.Size(121, 20);
            this.tbxEkleSayfaSayisi.TabIndex = 10;
            // 
            // tbxEkleYazar
            // 
            this.tbxEkleYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxEkleYazar.Location = new System.Drawing.Point(306, 33);
            this.tbxEkleYazar.Name = "tbxEkleYazar";
            this.tbxEkleYazar.Size = new System.Drawing.Size(121, 20);
            this.tbxEkleYazar.TabIndex = 8;
            // 
            // tbxEkleKitapAd
            // 
            this.tbxEkleKitapAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxEkleKitapAd.Location = new System.Drawing.Point(88, 33);
            this.tbxEkleKitapAd.Name = "tbxEkleKitapAd";
            this.tbxEkleKitapAd.Size = new System.Drawing.Size(121, 20);
            this.tbxEkleKitapAd.TabIndex = 7;
            // 
            // lblEklePublisher
            // 
            this.lblEklePublisher.AutoSize = true;
            this.lblEklePublisher.Location = new System.Drawing.Point(17, 128);
            this.lblEklePublisher.Name = "lblEklePublisher";
            this.lblEklePublisher.Size = new System.Drawing.Size(57, 13);
            this.lblEklePublisher.TabIndex = 6;
            this.lblEklePublisher.Text = "Yayın Evi :";
            // 
            // lblEkleNumberOfVolumes
            // 
            this.lblEkleNumberOfVolumes.AutoSize = true;
            this.lblEkleNumberOfVolumes.Location = new System.Drawing.Point(17, 172);
            this.lblEkleNumberOfVolumes.Name = "lblEkleNumberOfVolumes";
            this.lblEkleNumberOfVolumes.Size = new System.Drawing.Size(44, 13);
            this.lblEkleNumberOfVolumes.TabIndex = 5;
            this.lblEkleNumberOfVolumes.Text = "Cilt No :";
            // 
            // lblEklePrintNo
            // 
            this.lblEklePrintNo.AutoSize = true;
            this.lblEklePrintNo.Location = new System.Drawing.Point(229, 128);
            this.lblEklePrintNo.Name = "lblEklePrintNo";
            this.lblEklePrintNo.Size = new System.Drawing.Size(66, 13);
            this.lblEklePrintNo.TabIndex = 4;
            this.lblEklePrintNo.Text = "Baskı Sayısı:";
            // 
            // lblEkleNumberOfPages
            // 
            this.lblEkleNumberOfPages.AutoSize = true;
            this.lblEkleNumberOfPages.Location = new System.Drawing.Point(229, 81);
            this.lblEkleNumberOfPages.Name = "lblEkleNumberOfPages";
            this.lblEkleNumberOfPages.Size = new System.Drawing.Size(70, 13);
            this.lblEkleNumberOfPages.TabIndex = 3;
            this.lblEkleNumberOfPages.Text = "Sayfa Sayısı :";
            // 
            // lblEkleKategori
            // 
            this.lblEkleKategori.AutoSize = true;
            this.lblEkleKategori.Location = new System.Drawing.Point(14, 81);
            this.lblEkleKategori.Name = "lblEkleKategori";
            this.lblEkleKategori.Size = new System.Drawing.Size(52, 13);
            this.lblEkleKategori.TabIndex = 2;
            this.lblEkleKategori.Text = "Kategori :";
            // 
            // lblEkleYazar
            // 
            this.lblEkleYazar.AutoSize = true;
            this.lblEkleYazar.Location = new System.Drawing.Point(229, 33);
            this.lblEkleYazar.Name = "lblEkleYazar";
            this.lblEkleYazar.Size = new System.Drawing.Size(43, 13);
            this.lblEkleYazar.TabIndex = 1;
            this.lblEkleYazar.Text = "Yazar  :";
            // 
            // lblEkleBookName
            // 
            this.lblEkleBookName.AutoSize = true;
            this.lblEkleBookName.Location = new System.Drawing.Point(17, 36);
            this.lblEkleBookName.Name = "lblEkleBookName";
            this.lblEkleBookName.Size = new System.Drawing.Size(55, 13);
            this.lblEkleBookName.TabIndex = 0;
            this.lblEkleBookName.Text = "Kitap Adı :";
            // 
            // gbxGuncelle
            // 
            this.gbxGuncelle.Controls.Add(this.btnGuncelle);
            this.gbxGuncelle.Controls.Add(this.cbxGuncelleKategori);
            this.gbxGuncelle.Controls.Add(this.tbxGuncelleCiltNo);
            this.gbxGuncelle.Controls.Add(this.tbxGuncelleBaskiSayisi);
            this.gbxGuncelle.Controls.Add(this.tbxGuncelleYayinEvi);
            this.gbxGuncelle.Controls.Add(this.tbxGuncelleSayfaSayisi);
            this.gbxGuncelle.Controls.Add(this.tbxGuncelleYazar);
            this.gbxGuncelle.Controls.Add(this.tbxGuncelleKitapAd);
            this.gbxGuncelle.Controls.Add(this.label1);
            this.gbxGuncelle.Controls.Add(this.label2);
            this.gbxGuncelle.Controls.Add(this.label3);
            this.gbxGuncelle.Controls.Add(this.label4);
            this.gbxGuncelle.Controls.Add(this.label5);
            this.gbxGuncelle.Controls.Add(this.label6);
            this.gbxGuncelle.Controls.Add(this.label7);
            this.gbxGuncelle.Location = new System.Drawing.Point(539, 271);
            this.gbxGuncelle.Name = "gbxGuncelle";
            this.gbxGuncelle.Size = new System.Drawing.Size(433, 198);
            this.gbxGuncelle.TabIndex = 16;
            this.gbxGuncelle.TabStop = false;
            this.gbxGuncelle.Text = "Kitap Güncelle";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(306, 166);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(121, 23);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cbxGuncelleKategori
            // 
            this.cbxGuncelleKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbxGuncelleKategori.FormattingEnabled = true;
            this.cbxGuncelleKategori.Location = new System.Drawing.Point(88, 77);
            this.cbxGuncelleKategori.Name = "cbxGuncelleKategori";
            this.cbxGuncelleKategori.Size = new System.Drawing.Size(121, 21);
            this.cbxGuncelleKategori.TabIndex = 14;
            // 
            // tbxGuncelleCiltNo
            // 
            this.tbxGuncelleCiltNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxGuncelleCiltNo.Location = new System.Drawing.Point(88, 169);
            this.tbxGuncelleCiltNo.Name = "tbxGuncelleCiltNo";
            this.tbxGuncelleCiltNo.Size = new System.Drawing.Size(121, 20);
            this.tbxGuncelleCiltNo.TabIndex = 13;
            // 
            // tbxGuncelleBaskiSayisi
            // 
            this.tbxGuncelleBaskiSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxGuncelleBaskiSayisi.Location = new System.Drawing.Point(306, 125);
            this.tbxGuncelleBaskiSayisi.Name = "tbxGuncelleBaskiSayisi";
            this.tbxGuncelleBaskiSayisi.Size = new System.Drawing.Size(121, 20);
            this.tbxGuncelleBaskiSayisi.TabIndex = 12;
            // 
            // tbxGuncelleYayinEvi
            // 
            this.tbxGuncelleYayinEvi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxGuncelleYayinEvi.Location = new System.Drawing.Point(88, 125);
            this.tbxGuncelleYayinEvi.Name = "tbxGuncelleYayinEvi";
            this.tbxGuncelleYayinEvi.Size = new System.Drawing.Size(121, 20);
            this.tbxGuncelleYayinEvi.TabIndex = 11;
            // 
            // tbxGuncelleSayfaSayisi
            // 
            this.tbxGuncelleSayfaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxGuncelleSayfaSayisi.Location = new System.Drawing.Point(306, 78);
            this.tbxGuncelleSayfaSayisi.Name = "tbxGuncelleSayfaSayisi";
            this.tbxGuncelleSayfaSayisi.Size = new System.Drawing.Size(121, 20);
            this.tbxGuncelleSayfaSayisi.TabIndex = 10;
            // 
            // tbxGuncelleYazar
            // 
            this.tbxGuncelleYazar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxGuncelleYazar.Location = new System.Drawing.Point(306, 33);
            this.tbxGuncelleYazar.Name = "tbxGuncelleYazar";
            this.tbxGuncelleYazar.Size = new System.Drawing.Size(121, 20);
            this.tbxGuncelleYazar.TabIndex = 8;
            // 
            // tbxGuncelleKitapAd
            // 
            this.tbxGuncelleKitapAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbxGuncelleKitapAd.Location = new System.Drawing.Point(88, 33);
            this.tbxGuncelleKitapAd.Name = "tbxGuncelleKitapAd";
            this.tbxGuncelleKitapAd.Size = new System.Drawing.Size(121, 20);
            this.tbxGuncelleKitapAd.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Yayın Evi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cilt No :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(229, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Baskı Sayısı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Sayfa Sayısı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kategori :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(229, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Yazar  :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kitap Adı :";
            // 
            // gbxSil
            // 
            this.gbxSil.Controls.Add(this.bntSil);
            this.gbxSil.Location = new System.Drawing.Point(845, 12);
            this.gbxSil.Name = "gbxSil";
            this.gbxSil.Size = new System.Drawing.Size(127, 99);
            this.gbxSil.TabIndex = 3;
            this.gbxSil.TabStop = false;
            this.gbxSil.Text = "Kitap Sil";
            // 
            // bntSil
            // 
            this.bntSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bntSil.Location = new System.Drawing.Point(21, 31);
            this.bntSil.Name = "bntSil";
            this.bntSil.Size = new System.Drawing.Size(75, 23);
            this.bntSil.TabIndex = 0;
            this.bntSil.Text = "SİL";
            this.bntSil.UseVisualStyleBackColor = true;
            this.bntSil.Click += new System.EventHandler(this.bntSil_Click);
            // 
            // gbxAraYazar
            // 
            this.gbxAraYazar.Controls.Add(this.tbxAraYazar);
            this.gbxAraYazar.Controls.Add(this.lblAraYazarAdi);
            this.gbxAraYazar.Location = new System.Drawing.Point(542, 12);
            this.gbxAraYazar.Name = "gbxAraYazar";
            this.gbxAraYazar.Size = new System.Drawing.Size(259, 99);
            this.gbxAraYazar.TabIndex = 3;
            this.gbxAraYazar.TabStop = false;
            this.gbxAraYazar.Text = "Yazar Adına Göre Ara";
            // 
            // tbxAraYazar
            // 
            this.tbxAraYazar.Location = new System.Drawing.Point(61, 38);
            this.tbxAraYazar.Name = "tbxAraYazar";
            this.tbxAraYazar.Size = new System.Drawing.Size(117, 20);
            this.tbxAraYazar.TabIndex = 2;
            this.tbxAraYazar.TextChanged += new System.EventHandler(this.tbxAraYazar_TextChanged_1);
            // 
            // lblAraYazarAdi
            // 
            this.lblAraYazarAdi.AutoSize = true;
            this.lblAraYazarAdi.Location = new System.Drawing.Point(15, 41);
            this.lblAraYazarAdi.Name = "lblAraYazarAdi";
            this.lblAraYazarAdi.Size = new System.Drawing.Size(40, 13);
            this.lblAraYazarAdi.TabIndex = 1;
            this.lblAraYazarAdi.Text = "Yazar :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 481);
            this.Controls.Add(this.gbxAraYazar);
            this.Controls.Add(this.gbxSil);
            this.Controls.Add(this.gbxGuncelle);
            this.Controls.Add(this.gbxEkle);
            this.Controls.Add(this.gbxAraKitap);
            this.Controls.Add(this.gbxAraKategori);
            this.Controls.Add(this.dgvBooks);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Kitaplar";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.gbxAraKategori.ResumeLayout(false);
            this.gbxAraKategori.PerformLayout();
            this.gbxAraKitap.ResumeLayout(false);
            this.gbxAraKitap.PerformLayout();
            this.gbxEkle.ResumeLayout(false);
            this.gbxEkle.PerformLayout();
            this.gbxGuncelle.ResumeLayout(false);
            this.gbxGuncelle.PerformLayout();
            this.gbxSil.ResumeLayout(false);
            this.gbxAraYazar.ResumeLayout(false);
            this.gbxAraYazar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.GroupBox gbxAraKategori;
        private System.Windows.Forms.GroupBox gbxAraKitap;
        private System.Windows.Forms.ComboBox cbxAraKategori;
        private System.Windows.Forms.Label lblAraKategori;
        private System.Windows.Forms.Label lblAraKitapAd;
        private System.Windows.Forms.TextBox tbxAraKitapAd;
        private System.Windows.Forms.GroupBox gbxEkle;
        private System.Windows.Forms.Label lblEkleYazar;
        private System.Windows.Forms.Label lblEkleBookName;
        private System.Windows.Forms.Label lblEkleNumberOfVolumes;
        private System.Windows.Forms.Label lblEklePrintNo;
        private System.Windows.Forms.Label lblEkleNumberOfPages;
        private System.Windows.Forms.Label lblEkleKategori;
        private System.Windows.Forms.Label lblEklePublisher;
        private System.Windows.Forms.TextBox tbxEkleYazar;
        private System.Windows.Forms.TextBox tbxEkleKitapAd;
        private System.Windows.Forms.ComboBox cbxEkleKategori;
        private System.Windows.Forms.TextBox tbxEkleCiltNo;
        private System.Windows.Forms.TextBox tbxEkleBaskiNo;
        private System.Windows.Forms.TextBox tbxEkleYayinEvi;
        private System.Windows.Forms.TextBox tbxEkleSayfaSayisi;
        private System.Windows.Forms.Button btnEkleKitap;
        private System.Windows.Forms.GroupBox gbxGuncelle;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox cbxGuncelleKategori;
        private System.Windows.Forms.TextBox tbxGuncelleCiltNo;
        private System.Windows.Forms.TextBox tbxGuncelleBaskiSayisi;
        private System.Windows.Forms.TextBox tbxGuncelleYayinEvi;
        private System.Windows.Forms.TextBox tbxGuncelleSayfaSayisi;
        private System.Windows.Forms.TextBox tbxGuncelleYazar;
        private System.Windows.Forms.TextBox tbxGuncelleKitapAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbxSil;
        private System.Windows.Forms.Button bntSil;
        private System.Windows.Forms.GroupBox gbxAraYazar;
        private System.Windows.Forms.Label lblAraYazarAdi;
        private System.Windows.Forms.TextBox tbxAraYazar;
    }
}

