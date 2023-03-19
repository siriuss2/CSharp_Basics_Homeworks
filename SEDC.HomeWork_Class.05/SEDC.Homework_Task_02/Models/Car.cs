using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SEDC.Homework_Task_02.Models
{
    public class Car
    {
        // CONSTRUCTOR
        public Car(string model , int speed)
        {
            Model = model;
            Speed = speed;
        }
        // PROPERTIES
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        // METHOD CALCULATESPEED()
        public int CalculateSpeed(Driver driver)
        {
            return driver.Skill * Speed;
        }

    }
}
