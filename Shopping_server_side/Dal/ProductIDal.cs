using EntityFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    public interface ProductIDal
    {
        List<Product> GetAllProduct();
        Product GetProductById(int Id);
        List<Product> GetProductByCategoryId(int Id);
        void AddProduct(Product product);
        void UpdateProduct(int Id, Product product);
        void DeleteProduct(int Id);
    }
}
