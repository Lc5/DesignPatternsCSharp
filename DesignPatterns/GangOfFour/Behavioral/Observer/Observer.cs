namespace DesignPatterns.GangOfFour.Behavioral.Observer
{
    using System;

    public class Observer : IObserver
    {
        public Observer(string name)
        {
            this.Name = name;
        }

        public string Name { get; }

        public void Update()
        {
            Console.WriteLine("Observer {0} receieved an update.", this.Name);
        }
    }
}