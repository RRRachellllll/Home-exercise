using Dal;
using EntityFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll
{
    public class BuyBll : BuyIBll
    {
        BuyIDal buyIDal;

        public BuyBll(BuyIDal buyIDal)
        {
            this.buyIDal = buyIDal;
        }

        public void AddBuy(Buy b)
        {
           buyIDal.AddBuy(b);
        }

        public void DeleteBuy(int Id)
        {
            buyIDal.DeleteBuy(Id);
        }

        public List<Buy> GetAllBuys()
        { 
           return buyIDal.GetAllBuy();
        }

        public Buy GetBuyById(int Id)
        {
            return buyIDal.GetBuyById(Id);
        }

        public void UpdateBuy(int Id, Buy b)
        {
            buyIDal.UpdateBuy(Id, b);
        }
    }
}
