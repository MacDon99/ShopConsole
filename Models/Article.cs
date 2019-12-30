using System;

namespace ShopConsole.Models
{
    public class Article
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Quantity { get; private set; }
        public DateTime ExpirationDate { get; private set; }

        public Article(int id, string name, int quantity, DateTime expirationdate)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            ExpirationDate = expirationdate;
        }
    }
}