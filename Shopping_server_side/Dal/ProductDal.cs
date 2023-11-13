using EntityFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public class ProductDal : ProductIDal
    {
        ShopingContext db=new ShopingContext();

        public void AddProduct(Product product)
        {
            db.Products.Add(product);  
            db.SaveChanges();
        }

        public void DeleteProduct(int Id)
        {
            db.Products.Remove(db.Products.FirstOrDefault(p => p.Id == Id));
            db.SaveChanges();
        }

        public List<Product> GetAllProduct()
        {
            return db.Products.ToList();
        }

        public List<Product> GetProductByCategoryId(int Id)
        {
            return db.Products.Where(p => p.Id == Id).ToList();
        }

        public Product GetProductById(int Id)
        {
            return db.Products.FirstOrDefault(p=>p.Id==Id);
        }

        public void UpdateProduct(int Id, Product product)
        {
            var p = db.Products.FirstOrDefault(x => x.Id == Id);
            if (p != null)
            {
                p.Count = product.Count;
                p.Name = product.Name;
                p.CategoryId=product.CategoryId;
                db.SaveChanges();
            }
        }
    }
}
