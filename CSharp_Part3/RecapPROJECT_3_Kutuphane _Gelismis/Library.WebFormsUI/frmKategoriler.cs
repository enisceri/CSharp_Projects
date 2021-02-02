using Library.Business.Abstract;
using Library.Business.DependencyResolvers.Ninject;
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
    public partial class frmKategoriler : Form
    {
        private ICategoryService _categoryServiceFrmCategory;
        private ICategoryService _categoryServiceFrmKitaplar;
        frmKitaplar kitapForm = new frmKitaplar();




        public frmKategoriler()
        {


            InitializeComponent();
            _categoryServiceFrmCategory = InstanceFactory.GetInstance<ICategoryService>();
            kitapForm._categoryService = InstanceFactory.GetInstance<ICategoryService>();
            _categoryServiceFrmKitaplar = InstanceFactory.GetInstance<ICategoryService>();
        }

        private void frmKategoriler_Load(object sender, EventArgs e)
        {
            
            LoadCategories();
        }

        private void LoadCategories()
        {
            cbxKategoriGor.DataSource = _categoryServiceFrmCategory.GetAll();
            cbxKategoriGor.DisplayMember = "CategoryName";
            cbxKategoriGor.ValueMember = "CategoryId";
            
        }



        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            try
            {
                _categoryServiceFrmCategory.Add(new Category
                {
                    CategoryName = tbxKategoriEkle.Text
                });

                MessageBox.Show("Yeni Kategori Eklendi");

                LoadCategories();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }



        }

        private void btnKategoriDegistir_Click(object sender, EventArgs e)
        {
            try
            {
                _categoryServiceFrmCategory.Update(new Category
                {

                    CategoryId = Convert.ToInt32(cbxKategoriGor.SelectedValue),
                    CategoryName = tbxKategoriEkle.Text
                });
                MessageBox.Show("Kategori Güncellendi");
                LoadCategories();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                
            }





        }

        private void chkbxDegistirOnay_CheckedChanged(object sender, EventArgs e)
        {
            if (chkbxDegistirOnay.Checked)
            {
                tbxKategoriEkle.Text = cbxKategoriGor.Text;
                btnKategoriEkle.Enabled = false;
                btnKategoriDegistir.Enabled = true;


            }
            else
            {
                tbxKategoriEkle.Text = "";
                btnKategoriEkle.Enabled = true;
                btnKategoriDegistir.Enabled = false;

                     
            }

        }

        private void cbxKategoriGor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(chkbxDegistirOnay.Checked)
            {
                tbxKategoriEkle.Text = cbxKategoriGor.Text;
                btnKategoriEkle.Enabled = false;
                btnKategoriDegistir.Enabled = true;

            }

            else
            {
                btnKategoriEkle.Enabled = true;
                btnKategoriDegistir.Enabled = false;
            }
        }
    }
}
