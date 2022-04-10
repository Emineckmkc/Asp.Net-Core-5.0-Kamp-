using BusinessLayer.Abstract;
using DataAccesslayer.Abstract;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public void CategoryAdd(Category p)
        {
            _categoryDal.Insert(p);
        }

        public void ContegoryDelete(Category p)
        {
            _categoryDal.Delete(p);
        }

        public void ContegoryUpdate(Category p)
        {
            _categoryDal.Update(p);
        }
    }
}
