using SEDC.Homework_Task_02.Models;

void RaceCars(Car car1, Car car2)
{
    double car1Speed = car1.CalculateSpeed(car1.Driver);
    double car2Speed = car2.CalculateSpeed(car2.Driver);

    if (car1Speed > car2Speed)
    {
        Console.WriteLine($"{car1.Driver.Name} {car1.Model} wins the race with {car1.Speed} km/h!");
    }
    else if (car1Speed < car2Speed)
    {
        Console.WriteLine($"{car2.Driver.Name} {car2.Model} wins the race {car2.Speed} km/h!!");
    }
    else
    {
        Console.WriteLine("It's a tie!");
    }

}


Driver driver1 = new Driver("Antonio", 5);
Driver driver2 = new Driver("Kostadin", 3);
Driver driver3 = new Driver("Tosho", 4);
Driver driver4 = new Driver("Marija", 5);

Car car1 = new Car("Audi", 200);
Car car2 = new Car("McLaren", 280);
Car car3 = new Car("Mercedes", 250);
Car car4 = new Car("Bugatti", 270);

Driver[] drivers = new Driver[] { driver1, driver2, driver3, driver4 };
Car[] cars = new Car[] { car1, car2, car3 , car4};


Console.WriteLine($"Choose a car no.1 ({car1.Model}, {car2.Model}, {car3.Model}, {car4.Model})");
int userInputForFirstCar = int.Parse(Console.ReadLine());

Console.WriteLine($"Choose driver for car no.1 ({driver1.Name}, {driver2.Name}, {driver3.Name}, {driver4.Name})");
int userInputForFirstDriver = int.Parse(Console.ReadLine());

Console.WriteLine($"Choose a car no.2 ({car1.Model}, {car2.Model}, {car3.Model}, {car4.Model})");
int userInputForSecondCar = int.Parse(Console.ReadLine());

Console.WriteLine($"Choose driver for car no.2 ({driver1.Name}, {driver2.Name}, {driver3.Name}, {driver4.Name})");
int userInputForSecondDriver = int.Parse(Console.ReadLine());

Car firstSelectedCar = cars[userInputForFirstCar - 1];
Car secondSelectedCar = cars[userInputForSecondCar - 1];

Driver firstSelectedDriver = drivers[userInputForFirstDriver - 1];
Driver secondSelectedDriver = drivers[userInputForSecondDriver - 1];

firstSelectedCar.Driver = firstSelectedDriver;
secondSelectedCar.Driver = secondSelectedDriver;

RaceCars(firstSelectedCar, secondSelectedCar);