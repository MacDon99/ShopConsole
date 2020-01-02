using System;
using ShopConsole.Models;

namespace ShopConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Wholesaler wholesaler = new Wholesaler();
            Customer customer = new Customer();

            wholesaler.AddArticle("maciej",2,DateTime.Now, 15M);
            wholesaler.AddArticle("bakłażan",5,DateTime.Now,12M);
            Shop shop = new Shop("MaciejShop");
            shop.AddArticle("rzodkiewka",12,DateTime.Now,4.2M);
            shop.AddArticle("burak",15,DateTime.Now,2.2M);
            shop.AddArticle("ziemniak",300,DateTime.Now,1.5M);

            System.Console.WriteLine("!!!Receiving articles from a wholesaler!!!");
            shop.ReceiveArticles(wholesaler);
            shop.DrawArticles();
            System.Console.WriteLine("!!!Selling products to a client!!!");
            shop.SellProducts(customer);
            customer.DrawArticles();         

        }
    }
}
