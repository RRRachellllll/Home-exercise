using EntityFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dal
{
    public interface BuyIDal
    {
        List<Buy> GetAllBuy();
        Buy GetBuyById(int Id);
        void AddBuy(Buy buy);
        void UpdateBuy(int Id, Buy buy);
        void DeleteBuy(int Id);
    }
}
