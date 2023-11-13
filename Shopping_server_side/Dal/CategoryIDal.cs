using EntityFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface CategoryIDal
    {
        List<Category> GetAllCategory();
        Category GetCategoryById(int Id);
        List<Category> GetCategoryByBuyId(int Id);
        void AddCategory(Category category);
        void UpdateCategory(int Id, Category category);
        void DeleteCategory(int Id);
    }
}
