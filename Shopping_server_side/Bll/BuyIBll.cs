using EntityFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bll
{
    public interface BuyIBll
    {
        List<Buy> GetAllBuys();
        Buy GetBuyById(int Id);
        void AddBuy(Buy b);
        void UpdateBuy(int Id, Buy b);
        void DeleteBuy(int Id);
    }
}
