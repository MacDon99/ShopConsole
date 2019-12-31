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
            string answer;
            do
            {
                System.Console.WriteLine("Chose an item(id) to receive product or type x to exit.");
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
                        wholesaler.Articles[Convert.ToInt32(answer)].Quantity -= buyerQuantity;
                        int id = 0;
                        if(Articles is null)
                        {
                                 id=0;
                         }
                        else
                        {
                            id = Articles.Count;
                        }
                        Article article = new Article(id,wholesaler.Articles[Convert.ToInt32(answer)].Name,buyerQuantity,wholesaler.Articles[Convert.ToInt32(answer)].ExpirationDate );
                        if(Articles is null)
                        {
                            Articles = new List<Article>();
                        }
                        Articles.Add(article);
                    }
                    break;
                }

            } while (answer != "x");

        }
        public static void SellProducts()
        {

        }
        private void DrawDetails(Article article)
        {
            Console.WriteLine($"Id: {article.Id} \nName: {article.Name}\nStorage Quantity: {article.Quantity}\nExpiration Date: {article.ExpirationDate}");
        }
        public void DrawArticles()
        {
            System.Console.WriteLine("Storage has: ");
            foreach(var article in Articles)
            {
               Console.WriteLine($"Name: {article.Name} Storage Quantity: {article.Quantity} Expiration Date: {article.ExpirationDate}");
            }
        }
    }
}