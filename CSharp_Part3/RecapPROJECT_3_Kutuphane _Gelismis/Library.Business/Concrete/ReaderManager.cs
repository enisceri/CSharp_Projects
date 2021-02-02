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
    public class ReaderManager : IReaderService
    {
        private IReaderDal _readerDal;

        public ReaderManager(IReaderDal readerDal)
        {
            _readerDal = readerDal;
        }

        public void Add(Reader reader)
        {
            ReaderValidation(reader);
            _readerDal.AddEntity(reader);
        }

        public void Delete(Reader reader)
        {
            _readerDal.DeleteEntity(reader);
        }

        public List<Reader> GetAll()
        {
            return _readerDal.GetAll();
        }

        public List<Reader> GetBooksByBookId(int bookId)
        {
            return _readerDal.GetAll(p => p.BookId == bookId);
        }

        public List<Reader> GetBooksByBookName(string searchKey)
        {
            return _readerDal.GetAll(p => p.BookName.ToLower().Contains(searchKey.ToLower()));
        }

        public List<Reader> GetBooksByCategory(int categoryId)
        {
            return _readerDal.GetAll(p => p.CategoryId == categoryId);
        }

        public List<Reader> GetBooksByUserId(int userId)
        {
            return _readerDal.GetAll(p => p.UserId == userId);
        }

        public List<Reader> GetBooksByUserName(string userName)
        {
            return _readerDal.GetAll(p => p.UserName.ToLower().Contains(userName.ToLower()));
        }

        public void Update(Reader reader)
        {
            ReaderValidation(reader);
            _readerDal.UpdateEntity(reader);
        }

        private void ReaderValidation(Reader reader)
        {
            ReaderValidator readerValidator = new ReaderValidator();
            var result = readerValidator.Validate(reader);

            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
