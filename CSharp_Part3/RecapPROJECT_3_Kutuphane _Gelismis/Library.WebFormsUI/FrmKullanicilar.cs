using Library.Business.Abstract;
using Library.Business.DependencyResolvers.Ninject;
using Library.DataAccess.Abstract;
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
    public partial class FrmKullanicilar : Form
    {
        private IUserService _userService;
        private IUserDal _userDal;
        private IReaderService _readerService;
        private IReaderDal _readerDal;
        private IBookService _bookService;
        private IBookDal _bookDal;
        private ICategoryService _categoryService;
        public FrmKullanicilar()
        {
            InitializeComponent();
            _userService = InstanceFactory.GetInstance<IUserService>();
            _userDal = InstanceFactory.GetInstance<IUserDal>();

            _readerService = InstanceFactory.GetInstance<IReaderService>();
            _readerDal = InstanceFactory.GetInstance<IReaderDal>();

            _bookService = InstanceFactory.GetInstance<IBookService>();
            _bookDal = InstanceFactory.GetInstance<IBookDal>();

            _categoryService = InstanceFactory.GetInstance<ICategoryService>();
        }

        private void FrmKullanicilar_Load(object sender, EventArgs e)
        {
            ChangeColumnNames();
            LoadUsers();
            LoadReaders();
            LoadCategories();
            LoadBooks();


        }

        private void LoadBooks()
        {
            dgvKitaplar.DataSource = _bookService.GetAll();
        }

        private void LoadCategories()
        {
            cbxEkleKullanicilar.DataSource = _userService.GetAll();
            cbxEkleKullanicilar.DisplayMember = "UserName";
            cbxEkleKullanicilar.ValueMember = "UserId";

            cbxFiltreKategori.DataSource = _categoryService.GetAll();
            cbxFiltreKategori.DisplayMember = "CategoryName";
            cbxFiltreKategori.ValueMember = "CategoryId";
        }

        private void LoadReaders()
        {
            dgvOkunanKitaplar.DataSource = _readerService.GetAll();
        }

        private void LoadUsers()
        {
            dgvUsers.DataSource = _userService.GetAll();
        }

        private void ChangeColumnNames()
        {
            dgvUsers.DataSource = _userDal.GetAll();
            dgvUsers.Columns[0].HeaderText = "Kullanıcı Id";
            dgvUsers.Columns[1].HeaderText = "Kullanıcı Ad Soyad";

            dgvOkunanKitaplar.DataSource = _readerDal.GetAll();
            dgvOkunanKitaplar.Columns[0].HeaderText = "Okunan Kitap Id";
            dgvOkunanKitaplar.Columns[1].HeaderText = "Kullanıcı Id";
            dgvOkunanKitaplar.Columns[2].HeaderText = "Kullanıcı Ad Soyad";
            dgvOkunanKitaplar.Columns[3].HeaderText = "Kitap Id";
            dgvOkunanKitaplar.Columns[4].HeaderText = "Kitap Ad";
            dgvOkunanKitaplar.Columns[5].HeaderText = "Kategori Id";

            dgvKitaplar.DataSource = _bookDal.GetAll();

            dgvKitaplar.Columns[0].HeaderText = "Kitap Id";
            dgvKitaplar.Columns[1].HeaderText = "Kitap Adı";
            dgvKitaplar.Columns[2].HeaderText = "Yazar";
            dgvKitaplar.Columns[3].HeaderText = "Kategori";
            dgvKitaplar.Columns[4].HeaderText = "Sayfa Sayısı";
            dgvKitaplar.Columns[5].HeaderText = "Yayın Evi";
            dgvKitaplar.Columns[6].HeaderText = "Basım Yılı";
            dgvKitaplar.Columns[7].HeaderText = "Cilt No";




        }

        private void btnEkleKullanici_Click(object sender, EventArgs e)
        {
            try
            {
                _userService.Add(new User()
                {
                    UserName = tbxEkleKullanici.Text

                });
                MessageBox.Show("Yeni Kullanıcı Eklendi");
                LoadUsers();
                LoadCategories();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void btnGuncelleKullanici_Click(object sender, EventArgs e)
        {
            try
            {
                _userService.Update(new User
                {
                    UserId = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value),
                    UserName = tbxGuncelleKullanici.Text


                });
                MessageBox.Show("Kullanıcı Bilgileri Güncellendi");
                LoadUsers();
                LoadCategories();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void dgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxGuncelleKullanici.Text = dgvUsers.CurrentRow.Cells[1].Value.ToString();
        }

        private void btnSilKullanici_Click(object sender, EventArgs e)
        {
            if (dgvUsers.CurrentRow != null)
            {

                User user = new User
                {
                    UserId = Convert.ToInt32(dgvUsers.CurrentRow.Cells[0].Value)
                };

                _userService.Delete(user);


                MessageBox.Show("Kullanıcı Silindi.");
                LoadUsers();
            }
        }

        private void dgvKitaplar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxEkleKitapId.Text = dgvKitaplar.CurrentRow.Cells[0].Value.ToString();
            tbxEkleKitapAd.Text = dgvKitaplar.CurrentRow.Cells[1].Value.ToString();

            tbxEkleKategoriId.Text = dgvKitaplar.CurrentRow.Cells[3].Value.ToString();            
            


        }

        private void btnEkleOkunanlar_Click(object sender, EventArgs e)
        {
            try
            {
                Reader reader = new Reader();
                reader.BookId = Convert.ToInt32(tbxEkleKitapId.Text);
                reader.BookName = tbxEkleKitapAd.Text;
                reader.CategoryId = Convert.ToInt32(tbxEkleKategoriId.Text);
                reader.UserId = Convert.ToInt32(cbxEkleKullanicilar.SelectedValue);
                reader.UserName = cbxEkleKullanicilar.Text;

                _readerService.Add(reader);

                MessageBox.Show(reader.BookName + " " + reader.UserName + " okunanlar kısmına eklendi"); ;
                LoadReaders();
            }
            catch (Exception exception)
            {

                MessageBox.Show(exception.Message);
            }


        }

        private void btnOkunanKitapSil_Click(object sender, EventArgs e)
        {
            if (dgvOkunanKitaplar.CurrentRow != null)
            {

                Reader reader = new Reader
                {
                    ReaderId = Convert.ToInt32(dgvOkunanKitaplar.CurrentRow.Cells[0].Value)
                };

                _readerService.Delete(reader);


                MessageBox.Show("Kitap okunanlardan silindi.");
                LoadReaders();
            }
        }

        private void tbxFiltreKitapId_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxFiltreKitapId.Text))
            {
               dgvOkunanKitaplar.DataSource = _readerService.GetBooksByBookId(Convert.ToInt32(tbxFiltreKitapId.Text));
            }
            else
            {
                LoadReaders();
            }
        }

        private void FrmKullanicilar_Activated(object sender, EventArgs e)
        {
            LoadCategories();
            LoadBooks();
            LoadReaders();
        }

        private void tbxFiltreKitapAd_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxFiltreKitapAd.Text))
            {
                dgvOkunanKitaplar.DataSource = _readerService.GetBooksByBookName(tbxFiltreKitapAd.Text);
            }
            else
            {
                LoadReaders();
            }
        }

        private void cbxFiltreKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvOkunanKitaplar.DataSource = _readerService.GetBooksByCategory(Convert.ToInt32(cbxFiltreKategori.SelectedValue));

            }
            catch
            {
            }
        }

        private void tbxFiltreKullanicilar_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxFiltreKullanicilar.Text))
            {
                dgvOkunanKitaplar.DataSource = _readerService.GetBooksByUserName(tbxFiltreKullanicilar.Text);
            }
            else
            {
                LoadReaders();
            }
        }

        private void tbxFiltreKullaniciId_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxFiltreKullaniciId.Text))
            {
                dgvOkunanKitaplar.DataSource = _readerService.GetBooksByUserId(Convert.ToInt32(tbxFiltreKullaniciId.Text));
            }
            else
            {
                LoadReaders();
            }
        }
    }
}
