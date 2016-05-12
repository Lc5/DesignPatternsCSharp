namespace DesignPatterns.Structural.Facade
{
    public class Computer
    {
        private IBios bios;
        private IOs os;

        public Computer(IBios bios, IOs os)
        {
            this.bios = bios;
            this.os = os;
        }

        public void TurnOn()
        {
            this.bios.Execute();
            this.bios.WaitForKeyPress();
            this.bios.Launch(this.os);
        }

        public void TurnOff()
        {
            this.os.Halt();
            this.bios.PowerDown();
        }
    }
}
