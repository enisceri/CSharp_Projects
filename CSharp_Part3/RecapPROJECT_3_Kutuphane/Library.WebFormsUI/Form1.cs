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
    public partial class Form1 : Form
    {   
        private IBookService _bookService;
        private ICategoryService _categoryService;
        private IBookDal _bookDal;



        public Form1()
        {
            InitializeComponent();
            _bookService = InstanceFactory.GetInstance<IBookService>();
            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
            _bookDal = InstanceFactory.GetInstance<IBookDal>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChangeColumnNames();
            LoadBooks();
            LoadCategories();


        }

        private void LoadCategories()
        {
            cbxAraKategori.DataSource = _categoryService.GetAll();
            cbxAraKategori.DisplayMember = "CategoryName";
            cbxAraKategori.ValueMember = "CategoryId";

            cbxEkleKategori.DataSource = _categoryService.GetAll();
            cbxEkleKategori.DisplayMember = "CategoryName";
            cbxEkleKategori.ValueMember = "CategoryId";

            cbxGuncelleKategori.DataSource = _categoryService.GetAll();
            cbxGuncelleKategori.DisplayMember = "CategoryName";
            cbxGuncelleKategori.ValueMember = "CategoryId";
            
        }

        private void LoadBooks()
        {
            dgvBooks.DataSource = _bookService.GetAll();
        }

        private void ChangeColumnNames()
        {
            dgvBooks.DataSource = _bookDal.GetAll();

            dgvBooks.Columns[0].HeaderText = "Kitap Id";
            dgvBooks.Columns[1].HeaderText = "Kitap Adı";
            dgvBooks.Columns[2].HeaderText = "Yazar";
            dgvBooks.Columns[3].HeaderText = "Kategori";
            dgvBooks.Columns[4].HeaderText = "Sayfa Sayısı";
            dgvBooks.Columns[5].HeaderText = "Yayın Evi";
            dgvBooks.Columns[6].HeaderText = "Baskı No";
            dgvBooks.Columns[7].HeaderText = "Cilt No";


        }

        private void btnEkleKitap_Click(object sender, EventArgs e)
        {
            _bookService.Add(new Book()
            {
                AuthorName = tbxEkleYazar.Text,
                BookName = tbxEkleKitapAd.Text,
                CategoryId = Convert.ToInt32(cbxEkleKategori.SelectedValue),
                NumberOfPages = Convert.ToInt32(tbxEkleSayfaSayisi.Text),
                NumberOfVolumes = Convert.ToInt32(tbxEkleCiltNo.Text),
                PrintNo = Convert.ToInt32(tbxEkleBaskiNo.Text),
                Publisher = tbxEkleYayinEvi.Text,

               

            });

            MessageBox.Show("Kitap Eklendi");
            LoadBooks();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _bookService.Update(new Book
            {
                BookId = Convert.ToInt32(dgvBooks.CurrentRow.Cells[0].Value),
                AuthorName = tbxGuncelleYazar.Text,
                BookName = tbxGuncelleKitapAd.Text,
                CategoryId = Convert.ToInt32(cbxGuncelleKategori.SelectedValue),
                NumberOfPages = Convert.ToInt32(tbxGuncelleSayfaSayisi.Text),
                NumberOfVolumes = Convert.ToInt32(tbxGuncelleCiltNo.Text),
                PrintNo = Convert.ToInt32(tbxGuncelleBaskiSayisi.Text),
                Publisher = tbxGuncelleYazar.Text


            });
            MessageBox.Show("Kitap Bilgileri Güncellendi");
            LoadBooks();
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxGuncelleKitapAd.Text = dgvBooks.CurrentRow.Cells[1].Value.ToString();
            tbxGuncelleYazar.Text = dgvBooks.CurrentRow.Cells[2].Value.ToString();
            cbxGuncelleKategori.SelectedValue = dgvBooks.CurrentRow.Cells[3].Value;
            tbxGuncelleSayfaSayisi.Text = dgvBooks.CurrentRow.Cells[4].Value.ToString();
            tbxGuncelleYayinEvi.Text = dgvBooks.CurrentRow.Cells[5].Value.ToString();
            tbxGuncelleBaskiSayisi.Text = dgvBooks.CurrentRow.Cells[6].Value.ToString();
            tbxGuncelleCiltNo.Text = dgvBooks.CurrentRow.Cells[7].Value.ToString();




        }

        private void bntSil_Click(object sender, EventArgs e)
        {
            if (dgvBooks.CurrentRow != null)
            {

                Book book = new Book
                {
                    BookId = Convert.ToInt32(dgvBooks.CurrentRow.Cells[0].Value)
                };

                _bookService.Delete(book);


                MessageBox.Show("Kitap Silindi.");
                LoadBooks();
            }

            else
            {
                MessageBox.Show("Silmek için kitap seçmeniz gerekmektedir");

            }
        }

        private void cbxAraKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvBooks.DataSource = _bookService.GetBooksByCategory(Convert.ToInt32(cbxAraKategori.SelectedValue));

            }
            catch
            {
            }
        }

        private void tbxAraKitapAd_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxAraKitapAd.Text))
            {
                dgvBooks.DataSource = _bookService.GetBooksByBookName(tbxAraKitapAd.Text);
            }
            else
            {
                LoadBooks();
            }
        }


        private void tbxAraYazar_TextChanged_1(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxAraYazar.Text))
            {
                dgvBooks.DataSource = _bookService.GetBooksByAuthorName(tbxAraYazar.Text);
            }
            else
            {
                LoadBooks();
            }
        }
    }
}
