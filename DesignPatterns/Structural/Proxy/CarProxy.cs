namespace DesignPatterns.Structural.Proxy
{
    using System;

    public class CarProxy : ICar
    {
        private readonly ICar car;

        private readonly Driver driver;

        public CarProxy(Driver driver)
        {
            this.driver = driver;
            this.car = new Car();
        }

        public void Drive()
        {
            if (this.driver.Age < 18)
            {
                throw new ArgumentException("The driver is too young to drive.");
            }

            this.car.Drive();
        }
    }
}