using Library.Business.Abstract;
using Library.Business.DependencyResolvers.Ninject;
using Library.DataAccess.Abstract;
using Library.DataAccess.Concrete.EntityFramework;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library.WebFormsUI
{
    public partial class frmAnaSayfa : Form
    {


        frmKategoriler kategoriler = new frmKategoriler();
        frmKitaplar formKitaplar = new frmKitaplar();
        FrmKullanicilar kullanicilar = new FrmKullanicilar();
        public frmAnaSayfa()
        {
            InitializeComponent();


        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }





        private void btnKitaplar_Click(object sender, EventArgs e)
        {         
            CallForm(formKitaplar);
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

        private void btnKategoriler_Click(object sender, EventArgs e)
        {
            CallForm(kategoriler);
            
        }

        private void btnKullanicilar_Click(object sender, EventArgs e)
        {
            CallForm(kullanicilar);
        }
    }
}
