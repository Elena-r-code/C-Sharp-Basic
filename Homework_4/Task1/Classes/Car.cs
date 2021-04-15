using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.Classes
{
    public class Car
    {
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }

        

        public Car(string model, int speed, Driver driver)
        {

            Model = model;
            Speed = speed;
            Driver = driver;
        }

        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }

        public int CalculateSpeed(Driver driver)
        {
            int speedResult = driver.Skill * Speed;
            return speedResult;
        }
    }
}
