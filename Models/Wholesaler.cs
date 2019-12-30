using System;
using System.Collections.Generic;
using ShopConsole.Models;

namespace ShopConsole
{
    public class Wholesaler
    {
        public List<Article> Articles{ get; private set;}
        Article CreateArticle(string name, int quantity, DateTime expirationdate)
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
            var article = new Article(id,name,quantity,expirationdate);
            return article;
        }
        public void AddArticle(string name, int quantity, DateTime expirationdate)
        {
            var article = CreateArticle(name,quantity,expirationdate);
            if(Articles is null)
            {
                Articles = new List<Article>();
            }
            Articles.Add(article);
        }
    }
}