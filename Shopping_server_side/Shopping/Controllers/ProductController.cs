using Bll;
using EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        ProductIBll productIBll;

        public ProductController(ProductIBll productIBll)
        {
            this.productIBll = productIBll;
        }

        // GET: api/<ProductBll>
        [HttpGet]
        public List<Product> Get()
        {
            return productIBll.GetAllProduct();
        }

        // GET api/<ProductBll>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return productIBll.GetProductById(id);
        }

        [HttpGet("categoryId/{Categoryid}")]
        public List<Product> GetByCategoryId(int Categoryid)
        {
            return productIBll.GetProductByCategoryId(Categoryid);
        }

        // POST api/<ProductBll>
        [HttpPost]
        public void Post(Product p)
        {
            productIBll.AddProduct(p);
        }

        // PUT api/<ProductBll>/5
        [HttpPut("{id}")]
        public void Put(int id, Product p)
        {
            productIBll.UpdateProduct(id, p);
        }

        // DELETE api/<ProductBll>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            productIBll.DeleteProduct(id);  
        }
    }
}
