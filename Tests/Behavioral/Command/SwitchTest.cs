namespace DesignPatterns.Tests.Behavioral.Command
{
    using DesignPatterns.Behavioral.Command;

    using NUnit.Framework;

    [TestFixture]
    class SwitchTest
    {
        [Test]
        public void TestSwitch()
        {
            var lamp = new Light();
            var closeCommand = new CloseSwitchCommand(lamp);
            var openCommand = new OpenSwitchCommand(lamp);
            var @switch = new Switch(closeCommand, openCommand);

            @switch.Open();

            @switch.Close();
        }
    }
}
