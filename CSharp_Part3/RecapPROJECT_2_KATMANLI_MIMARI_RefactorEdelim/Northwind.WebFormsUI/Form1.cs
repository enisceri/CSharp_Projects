using Northwind.Business.Abstract;
using Northwind.Business.Concrete;
using Northwind.Business.DependencyResolvers.Ninject;
using Northwind.DataAccess.Concrete.EntityFramework;
using Northwind.DataAccess.Concrete.NHibernate;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Northwind.WebFormsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //_productService = new ProductManager(new EfProductDal());
            //_categoryService = new CategoryManager(new EfCategoryDal());
            //Bu sekilde new'leme yapilmamali. Dependency yani SOLID'in D'sine uymaz.
            _productService = InstanceFactory.GetInstance<IProductService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();

        }
        private void LoadProducts()
        {
            dgwProduct.DataSource = _productService.GetAll();

        }
        private IProductService _productService;
        private ICategoryService _categoryService;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProducts();
            LoadCategories();

        }

        private void LoadCategories()
        {
            cbxCategory.DataSource = _categoryService.GetAll();
            cbxCategory.DisplayMember = "CategoryName";
            cbxCategory.ValueMember = "CategoryId";

            cbxKategoriId_UrunEkle.DataSource = _categoryService.GetAll();
            cbxKategoriId_UrunEkle.DisplayMember = "CategoryName";
            cbxKategoriId_UrunEkle.ValueMember = "CategoryId";

            cbxUpdateKategori.DataSource = _categoryService.GetAll();
            cbxUpdateKategori.DisplayMember = "CategoryName";
            cbxUpdateKategori.ValueMember = "CategoryId";

        }

        private void cbxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgwProduct.DataSource = _productService.GetProductsByCategory(Convert.ToInt32(cbxCategory.SelectedValue));
    
            }
            catch
            {
            }
        }

        private void tbxProductName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxProductName.Text))
            {
                dgwProduct.DataSource = _productService.GetProductsByProductName(tbxProductName.Text);
            }
            else
            {
                LoadProducts();
            }
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Add(new Product()
                {
                    CategoryId = Convert.ToInt32(cbxKategoriId_UrunEkle.SelectedValue),
                    ProductName = tbxUrunAd.Text,
                    QuantityPerUnit = tbxQuantityPerUnit.Text,
                    UnitPrice = Convert.ToDecimal(tbxFiyat.Text),
                    UnitsInStock = Convert.ToInt16(tbxStokAdet.Text)
                });
                MessageBox.Show("Ürün Kaydedildi.");
                LoadProducts();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                
            }

            
          
                
                
            

        }

 

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxUpdateUrunAd.Text = dgwProduct.CurrentRow.Cells[2].Value.ToString();
            cbxUpdateKategori.SelectedValue = dgwProduct.CurrentRow.Cells[1].Value;
            tbxUpdateFiyat.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
            tbxUpdateBirimAdet.Text = dgwProduct.CurrentRow.Cells[4].Value.ToString();
            tbxUpdateStok.Text = dgwProduct.CurrentRow.Cells[5].Value.ToString();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                _productService.Update(new Product
                {
                    ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                    CategoryId = Convert.ToInt32(cbxUpdateKategori.SelectedValue),
                    ProductName = tbxUpdateUrunAd.Text,
                    QuantityPerUnit = tbxUpdateBirimAdet.Text,
                    UnitPrice = Convert.ToDecimal(tbxUpdateFiyat.Text),
                    UnitsInStock = Convert.ToInt16(tbxUpdateStok.Text)


                });
                MessageBox.Show("Ürün Güncellendi");
                LoadProducts();

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);                
            }

        }

        private void btnUrunSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgwProduct.CurrentRow != null)
                {
                    _productService.Delete(new Product
                    {
                        ProductId = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value)
                    });

                    MessageBox.Show("Ürün Silindi.");
                    LoadProducts();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }



        }
    }
}
