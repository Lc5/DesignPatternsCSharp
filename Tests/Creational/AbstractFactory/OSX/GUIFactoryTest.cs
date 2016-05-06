namespace DesignPatterns.Tests.Creational.AbstractFactory.OSX
{
    using NUnit.Framework;

    using OSX = DesignPatterns.Creational.AbstractFactory.OSX;

    [TestFixture]
    class GUIFactoryTest
    {
        [Test]
        public void TestGUIFactoryCreatesComponents()
        {
            var GUIFactory = new OSX.GUIFactory();

            Assert.That(GUIFactory.CreateButton(), Is.InstanceOf<OSX.Button>());
            Assert.That(GUIFactory.CreateContextMenu(), Is.InstanceOf<OSX.ContextMenu>());
            Assert.That(GUIFactory.CreateWindow(), Is.InstanceOf<OSX.Window>());
        }
    }
}
