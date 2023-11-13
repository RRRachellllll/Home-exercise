
using Bll;
using EntityFrameWork;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuyController : ControllerBase
    {
        BuyIBll BuyIBll;
        public BuyController(BuyIBll buyIBll)
        {
            this.BuyIBll = buyIBll;
        }
        // GET: api/<BuyController>
        [HttpGet]
        public List<Buy> Get()
        {
            return BuyIBll.GetAllBuys();
        }
        // GET api/<BuyController>/5
        [HttpGet("{id}")]
        public Buy Get(int id)
        {
            return BuyIBll.GetBuyById(id);
        }

        // POST api/<BuyController>
        [HttpPost]
        public void Post(Buy b)
        {
            BuyIBll.AddBuy(b);
        }

        // PUT api/<BuyController>/5
        [HttpPut("{id}")]
        public void Put(int id, Buy b)
        {
            BuyIBll.UpdateBuy(id, b);
        }

        // DELETE api/<BuyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            BuyIBll.DeleteBuy(id);
        }
    }
}
