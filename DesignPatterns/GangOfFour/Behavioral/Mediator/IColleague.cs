namespace DesignPatterns.GangOfFour.Behavioral.Mediator
{
    public interface IColleague<T>
    {
        void ReceiveMessage(T message);

        void SendMessage(IMediator<T> mediator, T message);
    }
}