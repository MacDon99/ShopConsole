using System;
using System.Collections.Generic;
using ShopConsole.Models;

namespace ShopConsole
{
    public class Wholesaler
    {
        public List<Article> Articles{ get; private set;}

        public Wholesaler()
        {
                        if(Articles is null)
            {
                Articles = new List<Article>()
                {
                    new Article(0,"Pomidor",29,DateTime.Now, 3.0M),
                    new Article(1,"Cebula",40,DateTime.Now, 3.5M),
                    new Article(2,"Kasza",13,DateTime.Now, 2.5M),
                    new Article(3,"Ryż",20,DateTime.Now, 3.6M),
                };
            }
        }
        Article CreateArticle(string name, int quantity, DateTime expirationdate, decimal price)
        {
            int id = 0;
            if(Articles is null)
            {
                id=0;
            }
            else
            {
                id = Articles.Count;
            }
            var article = new Article(id,name,quantity,expirationdate, price);
            return article;
        }
        public void AddArticle(string name, int quantity, DateTime expirationdate, decimal price)
        {
            var article = CreateArticle(name,quantity,expirationdate, price);
            if(Articles is null)
            {
                Articles = new List<Article>();
            }
            Articles.Add(article);
        }
    }
}