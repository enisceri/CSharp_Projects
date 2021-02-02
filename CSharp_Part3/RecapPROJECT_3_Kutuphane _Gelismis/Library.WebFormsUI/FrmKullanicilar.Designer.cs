
namespace Library.WebFormsUI
{
    partial class FrmKullanicilar
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
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.gbxEkleKullanici = new System.Windows.Forms.GroupBox();
            this.btnEkleKullanici = new System.Windows.Forms.Button();
            this.tbxEkleKullanici = new System.Windows.Forms.TextBox();
            this.lblKullaniciAdSoyad = new System.Windows.Forms.Label();
            this.gbxGuncelleKullanici = new System.Windows.Forms.GroupBox();
            this.btnGuncelleKullanici = new System.Windows.Forms.Button();
            this.tbxGuncelleKullanici = new System.Windows.Forms.TextBox();
            this.lblGuncelleKullanici = new System.Windows.Forms.Label();
            this.gbxSilKullanici = new System.Windows.Forms.GroupBox();
            this.btnSilKullanici = new System.Windows.Forms.Button();
            this.dgvOkunanKitaplar = new System.Windows.Forms.DataGridView();
            this.lblUyeTablosu = new System.Windows.Forms.Label();
            this.lblOkunanKitaplar = new System.Windows.Forms.Label();
            this.gbxEkleOkunanKitap = new System.Windows.Forms.GroupBox();
            this.tbxEkleKategoriId = new System.Windows.Forms.TextBox();
            this.lblEkleKategori = new System.Windows.Forms.Label();
            this.lblEkleOkunduKitapAd = new System.Windows.Forms.Label();
            this.tbxEkleKitapAd = new System.Windows.Forms.TextBox();
            this.lblEkleKitapId = new System.Windows.Forms.Label();
            this.tbxEkleKitapId = new System.Windows.Forms.TextBox();
            this.btnEkleOkunanlar = new System.Windows.Forms.Button();
            this.lblEkleKullanicilar = new System.Windows.Forms.Label();
            this.cbxEkleKullanicilar = new System.Windows.Forms.ComboBox();
            this.dgvKitaplar = new System.Windows.Forms.DataGridView();
            this.lblKitaplar = new System.Windows.Forms.Label();
            this.gbxOkunanSil = new System.Windows.Forms.GroupBox();
            this.btnOkunanKitapSil = new System.Windows.Forms.Button();
            this.gbxOkunanFiltre = new System.Windows.Forms.GroupBox();
            this.lblFiltreKitapId = new System.Windows.Forms.Label();
            this.lblFiltreKitapAd = new System.Windows.Forms.Label();
            this.lblFiltreKategori = new System.Windows.Forms.Label();
            this.lblFiltreKullanicilar = new System.Windows.Forms.Label();
            this.lblFiltreKullaniciId = new System.Windows.Forms.Label();
            this.tbxFiltreKitapId = new System.Windows.Forms.TextBox();
            this.tbxFiltreKitapAd = new System.Windows.Forms.TextBox();
            this.tbxFiltreKullanicilar = new System.Windows.Forms.TextBox();
            this.tbxFiltreKullaniciId = new System.Windows.Forms.TextBox();
            this.cbxFiltreKategori = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.gbxEkleKullanici.SuspendLayout();
            this.gbxGuncelleKullanici.SuspendLayout();
            this.gbxSilKullanici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOkunanKitaplar)).BeginInit();
            this.gbxEkleOkunanKitap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).BeginInit();
            this.gbxOkunanSil.SuspendLayout();
            this.gbxOkunanFiltre.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsers
            // 
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Location = new System.Drawing.Point(46, 46);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.Size = new System.Drawing.Size(530, 120);
            this.dgvUsers.TabIndex = 0;
            this.dgvUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsers_CellClick);
            // 
            // gbxEkleKullanici
            // 
            this.gbxEkleKullanici.Controls.Add(this.btnEkleKullanici);
            this.gbxEkleKullanici.Controls.Add(this.tbxEkleKullanici);
            this.gbxEkleKullanici.Controls.Add(this.lblKullaniciAdSoyad);
            this.gbxEkleKullanici.Location = new System.Drawing.Point(46, 172);
            this.gbxEkleKullanici.Name = "gbxEkleKullanici";
            this.gbxEkleKullanici.Size = new System.Drawing.Size(200, 100);
            this.gbxEkleKullanici.TabIndex = 1;
            this.gbxEkleKullanici.TabStop = false;
            this.gbxEkleKullanici.Text = "Kullanıcı  Ekle";
            // 
            // btnEkleKullanici
            // 
            this.btnEkleKullanici.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEkleKullanici.Location = new System.Drawing.Point(80, 71);
            this.btnEkleKullanici.Name = "btnEkleKullanici";
            this.btnEkleKullanici.Size = new System.Drawing.Size(100, 23);
            this.btnEkleKullanici.TabIndex = 2;
            this.btnEkleKullanici.Text = "EKLE";
            this.btnEkleKullanici.UseVisualStyleBackColor = false;
            this.btnEkleKullanici.Click += new System.EventHandler(this.btnEkleKullanici_Click);
            // 
            // tbxEkleKullanici
            // 
            this.tbxEkleKullanici.Location = new System.Drawing.Point(80, 38);
            this.tbxEkleKullanici.Name = "tbxEkleKullanici";
            this.tbxEkleKullanici.Size = new System.Drawing.Size(100, 20);
            this.tbxEkleKullanici.TabIndex = 2;
            // 
            // lblKullaniciAdSoyad
            // 
            this.lblKullaniciAdSoyad.AutoSize = true;
            this.lblKullaniciAdSoyad.Location = new System.Drawing.Point(15, 41);
            this.lblKullaniciAdSoyad.Name = "lblKullaniciAdSoyad";
            this.lblKullaniciAdSoyad.Size = new System.Drawing.Size(59, 13);
            this.lblKullaniciAdSoyad.TabIndex = 2;
            this.lblKullaniciAdSoyad.Text = "Ad Soyad :";
            // 
            // gbxGuncelleKullanici
            // 
            this.gbxGuncelleKullanici.Controls.Add(this.btnGuncelleKullanici);
            this.gbxGuncelleKullanici.Controls.Add(this.tbxGuncelleKullanici);
            this.gbxGuncelleKullanici.Controls.Add(this.lblGuncelleKullanici);
            this.gbxGuncelleKullanici.Location = new System.Drawing.Point(252, 172);
            this.gbxGuncelleKullanici.Name = "gbxGuncelleKullanici";
            this.gbxGuncelleKullanici.Size = new System.Drawing.Size(200, 100);
            this.gbxGuncelleKullanici.TabIndex = 3;
            this.gbxGuncelleKullanici.TabStop = false;
            this.gbxGuncelleKullanici.Text = "Kullanıcı  Güncelle";
            // 
            // btnGuncelleKullanici
            // 
            this.btnGuncelleKullanici.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnGuncelleKullanici.Location = new System.Drawing.Point(80, 71);
            this.btnGuncelleKullanici.Name = "btnGuncelleKullanici";
            this.btnGuncelleKullanici.Size = new System.Drawing.Size(100, 23);
            this.btnGuncelleKullanici.TabIndex = 2;
            this.btnGuncelleKullanici.Text = "DEĞİŞTİR";
            this.btnGuncelleKullanici.UseVisualStyleBackColor = false;
            this.btnGuncelleKullanici.Click += new System.EventHandler(this.btnGuncelleKullanici_Click);
            // 
            // tbxGuncelleKullanici
            // 
            this.tbxGuncelleKullanici.Location = new System.Drawing.Point(80, 38);
            this.tbxGuncelleKullanici.Name = "tbxGuncelleKullanici";
            this.tbxGuncelleKullanici.Size = new System.Drawing.Size(100, 20);
            this.tbxGuncelleKullanici.TabIndex = 2;
            // 
            // lblGuncelleKullanici
            // 
            this.lblGuncelleKullanici.AutoSize = true;
            this.lblGuncelleKullanici.Location = new System.Drawing.Point(15, 41);
            this.lblGuncelleKullanici.Name = "lblGuncelleKullanici";
            this.lblGuncelleKullanici.Size = new System.Drawing.Size(59, 13);
            this.lblGuncelleKullanici.TabIndex = 2;
            this.lblGuncelleKullanici.Text = "Ad Soyad :";
            // 
            // gbxSilKullanici
            // 
            this.gbxSilKullanici.Controls.Add(this.btnSilKullanici);
            this.gbxSilKullanici.Location = new System.Drawing.Point(458, 172);
            this.gbxSilKullanici.Name = "gbxSilKullanici";
            this.gbxSilKullanici.Size = new System.Drawing.Size(118, 100);
            this.gbxSilKullanici.TabIndex = 4;
            this.gbxSilKullanici.TabStop = false;
            this.gbxSilKullanici.Text = "Kullanıcı  Sil";
            // 
            // btnSilKullanici
            // 
            this.btnSilKullanici.BackColor = System.Drawing.Color.Red;
            this.btnSilKullanici.Location = new System.Drawing.Point(6, 71);
            this.btnSilKullanici.Name = "btnSilKullanici";
            this.btnSilKullanici.Size = new System.Drawing.Size(100, 23);
            this.btnSilKullanici.TabIndex = 2;
            this.btnSilKullanici.Text = "SİL";
            this.btnSilKullanici.UseVisualStyleBackColor = false;
            this.btnSilKullanici.Click += new System.EventHandler(this.btnSilKullanici_Click);
            // 
            // dgvOkunanKitaplar
            // 
            this.dgvOkunanKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOkunanKitaplar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOkunanKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOkunanKitaplar.Location = new System.Drawing.Point(46, 319);
            this.dgvOkunanKitaplar.Name = "dgvOkunanKitaplar";
            this.dgvOkunanKitaplar.ReadOnly = true;
            this.dgvOkunanKitaplar.Size = new System.Drawing.Size(1042, 86);
            this.dgvOkunanKitaplar.TabIndex = 5;
            // 
            // lblUyeTablosu
            // 
            this.lblUyeTablosu.AutoSize = true;
            this.lblUyeTablosu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyeTablosu.ForeColor = System.Drawing.Color.Blue;
            this.lblUyeTablosu.Location = new System.Drawing.Point(248, 19);
            this.lblUyeTablosu.Name = "lblUyeTablosu";
            this.lblUyeTablosu.Size = new System.Drawing.Size(151, 24);
            this.lblUyeTablosu.TabIndex = 6;
            this.lblUyeTablosu.Text = "ÜYE TABLOSU";
            // 
            // lblOkunanKitaplar
            // 
            this.lblOkunanKitaplar.AutoSize = true;
            this.lblOkunanKitaplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOkunanKitaplar.ForeColor = System.Drawing.Color.Blue;
            this.lblOkunanKitaplar.Location = new System.Drawing.Point(248, 292);
            this.lblOkunanKitaplar.Name = "lblOkunanKitaplar";
            this.lblOkunanKitaplar.Size = new System.Drawing.Size(200, 24);
            this.lblOkunanKitaplar.TabIndex = 7;
            this.lblOkunanKitaplar.Text = "OKUNAN KİTAPLAR";
            // 
            // gbxEkleOkunanKitap
            // 
            this.gbxEkleOkunanKitap.Controls.Add(this.tbxEkleKategoriId);
            this.gbxEkleOkunanKitap.Controls.Add(this.lblEkleKategori);
            this.gbxEkleOkunanKitap.Controls.Add(this.lblEkleOkunduKitapAd);
            this.gbxEkleOkunanKitap.Controls.Add(this.tbxEkleKitapAd);
            this.gbxEkleOkunanKitap.Controls.Add(this.lblEkleKitapId);
            this.gbxEkleOkunanKitap.Controls.Add(this.tbxEkleKitapId);
            this.gbxEkleOkunanKitap.Controls.Add(this.btnEkleOkunanlar);
            this.gbxEkleOkunanKitap.Controls.Add(this.lblEkleKullanicilar);
            this.gbxEkleOkunanKitap.Controls.Add(this.cbxEkleKullanicilar);
            this.gbxEkleOkunanKitap.Location = new System.Drawing.Point(46, 411);
            this.gbxEkleOkunanKitap.Name = "gbxEkleOkunanKitap";
            this.gbxEkleOkunanKitap.Size = new System.Drawing.Size(386, 203);
            this.gbxEkleOkunanKitap.TabIndex = 3;
            this.gbxEkleOkunanKitap.TabStop = false;
            this.gbxEkleOkunanKitap.Text = "Okundu Olarak Ekle";
            // 
            // tbxEkleKategoriId
            // 
            this.tbxEkleKategoriId.Enabled = false;
            this.tbxEkleKategoriId.Location = new System.Drawing.Point(84, 174);
            this.tbxEkleKategoriId.Name = "tbxEkleKategoriId";
            this.tbxEkleKategoriId.Size = new System.Drawing.Size(121, 20);
            this.tbxEkleKategoriId.TabIndex = 14;
            // 
            // lblEkleKategori
            // 
            this.lblEkleKategori.AutoSize = true;
            this.lblEkleKategori.Location = new System.Drawing.Point(15, 177);
            this.lblEkleKategori.Name = "lblEkleKategori";
            this.lblEkleKategori.Size = new System.Drawing.Size(52, 13);
            this.lblEkleKategori.TabIndex = 13;
            this.lblEkleKategori.Text = "Kategori :";
            // 
            // lblEkleOkunduKitapAd
            // 
            this.lblEkleOkunduKitapAd.AutoSize = true;
            this.lblEkleOkunduKitapAd.Location = new System.Drawing.Point(15, 134);
            this.lblEkleOkunduKitapAd.Name = "lblEkleOkunduKitapAd";
            this.lblEkleOkunduKitapAd.Size = new System.Drawing.Size(53, 13);
            this.lblEkleOkunduKitapAd.TabIndex = 12;
            this.lblEkleOkunduKitapAd.Text = "Kitap Ad :";
            // 
            // tbxEkleKitapAd
            // 
            this.tbxEkleKitapAd.Enabled = false;
            this.tbxEkleKitapAd.Location = new System.Drawing.Point(84, 131);
            this.tbxEkleKitapAd.Name = "tbxEkleKitapAd";
            this.tbxEkleKitapAd.Size = new System.Drawing.Size(121, 20);
            this.tbxEkleKitapAd.TabIndex = 11;
            // 
            // lblEkleKitapId
            // 
            this.lblEkleKitapId.AutoSize = true;
            this.lblEkleKitapId.Location = new System.Drawing.Point(15, 91);
            this.lblEkleKitapId.Name = "lblEkleKitapId";
            this.lblEkleKitapId.Size = new System.Drawing.Size(49, 13);
            this.lblEkleKitapId.TabIndex = 10;
            this.lblEkleKitapId.Text = "Kitap Id :";
            // 
            // tbxEkleKitapId
            // 
            this.tbxEkleKitapId.Enabled = false;
            this.tbxEkleKitapId.Location = new System.Drawing.Point(84, 88);
            this.tbxEkleKitapId.Name = "tbxEkleKitapId";
            this.tbxEkleKitapId.Size = new System.Drawing.Size(121, 20);
            this.tbxEkleKitapId.TabIndex = 9;
            // 
            // btnEkleOkunanlar
            // 
            this.btnEkleOkunanlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEkleOkunanlar.Location = new System.Drawing.Point(243, 88);
            this.btnEkleOkunanlar.Name = "btnEkleOkunanlar";
            this.btnEkleOkunanlar.Size = new System.Drawing.Size(121, 63);
            this.btnEkleOkunanlar.TabIndex = 2;
            this.btnEkleOkunanlar.Text = "EKLE";
            this.btnEkleOkunanlar.UseVisualStyleBackColor = false;
            this.btnEkleOkunanlar.Click += new System.EventHandler(this.btnEkleOkunanlar_Click);
            // 
            // lblEkleKullanicilar
            // 
            this.lblEkleKullanicilar.AutoSize = true;
            this.lblEkleKullanicilar.Location = new System.Drawing.Point(15, 41);
            this.lblEkleKullanicilar.Name = "lblEkleKullanicilar";
            this.lblEkleKullanicilar.Size = new System.Drawing.Size(63, 13);
            this.lblEkleKullanicilar.TabIndex = 2;
            this.lblEkleKullanicilar.Text = "Kullanıcılar :";
            // 
            // cbxEkleKullanicilar
            // 
            this.cbxEkleKullanicilar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxEkleKullanicilar.FormattingEnabled = true;
            this.cbxEkleKullanicilar.Location = new System.Drawing.Point(84, 38);
            this.cbxEkleKullanicilar.Name = "cbxEkleKullanicilar";
            this.cbxEkleKullanicilar.Size = new System.Drawing.Size(121, 21);
            this.cbxEkleKullanicilar.TabIndex = 8;
            // 
            // dgvKitaplar
            // 
            this.dgvKitaplar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKitaplar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvKitaplar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKitaplar.Location = new System.Drawing.Point(596, 46);
            this.dgvKitaplar.Name = "dgvKitaplar";
            this.dgvKitaplar.ReadOnly = true;
            this.dgvKitaplar.Size = new System.Drawing.Size(492, 122);
            this.dgvKitaplar.TabIndex = 8;
            this.dgvKitaplar.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKitaplar_CellDoubleClick);
            // 
            // lblKitaplar
            // 
            this.lblKitaplar.AutoSize = true;
            this.lblKitaplar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKitaplar.ForeColor = System.Drawing.Color.Blue;
            this.lblKitaplar.Location = new System.Drawing.Point(719, 19);
            this.lblKitaplar.Name = "lblKitaplar";
            this.lblKitaplar.Size = new System.Drawing.Size(107, 24);
            this.lblKitaplar.TabIndex = 9;
            this.lblKitaplar.Text = "KİTAPLAR";
            // 
            // gbxOkunanSil
            // 
            this.gbxOkunanSil.Controls.Add(this.btnOkunanKitapSil);
            this.gbxOkunanSil.Location = new System.Drawing.Point(438, 411);
            this.gbxOkunanSil.Name = "gbxOkunanSil";
            this.gbxOkunanSil.Size = new System.Drawing.Size(138, 203);
            this.gbxOkunanSil.TabIndex = 15;
            this.gbxOkunanSil.TabStop = false;
            this.gbxOkunanSil.Text = "Okunanlardan Sil";
            // 
            // btnOkunanKitapSil
            // 
            this.btnOkunanKitapSil.BackColor = System.Drawing.Color.Red;
            this.btnOkunanKitapSil.Location = new System.Drawing.Point(6, 84);
            this.btnOkunanKitapSil.Name = "btnOkunanKitapSil";
            this.btnOkunanKitapSil.Size = new System.Drawing.Size(121, 63);
            this.btnOkunanKitapSil.TabIndex = 2;
            this.btnOkunanKitapSil.Text = "SİL";
            this.btnOkunanKitapSil.UseVisualStyleBackColor = false;
            this.btnOkunanKitapSil.Click += new System.EventHandler(this.btnOkunanKitapSil_Click);
            // 
            // gbxOkunanFiltre
            // 
            this.gbxOkunanFiltre.Controls.Add(this.cbxFiltreKategori);
            this.gbxOkunanFiltre.Controls.Add(this.tbxFiltreKullaniciId);
            this.gbxOkunanFiltre.Controls.Add(this.tbxFiltreKullanicilar);
            this.gbxOkunanFiltre.Controls.Add(this.tbxFiltreKitapAd);
            this.gbxOkunanFiltre.Controls.Add(this.tbxFiltreKitapId);
            this.gbxOkunanFiltre.Controls.Add(this.lblFiltreKullaniciId);
            this.gbxOkunanFiltre.Controls.Add(this.lblFiltreKullanicilar);
            this.gbxOkunanFiltre.Controls.Add(this.lblFiltreKategori);
            this.gbxOkunanFiltre.Controls.Add(this.lblFiltreKitapAd);
            this.gbxOkunanFiltre.Controls.Add(this.lblFiltreKitapId);
            this.gbxOkunanFiltre.Location = new System.Drawing.Point(596, 411);
            this.gbxOkunanFiltre.Name = "gbxOkunanFiltre";
            this.gbxOkunanFiltre.Size = new System.Drawing.Size(492, 203);
            this.gbxOkunanFiltre.TabIndex = 16;
            this.gbxOkunanFiltre.TabStop = false;
            this.gbxOkunanFiltre.Text = "Okunan Kitaplar Filtre";
            // 
            // lblFiltreKitapId
            // 
            this.lblFiltreKitapId.AutoSize = true;
            this.lblFiltreKitapId.Location = new System.Drawing.Point(16, 28);
            this.lblFiltreKitapId.Name = "lblFiltreKitapId";
            this.lblFiltreKitapId.Size = new System.Drawing.Size(49, 13);
            this.lblFiltreKitapId.TabIndex = 15;
            this.lblFiltreKitapId.Text = "Kitap Id :";
            // 
            // lblFiltreKitapAd
            // 
            this.lblFiltreKitapAd.AutoSize = true;
            this.lblFiltreKitapAd.Location = new System.Drawing.Point(12, 84);
            this.lblFiltreKitapAd.Name = "lblFiltreKitapAd";
            this.lblFiltreKitapAd.Size = new System.Drawing.Size(53, 13);
            this.lblFiltreKitapAd.TabIndex = 15;
            this.lblFiltreKitapAd.Text = "Kitap Ad :";
            // 
            // lblFiltreKategori
            // 
            this.lblFiltreKategori.AutoSize = true;
            this.lblFiltreKategori.Location = new System.Drawing.Point(12, 150);
            this.lblFiltreKategori.Name = "lblFiltreKategori";
            this.lblFiltreKategori.Size = new System.Drawing.Size(52, 13);
            this.lblFiltreKategori.TabIndex = 15;
            this.lblFiltreKategori.Text = "Kategori :";
            // 
            // lblFiltreKullanicilar
            // 
            this.lblFiltreKullanicilar.AutoSize = true;
            this.lblFiltreKullanicilar.Location = new System.Drawing.Point(215, 28);
            this.lblFiltreKullanicilar.Name = "lblFiltreKullanicilar";
            this.lblFiltreKullanicilar.Size = new System.Drawing.Size(63, 13);
            this.lblFiltreKullanicilar.TabIndex = 15;
            this.lblFiltreKullanicilar.Text = "Kullanıcılar :";
            // 
            // lblFiltreKullaniciId
            // 
            this.lblFiltreKullaniciId.AutoSize = true;
            this.lblFiltreKullaniciId.Location = new System.Drawing.Point(214, 88);
            this.lblFiltreKullaniciId.Name = "lblFiltreKullaniciId";
            this.lblFiltreKullaniciId.Size = new System.Drawing.Size(64, 13);
            this.lblFiltreKullaniciId.TabIndex = 16;
            this.lblFiltreKullaniciId.Text = "Kullanıcı Id :";
            // 
            // tbxFiltreKitapId
            // 
            this.tbxFiltreKitapId.Location = new System.Drawing.Point(71, 25);
            this.tbxFiltreKitapId.Name = "tbxFiltreKitapId";
            this.tbxFiltreKitapId.Size = new System.Drawing.Size(121, 20);
            this.tbxFiltreKitapId.TabIndex = 15;
            this.tbxFiltreKitapId.TextChanged += new System.EventHandler(this.tbxFiltreKitapId_TextChanged);
            // 
            // tbxFiltreKitapAd
            // 
            this.tbxFiltreKitapAd.Location = new System.Drawing.Point(71, 81);
            this.tbxFiltreKitapAd.Name = "tbxFiltreKitapAd";
            this.tbxFiltreKitapAd.Size = new System.Drawing.Size(121, 20);
            this.tbxFiltreKitapAd.TabIndex = 17;
            this.tbxFiltreKitapAd.TextChanged += new System.EventHandler(this.tbxFiltreKitapAd_TextChanged);
            // 
            // tbxFiltreKullanicilar
            // 
            this.tbxFiltreKullanicilar.Location = new System.Drawing.Point(284, 25);
            this.tbxFiltreKullanicilar.Name = "tbxFiltreKullanicilar";
            this.tbxFiltreKullanicilar.Size = new System.Drawing.Size(121, 20);
            this.tbxFiltreKullanicilar.TabIndex = 19;
            this.tbxFiltreKullanicilar.TextChanged += new System.EventHandler(this.tbxFiltreKullanicilar_TextChanged);
            // 
            // tbxFiltreKullaniciId
            // 
            this.tbxFiltreKullaniciId.Location = new System.Drawing.Point(284, 88);
            this.tbxFiltreKullaniciId.Name = "tbxFiltreKullaniciId";
            this.tbxFiltreKullaniciId.Size = new System.Drawing.Size(121, 20);
            this.tbxFiltreKullaniciId.TabIndex = 20;
            this.tbxFiltreKullaniciId.TextChanged += new System.EventHandler(this.tbxFiltreKullaniciId_TextChanged);
            // 
            // cbxFiltreKategori
            // 
            this.cbxFiltreKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFiltreKategori.FormattingEnabled = true;
            this.cbxFiltreKategori.Location = new System.Drawing.Point(71, 147);
            this.cbxFiltreKategori.Name = "cbxFiltreKategori";
            this.cbxFiltreKategori.Size = new System.Drawing.Size(121, 21);
            this.cbxFiltreKategori.TabIndex = 15;
            this.cbxFiltreKategori.SelectedIndexChanged += new System.EventHandler(this.cbxFiltreKategori_SelectedIndexChanged);
            // 
            // FrmKullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 626);
            this.Controls.Add(this.gbxOkunanFiltre);
            this.Controls.Add(this.gbxOkunanSil);
            this.Controls.Add(this.lblKitaplar);
            this.Controls.Add(this.dgvKitaplar);
            this.Controls.Add(this.gbxEkleOkunanKitap);
            this.Controls.Add(this.lblOkunanKitaplar);
            this.Controls.Add(this.lblUyeTablosu);
            this.Controls.Add(this.dgvOkunanKitaplar);
            this.Controls.Add(this.gbxSilKullanici);
            this.Controls.Add(this.gbxGuncelleKullanici);
            this.Controls.Add(this.gbxEkleKullanici);
            this.Controls.Add(this.dgvUsers);
            this.Name = "FrmKullanicilar";
            this.Text = "FrmKullanicilar";
            this.Activated += new System.EventHandler(this.FrmKullanicilar_Activated);
            this.Load += new System.EventHandler(this.FrmKullanicilar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.gbxEkleKullanici.ResumeLayout(false);
            this.gbxEkleKullanici.PerformLayout();
            this.gbxGuncelleKullanici.ResumeLayout(false);
            this.gbxGuncelleKullanici.PerformLayout();
            this.gbxSilKullanici.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOkunanKitaplar)).EndInit();
            this.gbxEkleOkunanKitap.ResumeLayout(false);
            this.gbxEkleOkunanKitap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKitaplar)).EndInit();
            this.gbxOkunanSil.ResumeLayout(false);
            this.gbxOkunanFiltre.ResumeLayout(false);
            this.gbxOkunanFiltre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.GroupBox gbxEkleKullanici;
        private System.Windows.Forms.TextBox tbxEkleKullanici;
        private System.Windows.Forms.Label lblKullaniciAdSoyad;
        private System.Windows.Forms.Button btnEkleKullanici;
        private System.Windows.Forms.GroupBox gbxGuncelleKullanici;
        private System.Windows.Forms.Button btnGuncelleKullanici;
        private System.Windows.Forms.TextBox tbxGuncelleKullanici;
        private System.Windows.Forms.Label lblGuncelleKullanici;
        private System.Windows.Forms.GroupBox gbxSilKullanici;
        private System.Windows.Forms.Button btnSilKullanici;
        private System.Windows.Forms.DataGridView dgvOkunanKitaplar;
        private System.Windows.Forms.Label lblUyeTablosu;
        private System.Windows.Forms.Label lblOkunanKitaplar;
        private System.Windows.Forms.GroupBox gbxEkleOkunanKitap;
        private System.Windows.Forms.Button btnEkleOkunanlar;
        private System.Windows.Forms.Label lblEkleKullanicilar;
        private System.Windows.Forms.ComboBox cbxEkleKullanicilar;
        private System.Windows.Forms.DataGridView dgvKitaplar;
        private System.Windows.Forms.Label lblKitaplar;
        private System.Windows.Forms.Label lblEkleOkunduKitapAd;
        private System.Windows.Forms.TextBox tbxEkleKitapAd;
        private System.Windows.Forms.Label lblEkleKitapId;
        private System.Windows.Forms.TextBox tbxEkleKitapId;
        private System.Windows.Forms.Label lblEkleKategori;
        private System.Windows.Forms.TextBox tbxEkleKategoriId;
        private System.Windows.Forms.GroupBox gbxOkunanSil;
        private System.Windows.Forms.Button btnOkunanKitapSil;
        private System.Windows.Forms.GroupBox gbxOkunanFiltre;
        private System.Windows.Forms.Label lblFiltreKitapAd;
        private System.Windows.Forms.Label lblFiltreKitapId;
        private System.Windows.Forms.ComboBox cbxFiltreKategori;
        private System.Windows.Forms.TextBox tbxFiltreKullaniciId;
        private System.Windows.Forms.TextBox tbxFiltreKullanicilar;
        private System.Windows.Forms.TextBox tbxFiltreKitapAd;
        private System.Windows.Forms.TextBox tbxFiltreKitapId;
        private System.Windows.Forms.Label lblFiltreKullaniciId;
        private System.Windows.Forms.Label lblFiltreKullanicilar;
        private System.Windows.Forms.Label lblFiltreKategori;
    }
}