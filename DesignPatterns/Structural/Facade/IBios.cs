namespace DesignPatterns.Structural.Facade
{
    public interface IBios
    {
        void Execute();
        void WaitForKeyPress();
        void Launch(IOs os);
        void PowerDown();
    }
}
