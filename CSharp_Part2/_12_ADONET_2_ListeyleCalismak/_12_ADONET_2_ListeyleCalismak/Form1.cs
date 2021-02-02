using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_ADONET_2_ListeyleCalismak
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ProductDal _productDal = new ProductDal();

        private void loadProducts()
        {
            dgwProduct.DataSource = _productDal.getAll();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            loadProducts();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                ProductName = tbxProductName.Text,
                StockAmount = Convert.ToInt32(tbxStockAmount.Text),
                UnitPrice = Convert.ToDecimal(tbxUnitPrice.Text)
            };

            _productDal.addProduct(product);
            MessageBox.Show(product.ProductName + " added.");
            loadProducts();
        }

        private void dgwProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxProductNameUpdate.Text = dgwProduct.CurrentRow.Cells[1].Value.ToString();
            tbxUnitPriceUpdate.Text = dgwProduct.CurrentRow.Cells[2].Value.ToString();
            tbxStockAmountUpdate.Text = dgwProduct.CurrentRow.Cells[3].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Product product = new Product
            {
                Id = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value),
                ProductName = tbxProductNameUpdate.Text,
                StockAmount = Convert.ToInt32(tbxStockAmountUpdate.Text),
                UnitPrice = Convert.ToDecimal(tbxUnitPriceUpdate.Text)
            };
            _productDal.updateProduct(product);
            loadProducts();
            MessageBox.Show("Updated");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgwProduct.CurrentRow.Cells[0].Value);

            DialogResult dialogResult = MessageBox.Show(dgwProduct.CurrentRow.Cells[1].Value + " is gonna be deleted. Are You Sure?", "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                _productDal.deleteProduct(id);
                MessageBox.Show(dgwProduct.CurrentRow.Cells[1].Value.ToString() + " deleted");

            }
            else if (dialogResult == DialogResult.No)
            {

            }


            
            loadProducts();

        }
    }
}
