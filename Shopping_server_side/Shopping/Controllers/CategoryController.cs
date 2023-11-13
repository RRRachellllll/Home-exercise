using Bll;
using EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        CategoryIBll categoryIBll;

        public CategoryController(CategoryIBll categoryIBll)
        {
            this.categoryIBll = categoryIBll;
        }

        // GET: api/<CategoryController>
        [HttpGet]
        public List<Category> Get()
        {
            return categoryIBll.GetAllCategory();
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public Category Get(int id)
        {
            return categoryIBll.GetCategoryById(id);    
        }

        [HttpGet("getbyBuyId/{BuyId}")]
        public List<Category> GetByBuyId(int BuyId)
        {
            return categoryIBll.GetCategoryByBuyId(BuyId);
        }

        // POST api/<CategoryController>
        [HttpPost]
        public void Post(Category c)
        {
            categoryIBll.AddCategory(c);
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public void Put(int id, Category c)
        {
            categoryIBll.UpdateCategory(id, c);
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            categoryIBll.DeleteCategory(id);
        }
    }
}
