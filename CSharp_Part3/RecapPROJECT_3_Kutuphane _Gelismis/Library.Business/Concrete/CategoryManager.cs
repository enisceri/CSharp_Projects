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
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            CategoryValidation(category);
            _categoryDal.AddEntity(category);
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }

        public void Update(Category category)
        {
            CategoryValidation(category);
            _categoryDal.UpdateEntity(category);
        }

        private void CategoryValidation(Category category)
        {
            CategoryValidator categoryValidator = new CategoryValidator();
            var result = categoryValidator.Validate(category);

            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
