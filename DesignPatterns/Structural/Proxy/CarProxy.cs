namespace DesignPatterns.Structural.Proxy
{
    using System;

    public class CarProxy : ICar
    {
        private Driver driver;
        private ICar car;

        public CarProxy(Driver driver)
        {
            this.driver = driver;
            this.car = new Car();
        }

        public void Drive()
        {
            if (driver.Age < 18)
            {
                throw new ArgumentException("The driver is too young to drive."); 
            }

            car.Drive();
        }
    }
}
