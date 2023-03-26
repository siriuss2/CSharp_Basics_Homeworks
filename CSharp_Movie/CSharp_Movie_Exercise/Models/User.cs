using CSharp_Movie_Exercise.Enums;

namespace CSharp_Movie_Exercise.Models
{
    public class User : Member
    {
        public User(List<string> movies)
        {
            movies = new List<string>();
        }
        public int Id { get; set; }
        public TypeOfSubscription typeOfSubscription { get; set; }
        public List<string> Movies { get; set; }
    }
}
