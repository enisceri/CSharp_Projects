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
    public class UserManager : IUserService
    {
        private IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            UserValidation(user);
            _userDal.AddEntity(user);
        }

        public void Delete(User user)
        {
            _userDal.DeleteEntity(user);
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public void Update(User user)
        {
            UserValidation(user);
            _userDal.UpdateEntity(user);
        }

        private void UserValidation(User user)
        {
            UserValidator userValidator = new UserValidator();
            var result = userValidator.Validate(user);

            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
