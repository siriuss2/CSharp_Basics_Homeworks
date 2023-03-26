using CSharp_Movie_Exercise.Enums;

namespace CSharp_Movie_Exercise.Models
{
    public class Movie
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public Genre Genre { get; set; }
        private int Price { get; set; }

        public void SetPrice(int year)
        {
            if (year < 2000)
            {
                Random random = new Random();
                Price = random.Next(100, 201);
            }
            else if (year >= 2000 && year <= 2010)
            {
                Random random = new Random();
                Price = random.Next(200, 301);
            }
            else if (year > 2010)
            {
                Random random = new Random();
                Price = random.Next(300, 501);
            }
        }
    }
}
