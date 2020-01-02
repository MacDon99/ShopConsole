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
            wholesaler.AddArticle("maciej",2,DateTime.Now);
            wholesaler.AddArticle("bakłażan",5,DateTime.Now);
            Shop shop = new Shop("MaciejShop");
            System.Console.WriteLine("!!!Receiving articles from a wholesaler!!!");
            shop.ReceiveArticles(wholesaler);
            shop.DrawArticles();
            System.Console.WriteLine("!!!Selling products to a client!!!");
            shop.SellProducts(customer);
            shop.DrawArticles();         
        }
    }
}
