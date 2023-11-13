using EntityFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bll
{
    public interface ProductIBll
    {
        List<Product> GetAllProduct();
        Product GetProductById(int Id);
        List<Product> GetProductByCategoryId(int Id);
        void AddProduct(Product d);
        void UpdateProduct(int Id, Product product);
        void DeleteProduct(int Id);
    }
}
