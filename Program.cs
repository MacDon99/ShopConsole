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
//Some data as an example
            wholesaler.AddArticle("maciej",2,DateTime.Now, 15M);
            wholesaler.AddArticle("bakłażan",5,DateTime.Now,12M);
            Shop shop = new Shop("MaciejShop");
            shop.AddArticle("rzodkiewka",12,DateTime.Now,4.2M);
            shop.AddArticle("burak",15,DateTime.Now,2.2M);
            shop.AddArticle("ziemniak",300,DateTime.Now,1.5M);
 //
            string odp="";
            do
            {
                System.Console.WriteLine("Welcome to our ShopSystem.\nAt first you have to declare if you are a shop owner (o) or just a client (c) by typing o or c. ");
                odp = Console.ReadLine();
                switch(odp)
                {
                    case "o":
                    do
                    {
                    System.Console.WriteLine("You are in shop management system.\nDo you want to buy articles(b) or see what you have in storage?(s)");
                    odp = Console.ReadLine();
                    switch(odp)
                    {
                        case "b": shop.ReceiveArticles(wholesaler);
                        break;
                        case "s": shop.DrawArticles();
                        break;
                        case "x": odp="end1";
                        break;
                    }
                    }while(odp !="end1");
                    break;
                    case "c":
                    do
                    {
                        System.Console.WriteLine("You are a client in a shop.\nDo you want to buy articles(a) or to see your basket(b)?");
                        odp = Console.ReadLine();
                        switch(odp)
                        {
                            case "a": shop.SellProducts(customer);
                            break;
                            case "b":customer.DrawArticles();
                            break;
                            case "x": odp = "end1";
                            break;
                        }
                    }while(odp !="end1");
                    break;
                    case "x":odp = "end";
                    break;
                }

            }while(odp !="end");

        }
    }
}
