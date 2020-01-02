using System.Collections.Generic;

namespace ShopConsole.Models
{
    public class Basket
    {
        public List<Article> ArticlesToBuy { get; set;}
        public decimal RequiredMoney { get; set; }
    }
}