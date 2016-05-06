namespace DesignPatterns.Tests.Creational.AbstractFactory.Windows
{
    using NUnit.Framework;

    using Windows = DesignPatterns.Creational.AbstractFactory.Windows;

    [TestFixture]
    class GUIFactoryTest
    {
        [Test]
        public void TestGUIFactoryCreatesComponents()
        {
            var GUIFactory = new Windows.GUIFactory();

            Assert.That(GUIFactory.CreateButton(), Is.InstanceOf<Windows.Button>());
            Assert.That(GUIFactory.CreateContextMenu(), Is.InstanceOf<Windows.ContextMenu>());
            Assert.That(GUIFactory.CreateWindow(), Is.InstanceOf<Windows.Window>());
        }
    }
}
