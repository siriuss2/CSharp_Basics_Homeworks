namespace SEDC.HomeWork_Class._06_Task02.Models
{
    public class Card
    {
        public Card(string name , string lastName , int pin, string cardNumber)
        {
            Name = name;
            LastName = lastName;
            Pin = pin;
            CardNumber = cardNumber;
        }
        public Card(string name , string lastName, string cardNumber)
        {
            Name = name;
            LastName = lastName;
            CardNumber = cardNumber;
        }
        public Card(string name , string lastName)
        {
            Name = name;
            LastName = lastName;
        }
        public string Name { get; set; }
        public string LastName { get; set; }       
        public string CardNumber { get; set; }
        public int Pin { get; set; }


    }
}
