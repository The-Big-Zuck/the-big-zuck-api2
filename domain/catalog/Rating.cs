namespace The.Big.Zuck.Domain.Catalog
{
    public class Rating
    {
        public int Stars { get; set; }
        public string UserName { get; set; }
        public string Review { get; set; }
    }
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
public string Brand { get; set; }
public decimal Price { get; set; }
public list<Rating> Ratings { get; set; } = new list<Rating>();

public void AddRating(Rating rating)
{
   this.Ratings.Add(rating);
}