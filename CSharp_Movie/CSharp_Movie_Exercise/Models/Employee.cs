namespace CSharp_Movie_Exercise.Models
{
    public class Employee : Member
    {
        private int Salary = 300;
        public int HoursPerMonth { get; set; }
        public Nullable<int> Bonus { get; set; }

        public void SetBonus(Nullable<int> bonus , int hoursPerMonth)
        {
            if(hoursPerMonth > 160)
            {
                bonus = 30;
                
            }
            else if(hoursPerMonth < 160)
            {
                bonus = null;
            }
        }

        public void SetSalary(int salary)
        {
            salary = HoursPerMonth * Bonus.GetValueOrDefault();
        }
    }
}
