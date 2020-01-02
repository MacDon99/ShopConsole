using System;

namespace ShopConsole.Models
{
    public class Article
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        private decimal Price { get; set; }
        public decimal Tax { get; } = 0.23M;
        public decimal TotalPrice { get{return (1+Tax)*Price;}}
        public int Quantity { get; set; }
        public DateTime ExpirationDate { get; private set; }

        public Article(int id, string name, int quantity, DateTime expirationdate, decimal price)
        {
            Id = id;
            Name = name;
            Quantity = quantity;
            ExpirationDate = expirationdate;
            Price = price;
        }
    }
}