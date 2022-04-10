using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICategoryService
    {
        void CategoryAdd(Category p);
        void ContegoryUpdate(Category p);
        void ContegoryDelete(Category p);
    }
}
