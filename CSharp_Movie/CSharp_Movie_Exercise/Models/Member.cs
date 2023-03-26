using CSharp_Movie_Exercise.Enums;

namespace CSharp_Movie_Exercise.Models
{
    public class Member
    {
        public Member()
        {
            
        }

        public Member(string firstName, string lastName, int age , string userName , string password , string phoneNumber , DateTime dateOfRegistration , Role role)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            UserName = userName;
            Password = password;
            PhoneNumber = phoneNumber;
            DateOfRegistration = dateOfRegistration;
            Role = role;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfRegistration { get; set; }
        public Role Role { get; set; }

        public string DisplayInfo(string firstName , string lastName , DateTime dateOfRegistration)
        {
            return $"{firstName} {lastName} | Registered on {dateOfRegistration}";
        }
    }
}
