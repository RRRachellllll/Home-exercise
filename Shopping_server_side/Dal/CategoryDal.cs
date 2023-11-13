using EntityFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class CategoryDal : CategoryIDal
    {
        ShopingContext db = new ShopingContext();

        public void AddCategory(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
        }

        public void DeleteCategory(int Id)
        {
            db.Remove(db.Categories.FirstOrDefault(c => c.Id == Id));
            db.SaveChanges();
        }

        public List<Category> GetAllCategory()
        {
            return db.Categories.ToList();
        }

        public List<Category> GetCategoryByBuyId(int Id)
        {
            return db.Categories.Where(x => x.BuyId == Id).ToList();
        }

        public Category GetCategoryById(int Id)
        {
            return db.Categories.FirstOrDefault(c => c.Id == Id);
        }

        public void UpdateCategory(int Id, Category category)
        {
            var c = db.Categories.FirstOrDefault(c => c.Id == Id);
            if(c!= null)
            {
                c.Count = category.Count;
                c.Name = category.Name;
                c.BuyId=category.BuyId;
                db.SaveChanges();
            }
        }
    }
}
