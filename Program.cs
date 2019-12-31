using System;

namespace ShopConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Wholesaler wholesaler = new Wholesaler();
            wholesaler.AddArticle("maciej",2,DateTime.Now);
            wholesaler.AddArticle("bakłażan",5,DateTime.Now);
            Shop shop = new Shop("MaciejShop");
            shop.ReceiveArticles(wholesaler);
            shop.DrawArticles();
            
            

        }
    }
}
