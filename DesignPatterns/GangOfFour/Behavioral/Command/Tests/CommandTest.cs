namespace DesignPatterns.GangOfFour.Behavioral.Command.Tests
{
    using DesignPatterns.GangOfFour.Behavioral.Command;

    using NUnit.Framework;

    [TestFixture]
    public class CommandTest
    {
        [Test]
        public void TestCommand()
        {
            var lamp = new Light();
            var closeCommand = new CloseSwitchCommand(lamp);
            var openCommand = new OpenSwitchCommand(lamp);
            var @switch = new Switch(closeCommand, openCommand);

            @switch.Open();

            // OUTPUT: The light is on.

            @switch.Close(); 
            
            // OUTPUT: The light is off.
        }
    }
}