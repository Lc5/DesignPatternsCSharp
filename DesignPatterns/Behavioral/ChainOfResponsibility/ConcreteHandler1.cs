namespace DesignPatterns.Behavioral.ChainOfResponsibility
{
    using System;

    public class ConcreteHandler1 : Handler
    {
        public override void HandleRequest(int request)
        {
            if (request >= 0 && request < 10)
            {
                Console.WriteLine("{0} handled request: {1}", this.GetType().Name, request);
            }
            else if (this.Successor != null)
            {
                this.Successor.HandleRequest(request);
            }
        }
    }
}
