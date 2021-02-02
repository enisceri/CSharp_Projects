using Kitaplar.Business.Abstract;
using Kitaplar.Business.DependencyResolvers.Ninject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kitaplar.WebFormsUI
{
    public partial class Form1 : Form
    {
        private IKategoriService _kategoriService;
        private IKitapService _kitapService;

        public Form1()
        {
            InitializeComponent();
            _kategoriService = InstanceFactory.GetInstance<IKategoriService>();
            _kitapService = InstanceFactory.GetInstance<IKitapService>();


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadKitaplar();
            LoadKategoriler();


        }

        private void btnEkleKitap_Click(object sender, EventArgs e)
        {

        }

        private void LoadKitaplar()
        {
            dgwKitaplar.DataSource = _kitapService.GetAll();
        }

        private void LoadKategoriler()
        {
            cbxAraKategori.DataSource = _kategoriService.GetAll();
            cbxAraKategori.DisplayMember = "KategoriAd";
            cbxAraKategori.ValueMember = "KategoriId";

            cbxEkleKategori.DataSource = _kategoriService.GetAll();
            cbxEkleKategori.DisplayMember = "KategoriAd";
            cbxEkleKategori.ValueMember = "KategoriId";
            
        }
    }
}
