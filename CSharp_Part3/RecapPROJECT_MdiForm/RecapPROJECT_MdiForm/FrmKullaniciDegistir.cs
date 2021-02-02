using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapPROJECT_MdiForm
{
    public partial class FrmKullaniciDegistir : Form
    {
        FrmAktifKullanici aktifKullanici = new FrmAktifKullanici();

        public FrmKullaniciDegistir()
        {
            InitializeComponent();
        }

        private void btnKullaniciDegistir_Click(object sender, EventArgs e)
        {
            aktifKullanici.kullanici = tbxKullaniciAdi.Text;
            
            aktifKullanici.FormBorderStyle = FormBorderStyle.None;

            lblGorunecekKullanici.Text = tbxKullaniciAdi.Text;
        }

        private void FrmKullaniciDegistir_Load(object sender, EventArgs e)
        {

        }
    }
}
