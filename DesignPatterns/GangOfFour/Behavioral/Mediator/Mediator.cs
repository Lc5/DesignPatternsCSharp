namespace DesignPatterns.GangOfFour.Behavioral.Mediator
{
    using System.Collections.Generic;

    public class Mediator<T> : IMediator<T>
    {
        public List<IColleague<T>> ColleagueList { get; } = new List<IColleague<T>>();

        public void DistributeMessage(IColleague<T> sender, T message)
        {
            foreach (var colleague in this.ColleagueList)
            {
                if (colleague != sender)
                {
                    colleague.ReceiveMessage(message);
                }
            }
        }

        public void Register(IColleague<T> colleague)
        {
            this.ColleagueList.Add(colleague);
        }       
    }
}