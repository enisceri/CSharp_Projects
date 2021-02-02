using Library.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Entities.Concrete
{
    public class Book:IEntity
    {
        public int BookId { get; set; } //Kitap Id
        public string BookName { get; set; } //Kitap Ad
        public string AuthorName { get; set; } //Yazar adi
        public int CategoryId { get; set; } // Kategori No
        public int NumberOfPages { get; set; } //Sf sayisi
        public string Publisher { get; set; }
        public int PrintNo { get; set; } //Baski No
        public int NumberOfVolumes { get; set; } // Cilt No

    }
}
