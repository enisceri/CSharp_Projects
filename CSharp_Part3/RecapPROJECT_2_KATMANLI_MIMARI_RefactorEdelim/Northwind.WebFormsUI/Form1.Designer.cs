
namespace Northwind.WebFormsUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.lblKategoriArama = new System.Windows.Forms.Label();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.gbxUrunArama = new System.Windows.Forms.GroupBox();
            this.lblUrunArama = new System.Windows.Forms.Label();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.gbxProductAdd = new System.Windows.Forms.GroupBox();
            this.cbxKategoriId_UrunEkle = new System.Windows.Forms.ComboBox();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.tbxFiyat = new System.Windows.Forms.TextBox();
            this.tbxQuantityPerUnit = new System.Windows.Forms.TextBox();
            this.tbxStokAdet = new System.Windows.Forms.TextBox();
            this.tbxUrunAd = new System.Windows.Forms.TextBox();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.lblStockAmount = new System.Windows.Forms.Label();
            this.lblUnitsInStock = new System.Windows.Forms.Label();
            this.lblCategoryId = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.cbxUpdateKategori = new System.Windows.Forms.ComboBox();
            this.tbxUpdateFiyat = new System.Windows.Forms.TextBox();
            this.tbxUpdateBirimAdet = new System.Windows.Forms.TextBox();
            this.tbxUpdateStok = new System.Windows.Forms.TextBox();
            this.tbxUpdateUrunAd = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnUrunSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxUrunArama.SuspendLayout();
            this.gbxProductAdd.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgwProduct.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Fuchsia;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dgwProduct.Location = new System.Drawing.Point(21, 140);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(746, 212);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.lblKategoriArama);
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Location = new System.Drawing.Point(21, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(370, 80);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye Göre Ara";
            // 
            // lblKategoriArama
            // 
            this.lblKategoriArama.AutoSize = true;
            this.lblKategoriArama.Location = new System.Drawing.Point(6, 37);
            this.lblKategoriArama.Name = "lblKategoriArama";
            this.lblKategoriArama.Size = new System.Drawing.Size(52, 13);
            this.lblKategoriArama.TabIndex = 3;
            this.lblKategoriArama.Text = "Kategori :";
            // 
            // cbxCategory
            // 
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(118, 29);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(121, 21);
            this.cbxCategory.TabIndex = 0;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // gbxUrunArama
            // 
            this.gbxUrunArama.Controls.Add(this.lblUrunArama);
            this.gbxUrunArama.Controls.Add(this.tbxProductName);
            this.gbxUrunArama.Location = new System.Drawing.Point(397, 12);
            this.gbxUrunArama.Name = "gbxUrunArama";
            this.gbxUrunArama.Size = new System.Drawing.Size(370, 80);
            this.gbxUrunArama.TabIndex = 2;
            this.gbxUrunArama.TabStop = false;
            this.gbxUrunArama.Text = "Ürün Adına Göre Ara";
            // 
            // lblUrunArama
            // 
            this.lblUrunArama.AutoSize = true;
            this.lblUrunArama.Location = new System.Drawing.Point(6, 41);
            this.lblUrunArama.Name = "lblUrunArama";
            this.lblUrunArama.Size = new System.Drawing.Size(36, 13);
            this.lblUrunArama.TabIndex = 4;
            this.lblUrunArama.Text = "Ürün :";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(141, 34);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(100, 20);
            this.tbxProductName.TabIndex = 0;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // gbxProductAdd
            // 
            this.gbxProductAdd.Controls.Add(this.cbxKategoriId_UrunEkle);
            this.gbxProductAdd.Controls.Add(this.btnUrunEkle);
            this.gbxProductAdd.Controls.Add(this.tbxFiyat);
            this.gbxProductAdd.Controls.Add(this.tbxQuantityPerUnit);
            this.gbxProductAdd.Controls.Add(this.tbxStokAdet);
            this.gbxProductAdd.Controls.Add(this.tbxUrunAd);
            this.gbxProductAdd.Controls.Add(this.lblUnitPrice);
            this.gbxProductAdd.Controls.Add(this.lblStockAmount);
            this.gbxProductAdd.Controls.Add(this.lblUnitsInStock);
            this.gbxProductAdd.Controls.Add(this.lblCategoryId);
            this.gbxProductAdd.Controls.Add(this.lblProductName);
            this.gbxProductAdd.Location = new System.Drawing.Point(21, 358);
            this.gbxProductAdd.Name = "gbxProductAdd";
            this.gbxProductAdd.Size = new System.Drawing.Size(287, 282);
            this.gbxProductAdd.TabIndex = 4;
            this.gbxProductAdd.TabStop = false;
            this.gbxProductAdd.Text = "ÜRÜN EKLE";
            // 
            // cbxKategoriId_UrunEkle
            // 
            this.cbxKategoriId_UrunEkle.FormattingEnabled = true;
            this.cbxKategoriId_UrunEkle.Location = new System.Drawing.Point(139, 85);
            this.cbxKategoriId_UrunEkle.Name = "cbxKategoriId_UrunEkle";
            this.cbxKategoriId_UrunEkle.Size = new System.Drawing.Size(100, 21);
            this.cbxKategoriId_UrunEkle.TabIndex = 15;
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(139, 244);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(100, 23);
            this.btnUrunEkle.TabIndex = 5;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // tbxFiyat
            // 
            this.tbxFiyat.Location = new System.Drawing.Point(139, 208);
            this.tbxFiyat.Name = "tbxFiyat";
            this.tbxFiyat.Size = new System.Drawing.Size(100, 20);
            this.tbxFiyat.TabIndex = 14;
            // 
            // tbxQuantityPerUnit
            // 
            this.tbxQuantityPerUnit.Location = new System.Drawing.Point(139, 170);
            this.tbxQuantityPerUnit.Name = "tbxQuantityPerUnit";
            this.tbxQuantityPerUnit.Size = new System.Drawing.Size(100, 20);
            this.tbxQuantityPerUnit.TabIndex = 13;
            // 
            // tbxStokAdet
            // 
            this.tbxStokAdet.Location = new System.Drawing.Point(139, 129);
            this.tbxStokAdet.Name = "tbxStokAdet";
            this.tbxStokAdet.Size = new System.Drawing.Size(100, 20);
            this.tbxStokAdet.TabIndex = 12;
            // 
            // tbxUrunAd
            // 
            this.tbxUrunAd.Location = new System.Drawing.Point(139, 37);
            this.tbxUrunAd.Name = "tbxUrunAd";
            this.tbxUrunAd.Size = new System.Drawing.Size(100, 20);
            this.tbxUrunAd.TabIndex = 10;
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(9, 211);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(35, 13);
            this.lblUnitPrice.TabIndex = 9;
            this.lblUnitPrice.Text = "Fiyat :";
            // 
            // lblStockAmount
            // 
            this.lblStockAmount.AutoSize = true;
            this.lblStockAmount.Location = new System.Drawing.Point(6, 129);
            this.lblStockAmount.Name = "lblStockAmount";
            this.lblStockAmount.Size = new System.Drawing.Size(60, 13);
            this.lblStockAmount.TabIndex = 7;
            this.lblStockAmount.Text = "Stok Adet :";
            // 
            // lblUnitsInStock
            // 
            this.lblUnitsInStock.AutoSize = true;
            this.lblUnitsInStock.Location = new System.Drawing.Point(6, 170);
            this.lblUnitsInStock.Name = "lblUnitsInStock";
            this.lblUnitsInStock.Size = new System.Drawing.Size(57, 13);
            this.lblUnitsInStock.TabIndex = 5;
            this.lblUnitsInStock.Text = "Birim Adet:";
            // 
            // lblCategoryId
            // 
            this.lblCategoryId.AutoSize = true;
            this.lblCategoryId.Location = new System.Drawing.Point(8, 85);
            this.lblCategoryId.Name = "lblCategoryId";
            this.lblCategoryId.Size = new System.Drawing.Size(69, 13);
            this.lblCategoryId.TabIndex = 4;
            this.lblCategoryId.Text = "Kategori No :";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(6, 37);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(54, 13);
            this.lblProductName.TabIndex = 3;
            this.lblProductName.Text = "Ürün Adı :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuncelle);
            this.groupBox1.Controls.Add(this.cbxUpdateKategori);
            this.groupBox1.Controls.Add(this.tbxUpdateFiyat);
            this.groupBox1.Controls.Add(this.tbxUpdateBirimAdet);
            this.groupBox1.Controls.Add(this.tbxUpdateStok);
            this.groupBox1.Controls.Add(this.tbxUpdateUrunAd);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(329, 358);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 282);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ÜRÜN GÜNCELLE";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(139, 247);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(100, 23);
            this.btnGuncelle.TabIndex = 16;
            this.btnGuncelle.Text = "Ürün Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // cbxUpdateKategori
            // 
            this.cbxUpdateKategori.FormattingEnabled = true;
            this.cbxUpdateKategori.Location = new System.Drawing.Point(139, 85);
            this.cbxUpdateKategori.Name = "cbxUpdateKategori";
            this.cbxUpdateKategori.Size = new System.Drawing.Size(100, 21);
            this.cbxUpdateKategori.TabIndex = 15;
            // 
            // tbxUpdateFiyat
            // 
            this.tbxUpdateFiyat.Location = new System.Drawing.Point(139, 208);
            this.tbxUpdateFiyat.Name = "tbxUpdateFiyat";
            this.tbxUpdateFiyat.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdateFiyat.TabIndex = 14;
            // 
            // tbxUpdateBirimAdet
            // 
            this.tbxUpdateBirimAdet.Location = new System.Drawing.Point(139, 170);
            this.tbxUpdateBirimAdet.Name = "tbxUpdateBirimAdet";
            this.tbxUpdateBirimAdet.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdateBirimAdet.TabIndex = 13;
            // 
            // tbxUpdateStok
            // 
            this.tbxUpdateStok.Location = new System.Drawing.Point(139, 129);
            this.tbxUpdateStok.Name = "tbxUpdateStok";
            this.tbxUpdateStok.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdateStok.TabIndex = 12;
            // 
            // tbxUpdateUrunAd
            // 
            this.tbxUpdateUrunAd.Location = new System.Drawing.Point(139, 37);
            this.tbxUpdateUrunAd.Name = "tbxUpdateUrunAd";
            this.tbxUpdateUrunAd.Size = new System.Drawing.Size(100, 20);
            this.tbxUpdateUrunAd.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Fiyat :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Stok Adet :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Birim Adet:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Kategori No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ürün Adı :";
            // 
            // btnUrunSil
            // 
            this.btnUrunSil.Location = new System.Drawing.Point(667, 358);
            this.btnUrunSil.Name = "btnUrunSil";
            this.btnUrunSil.Size = new System.Drawing.Size(100, 23);
            this.btnUrunSil.TabIndex = 17;
            this.btnUrunSil.Text = "Ürün Sil";
            this.btnUrunSil.UseVisualStyleBackColor = true;
            this.btnUrunSil.Click += new System.EventHandler(this.btnUrunSil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 652);
            this.Controls.Add(this.btnUrunSil);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxProductAdd);
            this.Controls.Add(this.gbxUrunArama);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxUrunArama.ResumeLayout(false);
            this.gbxUrunArama.PerformLayout();
            this.gbxProductAdd.ResumeLayout(false);
            this.gbxProductAdd.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.GroupBox gbxUrunArama;
        private System.Windows.Forms.Label lblUrunArama;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Label lblKategoriArama;
        private System.Windows.Forms.GroupBox gbxProductAdd;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblCategoryId;
        private System.Windows.Forms.Label lblStockAmount;
        private System.Windows.Forms.TextBox tbxFiyat;
        private System.Windows.Forms.TextBox tbxQuantityPerUnit;
        private System.Windows.Forms.TextBox tbxStokAdet;
        private System.Windows.Forms.TextBox tbxUrunAd;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.Label lblUnitsInStock;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.ComboBox cbxKategoriId_UrunEkle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.ComboBox cbxUpdateKategori;
        private System.Windows.Forms.TextBox tbxUpdateFiyat;
        private System.Windows.Forms.TextBox tbxUpdateBirimAdet;
        private System.Windows.Forms.TextBox tbxUpdateStok;
        private System.Windows.Forms.TextBox tbxUpdateUrunAd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnUrunSil;
    }
}

