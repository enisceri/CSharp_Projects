
namespace Library.WebFormsUI
{
    partial class frmKitaplar
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
            this.lblEklePrintYear = new System.Windows.Forms.Label();
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
            this.lblGuncelleYayinEvi = new System.Windows.Forms.Label();
            this.lblGuncelleCiltNo = new System.Windows.Forms.Label();
            this.lblGuncelleBasimYili = new System.Windows.Forms.Label();
            this.lblGuncelleSayfa = new System.Windows.Forms.Label();
            this.lblGuncelleKategori = new System.Windows.Forms.Label();
            this.lblGuncelleYazar = new System.Windows.Forms.Label();
            this.lblGuncelleKitapAd = new System.Windows.Forms.Label();
            this.gbxSil = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bntSil = new System.Windows.Forms.Button();
            this.gbxAraKategori = new System.Windows.Forms.GroupBox();
            this.btnAraKategoriListele = new System.Windows.Forms.Button();
            this.cbxAraKategori = new System.Windows.Forms.ComboBox();
            this.lblAraKategori = new System.Windows.Forms.Label();
            this.gbxAraKitap = new System.Windows.Forms.GroupBox();
            this.tbxAraKitapAd = new System.Windows.Forms.TextBox();
            this.lblAraKitapAd = new System.Windows.Forms.Label();
            this.gbxAraYazar = new System.Windows.Forms.GroupBox();
            this.tbxAraYazar = new System.Windows.Forms.TextBox();
            this.lblAraYazarAdi = new System.Windows.Forms.Label();
            this.gbxAraYayinEvi = new System.Windows.Forms.GroupBox();
            this.tbxAraYayinEvi = new System.Windows.Forms.TextBox();
            this.lblAraYayinEvi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.gbxEkle.SuspendLayout();
            this.gbxGuncelle.SuspendLayout();
            this.gbxSil.SuspendLayout();
            this.gbxAraKategori.SuspendLayout();
            this.gbxAraKitap.SuspendLayout();
            this.gbxAraYazar.SuspendLayout();
            this.gbxAraYayinEvi.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgvBooks.Location = new System.Drawing.Point(12, 121);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.Size = new System.Drawing.Size(937, 124);
            this.dgvBooks.TabIndex = 0;
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellClick);
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
            this.gbxEkle.Controls.Add(this.lblEklePrintYear);
            this.gbxEkle.Controls.Add(this.lblEkleNumberOfPages);
            this.gbxEkle.Controls.Add(this.lblEkleKategori);
            this.gbxEkle.Controls.Add(this.lblEkleYazar);
            this.gbxEkle.Controls.Add(this.lblEkleBookName);
            this.gbxEkle.Location = new System.Drawing.Point(12, 251);
            this.gbxEkle.Name = "gbxEkle";
            this.gbxEkle.Size = new System.Drawing.Size(433, 198);
            this.gbxEkle.TabIndex = 4;
            this.gbxEkle.TabStop = false;
            this.gbxEkle.Text = "Kitap Ekle";
            // 
            // btnEkleKitap
            // 
            this.btnEkleKitap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEkleKitap.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkleKitap.Location = new System.Drawing.Point(306, 166);
            this.btnEkleKitap.Name = "btnEkleKitap";
            this.btnEkleKitap.Size = new System.Drawing.Size(121, 23);
            this.btnEkleKitap.TabIndex = 15;
            this.btnEkleKitap.Text = "EKLE";
            this.btnEkleKitap.UseVisualStyleBackColor = false;
            this.btnEkleKitap.Click += new System.EventHandler(this.btnEkleKitap_Click);
            // 
            // cbxEkleKategori
            // 
            this.cbxEkleKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // lblEklePrintYear
            // 
            this.lblEklePrintYear.AutoSize = true;
            this.lblEklePrintYear.Location = new System.Drawing.Point(229, 128);
            this.lblEklePrintYear.Name = "lblEklePrintYear";
            this.lblEklePrintYear.Size = new System.Drawing.Size(54, 13);
            this.lblEklePrintYear.TabIndex = 4;
            this.lblEklePrintYear.Text = "Basım Yılı:";
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
            this.gbxGuncelle.Controls.Add(this.lblGuncelleYayinEvi);
            this.gbxGuncelle.Controls.Add(this.lblGuncelleCiltNo);
            this.gbxGuncelle.Controls.Add(this.lblGuncelleBasimYili);
            this.gbxGuncelle.Controls.Add(this.lblGuncelleSayfa);
            this.gbxGuncelle.Controls.Add(this.lblGuncelleKategori);
            this.gbxGuncelle.Controls.Add(this.lblGuncelleYazar);
            this.gbxGuncelle.Controls.Add(this.lblGuncelleKitapAd);
            this.gbxGuncelle.Location = new System.Drawing.Point(516, 251);
            this.gbxGuncelle.Name = "gbxGuncelle";
            this.gbxGuncelle.Size = new System.Drawing.Size(433, 198);
            this.gbxGuncelle.TabIndex = 17;
            this.gbxGuncelle.TabStop = false;
            this.gbxGuncelle.Text = "Kitap Güncelle";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(306, 166);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(121, 23);
            this.btnGuncelle.TabIndex = 15;
            this.btnGuncelle.Text = "GÜNCELLE";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cbxGuncelleKategori
            // 
            this.cbxGuncelleKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            // lblGuncelleYayinEvi
            // 
            this.lblGuncelleYayinEvi.AutoSize = true;
            this.lblGuncelleYayinEvi.Location = new System.Drawing.Point(17, 128);
            this.lblGuncelleYayinEvi.Name = "lblGuncelleYayinEvi";
            this.lblGuncelleYayinEvi.Size = new System.Drawing.Size(57, 13);
            this.lblGuncelleYayinEvi.TabIndex = 6;
            this.lblGuncelleYayinEvi.Text = "Yayın Evi :";
            // 
            // lblGuncelleCiltNo
            // 
            this.lblGuncelleCiltNo.AutoSize = true;
            this.lblGuncelleCiltNo.Location = new System.Drawing.Point(17, 172);
            this.lblGuncelleCiltNo.Name = "lblGuncelleCiltNo";
            this.lblGuncelleCiltNo.Size = new System.Drawing.Size(44, 13);
            this.lblGuncelleCiltNo.TabIndex = 5;
            this.lblGuncelleCiltNo.Text = "Cilt No :";
            // 
            // lblGuncelleBasimYili
            // 
            this.lblGuncelleBasimYili.AutoSize = true;
            this.lblGuncelleBasimYili.Location = new System.Drawing.Point(229, 128);
            this.lblGuncelleBasimYili.Name = "lblGuncelleBasimYili";
            this.lblGuncelleBasimYili.Size = new System.Drawing.Size(57, 13);
            this.lblGuncelleBasimYili.TabIndex = 4;
            this.lblGuncelleBasimYili.Text = "Basım Yılı :";
            // 
            // lblGuncelleSayfa
            // 
            this.lblGuncelleSayfa.AutoSize = true;
            this.lblGuncelleSayfa.Location = new System.Drawing.Point(229, 81);
            this.lblGuncelleSayfa.Name = "lblGuncelleSayfa";
            this.lblGuncelleSayfa.Size = new System.Drawing.Size(70, 13);
            this.lblGuncelleSayfa.TabIndex = 3;
            this.lblGuncelleSayfa.Text = "Sayfa Sayısı :";
            // 
            // lblGuncelleKategori
            // 
            this.lblGuncelleKategori.AutoSize = true;
            this.lblGuncelleKategori.Location = new System.Drawing.Point(14, 81);
            this.lblGuncelleKategori.Name = "lblGuncelleKategori";
            this.lblGuncelleKategori.Size = new System.Drawing.Size(52, 13);
            this.lblGuncelleKategori.TabIndex = 2;
            this.lblGuncelleKategori.Text = "Kategori :";
            // 
            // lblGuncelleYazar
            // 
            this.lblGuncelleYazar.AutoSize = true;
            this.lblGuncelleYazar.Location = new System.Drawing.Point(229, 33);
            this.lblGuncelleYazar.Name = "lblGuncelleYazar";
            this.lblGuncelleYazar.Size = new System.Drawing.Size(43, 13);
            this.lblGuncelleYazar.TabIndex = 1;
            this.lblGuncelleYazar.Text = "Yazar  :";
            // 
            // lblGuncelleKitapAd
            // 
            this.lblGuncelleKitapAd.AutoSize = true;
            this.lblGuncelleKitapAd.Location = new System.Drawing.Point(17, 36);
            this.lblGuncelleKitapAd.Name = "lblGuncelleKitapAd";
            this.lblGuncelleKitapAd.Size = new System.Drawing.Size(55, 13);
            this.lblGuncelleKitapAd.TabIndex = 0;
            this.lblGuncelleKitapAd.Text = "Kitap Adı :";
            // 
            // gbxSil
            // 
            this.gbxSil.Controls.Add(this.label1);
            this.gbxSil.Controls.Add(this.bntSil);
            this.gbxSil.Location = new System.Drawing.Point(955, 251);
            this.gbxSil.Name = "gbxSil";
            this.gbxSil.Size = new System.Drawing.Size(127, 198);
            this.gbxSil.TabIndex = 18;
            this.gbxSil.TabStop = false;
            this.gbxSil.Text = "Kitap Sil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Silmek için listeden\r\n kitap seçin";
            // 
            // bntSil
            // 
            this.bntSil.BackColor = System.Drawing.Color.Red;
            this.bntSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bntSil.Location = new System.Drawing.Point(29, 162);
            this.bntSil.Name = "bntSil";
            this.bntSil.Size = new System.Drawing.Size(75, 23);
            this.bntSil.TabIndex = 0;
            this.bntSil.Text = "SİL";
            this.bntSil.UseVisualStyleBackColor = false;
            this.bntSil.Click += new System.EventHandler(this.bntSil_Click);
            // 
            // gbxAraKategori
            // 
            this.gbxAraKategori.Controls.Add(this.btnAraKategoriListele);
            this.gbxAraKategori.Controls.Add(this.cbxAraKategori);
            this.gbxAraKategori.Controls.Add(this.lblAraKategori);
            this.gbxAraKategori.Location = new System.Drawing.Point(12, 16);
            this.gbxAraKategori.Name = "gbxAraKategori";
            this.gbxAraKategori.Size = new System.Drawing.Size(238, 99);
            this.gbxAraKategori.TabIndex = 19;
            this.gbxAraKategori.TabStop = false;
            this.gbxAraKategori.Text = "Kategoriye Göre Ara";
            // 
            // btnAraKategoriListele
            // 
            this.btnAraKategoriListele.BackColor = System.Drawing.Color.Thistle;
            this.btnAraKategoriListele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAraKategoriListele.Location = new System.Drawing.Point(111, 70);
            this.btnAraKategoriListele.Name = "btnAraKategoriListele";
            this.btnAraKategoriListele.Size = new System.Drawing.Size(121, 23);
            this.btnAraKategoriListele.TabIndex = 16;
            this.btnAraKategoriListele.Text = "LİSTELE";
            this.btnAraKategoriListele.UseVisualStyleBackColor = false;
            this.btnAraKategoriListele.Click += new System.EventHandler(this.btnAraKategoriListele_Click);
            // 
            // cbxAraKategori
            // 
            this.cbxAraKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAraKategori.FormattingEnabled = true;
            this.cbxAraKategori.Location = new System.Drawing.Point(111, 38);
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
            this.gbxAraKitap.Location = new System.Drawing.Point(256, 16);
            this.gbxAraKitap.Name = "gbxAraKitap";
            this.gbxAraKitap.Size = new System.Drawing.Size(259, 99);
            this.gbxAraKitap.TabIndex = 3;
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
            // gbxAraYazar
            // 
            this.gbxAraYazar.Controls.Add(this.tbxAraYazar);
            this.gbxAraYazar.Controls.Add(this.lblAraYazarAdi);
            this.gbxAraYazar.Location = new System.Drawing.Point(521, 16);
            this.gbxAraYazar.Name = "gbxAraYazar";
            this.gbxAraYazar.Size = new System.Drawing.Size(214, 99);
            this.gbxAraYazar.TabIndex = 20;
            this.gbxAraYazar.TabStop = false;
            this.gbxAraYazar.Text = "Yazar Adına Göre Ara";
            // 
            // tbxAraYazar
            // 
            this.tbxAraYazar.Location = new System.Drawing.Point(61, 38);
            this.tbxAraYazar.Name = "tbxAraYazar";
            this.tbxAraYazar.Size = new System.Drawing.Size(117, 20);
            this.tbxAraYazar.TabIndex = 2;
            this.tbxAraYazar.TextChanged += new System.EventHandler(this.tbxAraYazar_TextChanged);
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
            // gbxAraYayinEvi
            // 
            this.gbxAraYayinEvi.Controls.Add(this.tbxAraYayinEvi);
            this.gbxAraYayinEvi.Controls.Add(this.lblAraYayinEvi);
            this.gbxAraYayinEvi.Location = new System.Drawing.Point(748, 16);
            this.gbxAraYayinEvi.Name = "gbxAraYayinEvi";
            this.gbxAraYayinEvi.Size = new System.Drawing.Size(201, 99);
            this.gbxAraYayinEvi.TabIndex = 21;
            this.gbxAraYayinEvi.TabStop = false;
            this.gbxAraYayinEvi.Text = "Yayın Evine Göre Ara";
            // 
            // tbxAraYayinEvi
            // 
            this.tbxAraYayinEvi.Location = new System.Drawing.Point(69, 38);
            this.tbxAraYayinEvi.Name = "tbxAraYayinEvi";
            this.tbxAraYayinEvi.Size = new System.Drawing.Size(117, 20);
            this.tbxAraYayinEvi.TabIndex = 2;
            this.tbxAraYayinEvi.TextChanged += new System.EventHandler(this.tbxAraYayinEvi_TextChanged);
            // 
            // lblAraYayinEvi
            // 
            this.lblAraYayinEvi.AutoSize = true;
            this.lblAraYayinEvi.Location = new System.Drawing.Point(6, 41);
            this.lblAraYayinEvi.Name = "lblAraYayinEvi";
            this.lblAraYayinEvi.Size = new System.Drawing.Size(57, 13);
            this.lblAraYayinEvi.TabIndex = 1;
            this.lblAraYayinEvi.Text = "Yayın Evi :";
            // 
            // frmKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 513);
            this.Controls.Add(this.gbxAraYayinEvi);
            this.Controls.Add(this.gbxAraYazar);
            this.Controls.Add(this.gbxAraKitap);
            this.Controls.Add(this.gbxAraKategori);
            this.Controls.Add(this.gbxSil);
            this.Controls.Add(this.gbxGuncelle);
            this.Controls.Add(this.gbxEkle);
            this.Controls.Add(this.dgvBooks);
            this.Name = "frmKitaplar";
            this.Text = "frmKitaplar";
            this.Activated += new System.EventHandler(this.frmKitaplar_Activated);
            this.Load += new System.EventHandler(this.frmKitaplar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.gbxEkle.ResumeLayout(false);
            this.gbxEkle.PerformLayout();
            this.gbxGuncelle.ResumeLayout(false);
            this.gbxGuncelle.PerformLayout();
            this.gbxSil.ResumeLayout(false);
            this.gbxSil.PerformLayout();
            this.gbxAraKategori.ResumeLayout(false);
            this.gbxAraKategori.PerformLayout();
            this.gbxAraKitap.ResumeLayout(false);
            this.gbxAraKitap.PerformLayout();
            this.gbxAraYazar.ResumeLayout(false);
            this.gbxAraYazar.PerformLayout();
            this.gbxAraYayinEvi.ResumeLayout(false);
            this.gbxAraYayinEvi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.GroupBox gbxEkle;
        private System.Windows.Forms.Button btnEkleKitap;
        public System.Windows.Forms.ComboBox cbxEkleKategori;
        private System.Windows.Forms.TextBox tbxEkleCiltNo;
        private System.Windows.Forms.TextBox tbxEkleBaskiNo;
        private System.Windows.Forms.TextBox tbxEkleYayinEvi;
        private System.Windows.Forms.TextBox tbxEkleSayfaSayisi;
        private System.Windows.Forms.TextBox tbxEkleYazar;
        private System.Windows.Forms.TextBox tbxEkleKitapAd;
        private System.Windows.Forms.Label lblEklePublisher;
        private System.Windows.Forms.Label lblEkleNumberOfVolumes;
        private System.Windows.Forms.Label lblEklePrintYear;
        private System.Windows.Forms.Label lblEkleNumberOfPages;
        private System.Windows.Forms.Label lblEkleKategori;
        private System.Windows.Forms.Label lblEkleYazar;
        private System.Windows.Forms.Label lblEkleBookName;
        private System.Windows.Forms.GroupBox gbxGuncelle;
        private System.Windows.Forms.Button btnGuncelle;
        public System.Windows.Forms.ComboBox cbxGuncelleKategori;
        private System.Windows.Forms.TextBox tbxGuncelleCiltNo;
        private System.Windows.Forms.TextBox tbxGuncelleBaskiSayisi;
        private System.Windows.Forms.TextBox tbxGuncelleYayinEvi;
        private System.Windows.Forms.TextBox tbxGuncelleSayfaSayisi;
        private System.Windows.Forms.TextBox tbxGuncelleYazar;
        private System.Windows.Forms.TextBox tbxGuncelleKitapAd;
        private System.Windows.Forms.Label lblGuncelleYayinEvi;
        private System.Windows.Forms.Label lblGuncelleCiltNo;
        private System.Windows.Forms.Label lblGuncelleBasimYili;
        private System.Windows.Forms.Label lblGuncelleSayfa;
        private System.Windows.Forms.Label lblGuncelleKategori;
        private System.Windows.Forms.Label lblGuncelleYazar;
        private System.Windows.Forms.Label lblGuncelleKitapAd;
        private System.Windows.Forms.GroupBox gbxSil;
        private System.Windows.Forms.Button bntSil;
        private System.Windows.Forms.GroupBox gbxAraKategori;
        // public yapildi.
        public System.Windows.Forms.ComboBox cbxAraKategori;
        private System.Windows.Forms.Label lblAraKategori;
        private System.Windows.Forms.GroupBox gbxAraKitap;
        private System.Windows.Forms.TextBox tbxAraKitapAd;
        private System.Windows.Forms.Label lblAraKitapAd;
        private System.Windows.Forms.GroupBox gbxAraYazar;
        private System.Windows.Forms.TextBox tbxAraYazar;
        private System.Windows.Forms.Label lblAraYazarAdi;
        private System.Windows.Forms.Button btnAraKategoriListele;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbxAraYayinEvi;
        private System.Windows.Forms.TextBox tbxAraYayinEvi;
        private System.Windows.Forms.Label lblAraYayinEvi;
    }
}