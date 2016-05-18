namespace DesignPatterns.Behavioral.Mediator
{
    using System;

    public class Colleague<T> : IColleague<T>
    {
        private string name;

        public Colleague(string name)
        {
            this.name = name;
        }

        public void ReceiveMessage(T message)
        {
            Console.WriteLine(this.name + " received " + message.ToString());
        }

        public void SendMessage(IMediator<T> mediator, T message)
        {
            mediator.DistributeMessage(this, message);
        }        
    }
}