namespace DesignPatterns.Tests.GangOfFour.Structural.Facade
{
    using DesignPatterns.GangOfFour.Structural.Facade;

    using Moq;

    using NUnit.Framework;

    [TestFixture]
    public class FacadeTest
    {
        [Test]
        public void TestTurnOff()
        {
            var bios = new Mock<IBios>();
            var os = new Mock<IOs>();
            var computer = new Computer(bios.Object, os.Object);

            computer.TurnOff();

            os.Verify(o => o.Halt());
            bios.Verify(b => b.PowerDown());
        }

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
    }
}