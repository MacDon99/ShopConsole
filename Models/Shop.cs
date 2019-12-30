using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using ShopConsole.Models;

namespace ShopConsole
{
    public class Shop
    {
        public Shop(string shopName)
        {
            this.ShopName = shopName;

        }
        public string ShopName { get; set; }
        List<Article> Articles { get; set; }
        public void ReceiveArticles(Wholesaler wholesaler)
        {
            string answer="-1";
            do
            {
                System.Console.WriteLine("Chose an item to receive");
                foreach (var item in wholesaler.Articles)
                {
                    System.Console.WriteLine($"Id: {item.Id} Name: {item.Name}");
                }

                answer= Console.ReadLine();

                switch (answer)
                {
                    case "x" : System.Console.WriteLine("Thanks for using.");
                    break;
                    default: 
                    {
                        if (wholesaler.Articles[Convert.ToInt32(answer)] is null)
                            {
                                System.Console.WriteLine("Wrong item Id!");
                                return;
                            }
                        DrawDetails(wholesaler.Articles[Convert.ToInt32(answer)]);
                        System.Console.WriteLine("How much do you want to buy?");
                        int buyerQuantity = Convert.ToInt32(Console.ReadLine());
                        
                        System.Console.WriteLine("Type y if you want to receive more products or x if that's all you want.");
                    }
                    break;
                }

            } while (answer != "x");

        }
        public void SellProducts()
        {

        }
        private void DrawDetails(Article article)
        {
            Console.WriteLine($"Id: {article.Id} \nName: {article.Name}\nStorage Quantity: {article.Quantity}\nExpiration Date: {article.ExpirationDate}");
        }
    }
}