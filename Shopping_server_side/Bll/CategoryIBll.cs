using EntityFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bll
{
    public interface CategoryIBll
    {
        List<Category> GetAllCategory();
        Category GetCategoryById(int Id);
        List<Category> GetCategoryByBuyId(int Id);
        void AddCategory(Category d);
        void UpdateCategory(int Id, Category d);
        void DeleteCategory(int Id);
    }
}
