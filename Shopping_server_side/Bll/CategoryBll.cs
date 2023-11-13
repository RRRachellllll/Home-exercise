using Dal;
using EntityFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class CategoryBll : CategoryIBll
    {
        CategoryIDal categoryIDal;

        public CategoryBll(CategoryIDal categoryIDal)
        {
            this.categoryIDal = categoryIDal;
        }

        public void AddCategory(Category d)
        {
           categoryIDal.AddCategory(d);
        }

        public void DeleteCategory(int Id)
        {
            categoryIDal.DeleteCategory(Id);
        }

        public List<Category> GetAllCategory()
        {
           return categoryIDal.GetAllCategory();
        }

        public List<Category> GetCategoryByBuyId(int Id)
        {
            return categoryIDal.GetCategoryByBuyId(Id);
        }

        public Category GetCategoryById(int Id)
        {
            return categoryIDal.GetCategoryById(Id);
        }

        public void UpdateCategory(int Id, Category d)
        {
            categoryIDal.UpdateCategory(Id, d); 
        }
    }
}
