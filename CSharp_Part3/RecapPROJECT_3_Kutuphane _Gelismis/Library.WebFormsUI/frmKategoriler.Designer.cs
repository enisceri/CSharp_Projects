
namespace Library.WebFormsUI
{
    partial class frmKategoriler
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
            this.tbxKategoriEkle = new System.Windows.Forms.TextBox();
            this.cbxKategoriGor = new System.Windows.Forms.ComboBox();
            this.lblKategoriListesi = new System.Windows.Forms.Label();
            this.lblKategoriEkle = new System.Windows.Forms.Label();
            this.btnKategoriEkle = new System.Windows.Forms.Button();
            this.btnKategoriDegistir = new System.Windows.Forms.Button();
            this.chkbxDegistirOnay = new System.Windows.Forms.CheckBox();
            this.lblDegistirmeOnayi = new System.Windows.Forms.Label();
            this.lblEklemeOnayi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxKategoriEkle
            // 
            this.tbxKategoriEkle.Location = new System.Drawing.Point(297, 248);
            this.tbxKategoriEkle.Name = "tbxKategoriEkle";
            this.tbxKategoriEkle.Size = new System.Drawing.Size(140, 20);
            this.tbxKategoriEkle.TabIndex = 0;
            // 
            // cbxKategoriGor
            // 
            this.cbxKategoriGor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxKategoriGor.FormattingEnabled = true;
            this.cbxKategoriGor.Location = new System.Drawing.Point(297, 173);
            this.cbxKategoriGor.Name = "cbxKategoriGor";
            this.cbxKategoriGor.Size = new System.Drawing.Size(140, 21);
            this.cbxKategoriGor.TabIndex = 1;
            this.cbxKategoriGor.SelectedIndexChanged += new System.EventHandler(this.cbxKategoriGor_SelectedIndexChanged);
            // 
            // lblKategoriListesi
            // 
            this.lblKategoriListesi.AutoSize = true;
            this.lblKategoriListesi.Location = new System.Drawing.Point(198, 181);
            this.lblKategoriListesi.Name = "lblKategoriListesi";
            this.lblKategoriListesi.Size = new System.Drawing.Size(63, 13);
            this.lblKategoriListesi.TabIndex = 2;
            this.lblKategoriListesi.Text = "Kategoriler :";
            // 
            // lblKategoriEkle
            // 
            this.lblKategoriEkle.AutoSize = true;
            this.lblKategoriEkle.Location = new System.Drawing.Point(198, 251);
            this.lblKategoriEkle.Name = "lblKategoriEkle";
            this.lblKategoriEkle.Size = new System.Drawing.Size(73, 13);
            this.lblKategoriEkle.TabIndex = 3;
            this.lblKategoriEkle.Text = "Kategori İsmi :";
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.Location = new System.Drawing.Point(297, 298);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.Size = new System.Drawing.Size(140, 23);
            this.btnKategoriEkle.TabIndex = 4;
            this.btnKategoriEkle.Text = "EKLE";
            this.btnKategoriEkle.UseVisualStyleBackColor = true;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // btnKategoriDegistir
            // 
            this.btnKategoriDegistir.Location = new System.Drawing.Point(468, 298);
            this.btnKategoriDegistir.Name = "btnKategoriDegistir";
            this.btnKategoriDegistir.Size = new System.Drawing.Size(140, 23);
            this.btnKategoriDegistir.TabIndex = 5;
            this.btnKategoriDegistir.Text = "DEĞİŞTİR";
            this.btnKategoriDegistir.UseVisualStyleBackColor = true;
            this.btnKategoriDegistir.Click += new System.EventHandler(this.btnKategoriDegistir_Click);
            // 
            // chkbxDegistirOnay
            // 
            this.chkbxDegistirOnay.AutoSize = true;
            this.chkbxDegistirOnay.Location = new System.Drawing.Point(507, 251);
            this.chkbxDegistirOnay.Name = "chkbxDegistirOnay";
            this.chkbxDegistirOnay.Size = new System.Drawing.Size(105, 17);
            this.chkbxDegistirOnay.TabIndex = 6;
            this.chkbxDegistirOnay.Text = "Değiştirme Onayı";
            this.chkbxDegistirOnay.UseVisualStyleBackColor = true;
            this.chkbxDegistirOnay.CheckedChanged += new System.EventHandler(this.chkbxDegistirOnay_CheckedChanged);
            // 
            // lblDegistirmeOnayi
            // 
            this.lblDegistirmeOnayi.AutoSize = true;
            this.lblDegistirmeOnayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDegistirmeOnayi.ForeColor = System.Drawing.Color.Red;
            this.lblDegistirmeOnayi.Location = new System.Drawing.Point(198, 370);
            this.lblDegistirmeOnayi.Name = "lblDegistirmeOnayi";
            this.lblDegistirmeOnayi.Size = new System.Drawing.Size(513, 18);
            this.lblDegistirmeOnayi.TabIndex = 7;
            this.lblDegistirmeOnayi.Text = "(*) Kategori adını değiştirmek için  \"Değiştirme Onayı\" nı işaretleyin.";
            // 
            // lblEklemeOnayi
            // 
            this.lblEklemeOnayi.AutoSize = true;
            this.lblEklemeOnayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEklemeOnayi.ForeColor = System.Drawing.Color.Red;
            this.lblEklemeOnayi.Location = new System.Drawing.Point(198, 420);
            this.lblEklemeOnayi.Name = "lblEklemeOnayi";
            this.lblEklemeOnayi.Size = new System.Drawing.Size(462, 18);
            this.lblEklemeOnayi.TabIndex = 8;
            this.lblEklemeOnayi.Text = "(*) Yeni kategori eklemek için  \"Değiştirme Onayı\" nı kaldırın.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 167);
            this.panel1.TabIndex = 28;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::Library.WebFormsUI.Properties.Resources.çocuk;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(647, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 155);
            this.button5.TabIndex = 14;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Library.WebFormsUI.Properties.Resources.bilim;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(491, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 155);
            this.button4.TabIndex = 13;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::Library.WebFormsUI.Properties.Resources.dini;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(335, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 155);
            this.button3.TabIndex = 12;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Library.WebFormsUI.Properties.Resources.tarih;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(179, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 155);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Library.WebFormsUI.Properties.Resources.macera;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(23, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 155);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // frmKategoriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblEklemeOnayi);
            this.Controls.Add(this.lblDegistirmeOnayi);
            this.Controls.Add(this.chkbxDegistirOnay);
            this.Controls.Add(this.btnKategoriDegistir);
            this.Controls.Add(this.btnKategoriEkle);
            this.Controls.Add(this.lblKategoriEkle);
            this.Controls.Add(this.lblKategoriListesi);
            this.Controls.Add(this.cbxKategoriGor);
            this.Controls.Add(this.tbxKategoriEkle);
            this.Name = "frmKategoriler";
            this.Text = "frmKategoriler";
            this.Load += new System.EventHandler(this.frmKategoriler_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxKategoriEkle;
        private System.Windows.Forms.ComboBox cbxKategoriGor;
        private System.Windows.Forms.Label lblKategoriListesi;
        private System.Windows.Forms.Label lblKategoriEkle;
        private System.Windows.Forms.Button btnKategoriEkle;
        private System.Windows.Forms.Button btnKategoriDegistir;
        private System.Windows.Forms.CheckBox chkbxDegistirOnay;
        private System.Windows.Forms.Label lblDegistirmeOnayi;
        private System.Windows.Forms.Label lblEklemeOnayi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
    }
}