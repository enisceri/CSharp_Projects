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
    public partial class FrmAktifKullanici : Form
    {
        public string kullanici 
        {
            get
            {
                return lblKullaniciAdi.Text;
            }
            set
            {
                lblKullaniciAdi.Text = kullanici;
            }

        }

        public FrmAktifKullanici()
        {
            InitializeComponent();
        }




        private void FrmAktifKullanici_Load(object sender, EventArgs e)
        {
            lblKullaniciAdi.Text = kullanici;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblKullaniciAdi.Text = "Aktif Kullanıcııııııııııııııııı";
        }
    }
}
