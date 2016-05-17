namespace DesignPatterns.Tests.Creational.AbstractFactory.OSX
{
    using DesignPatterns.Creational.AbstractFactory.OSX;

    using NUnit.Framework;

    [TestFixture]
    public class GuiFactoryTest
    {
        [Test]
        public void TestGuiFactoryCreatesComponents()
        {
            var guiFactory = new GuiFactory();

            Assert.That(guiFactory.CreateButton(), Is.InstanceOf<Button>());
            Assert.That(guiFactory.CreateContextMenu(), Is.InstanceOf<ContextMenu>());
            Assert.That(guiFactory.CreateWindow(), Is.InstanceOf<Window>());
        }
    }
}