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
    public partial class FrmAnaSayfa : Form
    {
        FrmAktifKullanici aktifKullanici = new FrmAktifKullanici();
        FrmKullaniciDegistir kullaniciDegistir = new FrmKullaniciDegistir();
   
        public FrmAnaSayfa()
        {
            InitializeComponent();
        }

        private void btnAktifKullanici_Click(object sender, EventArgs e)
        {
            CallForm(aktifKullanici);
        }

        private void CallForm(Form form)
        {
            pnlCalismaAlani.Controls.Clear();
            form.MdiParent = this;
            form.FormBorderStyle = FormBorderStyle.None;
            pnlCalismaAlani.Controls.Add(form);

            form.Left = 0;
            form.Top = 0;
            
            form.Show();
        }

        private void btnKullaniciDegistir_Click(object sender, EventArgs e)
        {
            CallForm(kullaniciDegistir);
        }

        private void FrmAnaSayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
