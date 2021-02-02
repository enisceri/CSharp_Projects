using FluentValidation;
using Library.Business.Abstract;
using Library.Business.ValidationRules.FluentValidation;
using Library.DataAccess.Abstract;
using Library.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Concrete
{
    public class BookManager : IBookService
    {
        private IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public void Add(Book book)
        {
            BookValidation(book);            
            _bookDal.AddEntity(book);
            
        }

        public void Delete(Book book)
        {
            try
            {
                _bookDal.DeleteEntity(book);
            }
            catch (Exception)
            {

               throw new Exception("Silme gerçekleşemedi");

            }
        }

        public List<Book> GetAll()
        {
            return _bookDal.GetAll();

        }

        public List<Book> GetBooksByAuthorName(string authorName)
        {
            return _bookDal.GetAll(p => p.AuthorName.ToLower().Contains(authorName.ToLower()));
        }

        public List<Book> GetBooksByBookName(string searchKey)
        {
            return _bookDal.GetAll(p => p.BookName.ToLower().Contains(searchKey.ToLower()));

        }

        public List<Book> GetBooksByCategory(int categoryId)
        {
            return _bookDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Book> GetBooksByPublisher(string publisher)
        {
            return _bookDal.GetAll(p => p.Publisher.ToLower().Contains(publisher.ToLower()));
        }

  

        public void Update(Book book)
        {
            BookValidation(book);
            _bookDal.UpdateEntity(book);
        }

        private void BookValidation(Book book)
        {
            BookValidator bookValidator = new BookValidator();
            var result = bookValidator.Validate(book);

            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
