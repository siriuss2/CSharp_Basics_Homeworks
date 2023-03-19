using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Homework_Task_01.Models
{
    public class Human
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }


        public string GetPersonInfo()
        {
            return $"Name: {FirstName} | Lastname: {LastName} | Age: {Age}";
        }

    }
}
