using EntityFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dal
{
    public class BuyDal:BuyIDal
    {
        ShopingContext db = new ShopingContext();

        public void AddBuy(Buy buy)
        {
           db.Buys.Add(buy);
           db.SaveChanges();
        }

        public void DeleteBuy(int Id)
        {
           db.Buys.Remove(db.Buys.FirstOrDefault(x => x.Id == Id));
           db.SaveChanges();
        }

        public List<Buy> GetAllBuy()
        {
            return db.Buys.ToList();
        }

        public Buy GetBuyById(int Id)
        {
            return db.Buys.FirstOrDefault(x => x.Id == Id);
        }

        public void UpdateBuy(int Id, Buy buy)
        {
            var b=db.Buys.FirstOrDefault(x=>x.Id==Id);
            if (b!=null)
            {
                b.Count=buy.Count;
                db.SaveChanges();
            }
        }

    }
}
