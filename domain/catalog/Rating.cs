namespace The.Big.Zuck.Domain.Catalog
{
    public class Rating
    {
        public int Stars { get; set; }
        public string UserName { get; set; }
        public string Review { get; set; }
    }


public string Brand { get; set; }
public decimal Price { get; set; }
public list<Rating> Ratings { get; set; } = new list<Rating>();

public void AddRating(Rating rating)
{
   this.Ratings.Add(rating);
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

public Rating(int stars, string userName, string review)
{
   if(stars < 1 || stars > 5)
   {
      throw new ArgumentException("Stars must be an integer of 1, 2, 3, 4, or 5.");
   }

   if(string.IsNullorEmpty(userName))
   {
      throw new ArgumentException("UserName cannot be null.");
   }

   this.Stars = stars;
   this.UserName = userName;
   this.Review = review;
}
}
