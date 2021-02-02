using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_EntityFrameworkDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProductDal _productDal = new ProductDal();

        private void loadProduct()
        {
            dgwProduct.DataSource = _productDal.getAll();

        }

        private void searchProduct(string key)
        {
            //dgwProduct.DataSource = _productDal.getAll().Where(search => search.ProductName.ToLower().Contains(key.ToLower())).ToList();

            //2. Yol veri tabanina sorgu yapmaktir ve bu daha performanslidir.
            dgwProduct.DataSource = _productDal.getByName(key);
        }

        private void searchProductByPrice(decimal price)
        {
            dgwProduct.DataSource = _productDal.getByUnitPrice(price);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadProduct();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            _productDal.addProduct(new Product
            {
                ProductName = tbxProductName.Text,
                StockAmount = Convert.ToInt32(tbxStockAmount.Text),
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text)
            });
            loadProduct();
            MessageBox.Show("Product Added.");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _productDal.updateProduct(new Product
            {
                Id = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                ProductName = tbxProductNameUpdate.Text,
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text),
                 UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text)
            });
            loadProduct();
            MessageBox.Show("Product Updated");
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxProductNameUpdate.Text = dgwProduct.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPriceUpdate.Text = dgwProduct.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _productDal.deleteProduct(new Product
            {
                Id = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),

            });
            loadProduct();
            MessageBox.Show("Product Deleted");
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            searchProduct(tbxSearchByName.Text);
        }

        private void tbxSearchById_TextChanged(object sender, EventArgs e)
        {
            dgwProduct.DataSource = _productDal.getById(Convert.ToInt32(tbxSearchById.Text.ToString()));
        }

        private void tbxSearchByUnitPrice_TextChanged(object sender, EventArgs e)
        {

            searchProductByPrice(Convert.ToDecimal(tbxSearchByUnitPrice.Text));
        }
    }
}
