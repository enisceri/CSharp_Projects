
namespace RecapPROJECT_1
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
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.lblKategori = new System.Windows.Forms.Label();
            this.cbxKategori = new System.Windows.Forms.ComboBox();
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxAra = new System.Windows.Forms.GroupBox();
            this.lblUrunAra = new System.Windows.Forms.Label();
            this.tbxUrunAra = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbxCategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxAra.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.button1);
            this.gbxCategory.Controls.Add(this.lblKategori);
            this.gbxCategory.Controls.Add(this.cbxKategori);
            this.gbxCategory.Location = new System.Drawing.Point(25, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(426, 107);
            this.gbxCategory.TabIndex = 0;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategoriye Göre Listele";
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(6, 41);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(52, 13);
            this.lblKategori.TabIndex = 1;
            this.lblKategori.Text = "Kategori :";
            // 
            // cbxKategori
            // 
            this.cbxKategori.FormattingEnabled = true;
            this.cbxKategori.Items.AddRange(new object[] {
            "Tüm Ürünler"});
            this.cbxKategori.Location = new System.Drawing.Point(71, 38);
            this.cbxKategori.Name = "cbxKategori";
            this.cbxKategori.Size = new System.Drawing.Size(121, 21);
            this.cbxKategori.TabIndex = 0;
            this.cbxKategori.SelectedIndexChanged += new System.EventHandler(this.cbxKategori_SelectedIndexChanged);
            // 
            // dgwProduct
            // 
            this.dgwProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(25, 143);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(858, 143);
            this.dgwProduct.TabIndex = 3;
            // 
            // gbxAra
            // 
            this.gbxAra.Controls.Add(this.tbxUrunAra);
            this.gbxAra.Controls.Add(this.lblUrunAra);
            this.gbxAra.Location = new System.Drawing.Point(457, 12);
            this.gbxAra.Name = "gbxAra";
            this.gbxAra.Size = new System.Drawing.Size(426, 107);
            this.gbxAra.TabIndex = 2;
            this.gbxAra.TabStop = false;
            this.gbxAra.Text = "Ürün Ara";
            // 
            // lblUrunAra
            // 
            this.lblUrunAra.AutoSize = true;
            this.lblUrunAra.Location = new System.Drawing.Point(6, 41);
            this.lblUrunAra.Name = "lblUrunAra";
            this.lblUrunAra.Size = new System.Drawing.Size(36, 13);
            this.lblUrunAra.TabIndex = 1;
            this.lblUrunAra.Text = "Ürün :";
            // 
            // tbxUrunAra
            // 
            this.tbxUrunAra.Location = new System.Drawing.Point(63, 34);
            this.tbxUrunAra.Name = "tbxUrunAra";
            this.tbxUrunAra.Size = new System.Drawing.Size(116, 20);
            this.tbxUrunAra.TabIndex = 2;
            this.tbxUrunAra.TextChanged += new System.EventHandler(this.tbxUrunAra_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Tüm Ürünleri Görüntüle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 343);
            this.Controls.Add(this.gbxAra);
            this.Controls.Add(this.dgwProduct);
            this.Controls.Add(this.gbxCategory);
            this.Name = "Form1";
            this.Text = "ÜRÜNLER";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxAra.ResumeLayout(false);
            this.gbxAra.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.ComboBox cbxKategori;
        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxAra;
        private System.Windows.Forms.Label lblUrunAra;
        private System.Windows.Forms.TextBox tbxUrunAra;
        private System.Windows.Forms.Button button1;
    }
}

