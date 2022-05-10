using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    internal interface ICategoryService
    {
        void CategoryAdd(Category category);
        Category GetById(int id);
        void CategoryDelete(Category category);
        void CategoryUpdate(Category category);
        List<Category> GetAllCategories();
    }
}
