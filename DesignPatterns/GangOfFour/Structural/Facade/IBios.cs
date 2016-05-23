namespace DesignPatterns.GangOfFour.Structural.Facade
{
    public interface IBios
    {
        void Execute();

        void Launch(IOs os);

        void PowerDown();

        void WaitForKeyPress();
    }
}