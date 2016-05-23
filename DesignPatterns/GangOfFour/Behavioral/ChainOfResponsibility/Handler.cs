namespace DesignPatterns.GangOfFour.Behavioral.ChainOfResponsibility
{
    public abstract class Handler
    {
        public Handler Successor { get; set; }

        public abstract void HandleRequest(int request);
    }
}