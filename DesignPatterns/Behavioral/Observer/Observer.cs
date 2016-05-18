namespace DesignPatterns.Behavioral.Observer
{
    using System;

    public class Observer : IObserver
    {
        public string Name { get; private set; }

        public Observer(string name)
        {
            this.Name = name;
        }

        public void Update()
        {
            Console.WriteLine("Observer {0} receieved an update.", this.Name);
        }
    }
}