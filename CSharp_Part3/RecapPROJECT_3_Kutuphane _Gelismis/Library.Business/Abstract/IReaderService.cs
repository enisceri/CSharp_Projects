using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Abstract
{
    public interface IReaderService
    {
        List<Reader> GetAll();
        List<Reader> GetBooksByCategory(int categoryId);
        List<Reader> GetBooksByBookName(string searchKey);
        List<Reader> GetBooksByBookId(int bookId);

        List<Reader> GetBooksByUserId(int userId);
        List<Reader> GetBooksByUserName(string userName);


        void Add(Reader reader);
        void Update(Reader reader);
        void Delete(Reader reader);
    }
}
