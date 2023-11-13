using Dal;
using EntityFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class ProductBll : ProductIBll
    {
        ProductIDal productIDal;

        public ProductBll(ProductIDal productIDal)
        {
            this.productIDal = productIDal;
        }

        public void AddProduct(Product d)
        {
            productIDal.AddProduct(d);
        }

        public void DeleteProduct(int Id)
        {
            productIDal.DeleteProduct(Id);
        }

        public List<Product> GetAllProduct()
        {
            return productIDal.GetAllProduct();
        }

        public List<Product> GetProductByCategoryId(int Id)
        {
            return productIDal.GetProductByCategoryId(Id);
        }

        public Product GetProductById(int Id)
        {
            return productIDal.GetProductById(Id);
        }

        public void UpdateProduct(int Id, Product product)
        {
            productIDal.UpdateProduct(Id, product);
        }
    }
}
