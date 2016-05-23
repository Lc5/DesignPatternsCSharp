namespace DesignPatterns.GangOfFour.Structural.Facade
{
    public class Computer
    {
        private readonly IBios bios;

        private readonly IOs os;

        public Computer(IBios bios, IOs os)
        {
            this.bios = bios;
            this.os = os;
        }

        public void TurnOff()
        {
            this.os.Halt();
            this.bios.PowerDown();
        }

        public void TurnOn()
        {
            this.bios.Execute();
            this.bios.WaitForKeyPress();
            this.bios.Launch(this.os);
        }
    }
}