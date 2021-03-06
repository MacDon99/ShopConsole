using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using ShopConsole.Models;

namespace ShopConsole
{
    public class Shop
    {
        public string ShopName { get; set; }
        List<Article> Articles { get; set; }
        public Shop(string shopName)
        {
            this.ShopName = shopName;
        }

        public void ReceiveArticles(Wholesaler wholesaler)
        {
            string answer;
            do
            {
                System.Console.WriteLine("Chose an item(id) to receive product or type x to exit.");
                foreach (var item in wholesaler.Articles)
                {
                    System.Console.WriteLine($"Id: {item.Id} Name: {item.Name} Quantity: {item.Quantity}");
                }

                answer= Console.ReadLine();

                switch (answer)
                {
                    case "x" : System.Console.WriteLine("Thanks for using.");
                    break;
                    default: 
                    {
                        try
                        {
                            Convert.ToInt32(answer);
                        }
                        catch
                        {
                            System.Console.WriteLine("Wrong item Id!");
                            break;
                        }

                        if (wholesaler.Articles.Count-1 < Convert.ToInt32(answer))
                            {
                                System.Console.WriteLine("Wrong item Id!");
                                break;
                            }
                            
                        DrawDetails(wholesaler.Articles[Convert.ToInt32(answer)]);
                        System.Console.WriteLine("How much do you want to buy?");
                        var buyerQuantity = Console.ReadLine();

                        try
                        {
                            Convert.ToInt32(buyerQuantity);
                        }
                        catch
                        {
                            System.Console.WriteLine("Wrong number!");
                            break;
                        }
                        
                        if(wholesaler.Articles[Convert.ToInt32(answer)].Quantity < Convert.ToInt32(buyerQuantity))
                        {
                            System.Console.WriteLine("There's not enough stuff!");
                            break;
                        }
                        wholesaler.Articles[Convert.ToInt32(answer)].Quantity -= Convert.ToInt32(buyerQuantity);
                        int id = 0;
                        if(Articles is null)
                        {
                                 id=0;
                         }
                        else
                        {
                            id = Articles.Count;
                        }
                        Article article = new Article(id,wholesaler.Articles[Convert.ToInt32(answer)].Name,Convert.ToInt32(buyerQuantity),wholesaler.Articles[Convert.ToInt32(answer)].ExpirationDate, wholesaler.Articles[Convert.ToInt32(answer)].TotalPrice );
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
        public void SellProducts(Customer customer)
        {
            //System.Console.WriteLine("Welcome to our shop!");

            string answer;
            do
            {
                System.Console.WriteLine("Here is the list of our products. Choose one by typing the id.");
                try
                {
                foreach(var item in Articles)
                    {
                        System.Console.WriteLine($"Id: {item.Id} Name: {item.Name} Quantity: {item.Quantity}");
                    }
                }
                catch
                {
                    System.Console.WriteLine("Storage is empty!");
                }
                answer= Console.ReadLine();

                switch (answer)
                {
                    case "x" : System.Console.WriteLine("Thanks for using.");
                    break;
                    default: 
                    {
                        try
                        {
                            Convert.ToInt32(answer);
                        }
                        catch
                        {
                            System.Console.WriteLine("Wrong item Id!");
                            break;
                        }

                        if (Articles.Count-1 < Convert.ToInt32(answer))
                            {
                                System.Console.WriteLine("Wrong item Id!");
                                break;
                            }
                            
                        DrawDetails(Articles[Convert.ToInt32(answer)]);
                        System.Console.WriteLine("How much do you want to buy?");
                        var buyerQuantity = Console.ReadLine();

                        try
                        {
                            Convert.ToInt32(buyerQuantity);
                        }
                        catch
                        {
                            System.Console.WriteLine("Wrong number!");
                            break;
                        }
                        
                        if(Articles[Convert.ToInt32(answer)].Quantity < Convert.ToInt32(buyerQuantity))
                        {
                            System.Console.WriteLine("There's not enough stuff!");
                            break;
                        }
                        Articles[Convert.ToInt32(answer)].Quantity -= Convert.ToInt32(buyerQuantity);
                        int id = 0;
                        if(Articles is null)
                        {
                                 id=0;
                         }
                        else
                        {
                            id = Articles.Count;
                        }
                        Article article = new Article(id,Articles[Convert.ToInt32(answer)].Name,Convert.ToInt32(buyerQuantity),Articles[Convert.ToInt32(answer)].ExpirationDate,Articles[Convert.ToInt32(answer)].TotalPrice );
                        
                        customer.basket.ArticlesToBuy.Add(article);
                        customer.basket.RequiredMoney += article.TotalPrice * article.Quantity;
                    }
                    break;
                }

            } while (answer != "x");

            


        }
        private void DrawDetails(Article article)
        {

            Console.WriteLine($"Id: {article.Id} \nName: {article.Name}\nStorage Quantity: {article.Quantity}\nExpiration Date: {article.ExpirationDate}");
            

        }
        public void DrawArticles()
        {
            try
            {
                System.Console.Write("Storage has: ");
                foreach(var article in Articles)
            {
               Console.WriteLine($"\nName: {article.Name} Storage Quantity: {article.Quantity} Expiration Date: {article.ExpirationDate}\n");
            }
            }
            catch
            {
                Console.WriteLine("no items!");
            }
        }
        public void AddArticle(string name, int quantity, DateTime expirationdate, decimal price)
        {
             int id = 0;
            if(Articles is null)
            {
                id=0;
                Articles = new List<Article>();
            }
            else
            {
                id = Articles.Count;
            }
            Article article = new Article(id,name,quantity,expirationdate,price);
            Articles.Add(article);
        }
    }
}