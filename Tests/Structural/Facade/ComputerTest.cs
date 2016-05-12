namespace DesignPatterns.Tests.Structural.Facade
{
    using DesignPatterns.Structural.Facade;

    using Moq;

    using NUnit.Framework;

    [TestFixture]
    public class ComputerTest
    {
        [Test]
        public void TestTurnOn()
        {
            var bios = new Mock<IBios>();
            var os = new Mock<IOs>();
            var computer = new Computer(bios.Object, os.Object);

            computer.TurnOn();

            bios.Verify(b => b.Execute());
            bios.Verify(b => b.WaitForKeyPress());
            bios.Verify(b => b.Launch(os.Object));
        }

        [Test]
        public void TestTurnOff()
        {
            var bios = new Mock<IBios>();
            var os = new Mock<IOs>();
            var computer = new Computer(bios.Object, os.Object);

            computer.TurnOn();

            os.Verify(o => o.Halt());
            bios.Verify(b => b.PowerDown());          
        }
    }
}
