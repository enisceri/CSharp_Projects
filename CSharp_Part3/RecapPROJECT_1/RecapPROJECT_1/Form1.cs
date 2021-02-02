using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecapPROJECT_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            ListCategories();
            ListProducts();
        }

        private void ListProducts()
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                dgwProduct.DataSource = northwindContext.Products.ToList();
            }
        }

        private void ListCategories()
        {

          
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                cbxKategori.DataSource = northwindContext.Categories.ToList();
                cbxKategori.DisplayMember = "CategoryName";
                cbxKategori.ValueMember = "CategoryId";

            }


        }

        private void ListProductsByCategory(int categoryId)
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                dgwProduct.DataSource = northwindContext.Products.Where(p =>p.CategoryId == categoryId).ToList();
            }
        }

        private void ListProductsByProductName(string key)
        {
            using (NorthwindContext northwindContext = new NorthwindContext())
            {
                dgwProduct.DataSource = northwindContext.Products.Where(p => p.ProductName.ToLower().Contains(key.ToLower())).ToList();
            }
        }

        private void cbxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                ListProductsByCategory(Convert.ToInt32(cbxKategori.SelectedValue));

            }
            catch
            {

                 
            }
        }




        private void tbxUrunAra_TextChanged(object sender, EventArgs e)
        {
            string key = tbxUrunAra.Text;
            if (string.IsNullOrEmpty(key))
            {
                ListProducts();
            }
            else
            {
                ListProductsByProductName(tbxUrunAra.Text);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListProducts();
        }
    }
}
