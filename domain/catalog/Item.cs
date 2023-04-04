using System;

namespace The.Big.Zuck.Domain.Catalog
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Brand { get; set; }
        public string Type { get; set; }
    }
}

public Item(string name, string description, string brand, decimal price)
{
    if(string.IsNullorEmpty(name))
    {
        throw new ArgumentException("Name cannot be null.");
    }

    if(string.IsNullorEmpty(description))
    {
        throw new ArgumentException("Description cannot be null.");
    }

    if(string.IsNullorEmpty(brand))
    {
        throw new ArgumentException("Brand cannot be null.");
    }

    if(price < 0.00m)
    {
        throw new ArgumentException("Price cannot be negative.");
    }

    this.Name = name;
    this.Description = description;
    this.Brand = brand;
    this.Price = price;
}