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
            
            foreach(var item in wholesaler.Articles)
            {
                System.Console.WriteLine(item.Id);
                System.Console.WriteLine(item.Name);
                System.Console.WriteLine(item.Quantity);
                System.Console.WriteLine(item.ExpirationDate);
            }
            Shop shop = new Shop("MaciejShop");
            shop.ReceiveArticles(wholesaler);


        }
    }
}
