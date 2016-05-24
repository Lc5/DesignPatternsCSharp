namespace DesignPatterns.GangOfFour.Creational.AbstractFactory.Tests
{
    using DesignPatterns.GangOfFour.Creational.AbstractFactory;

    using NUnit.Framework;

    using OsxGuiFactory = DesignPatterns.GangOfFour.Creational.AbstractFactory.OSX.GuiFactory;

    using WindowsGuiFactory = DesignPatterns.GangOfFour.Creational.AbstractFactory.Windows.GuiFactory;

    [TestFixture]
    public class AbstractFactoryTest
    {
        private static readonly object[] TestCases =
        {
            new[] { new OsxGuiFactory() },
            new[] { new WindowsGuiFactory() }
        };

        [TestCaseSource(nameof(TestCases))]
        public void TestAbstractFactory(IGuiFactory guiFactory)
        {
            Assert.That(guiFactory.CreateButton(), Is.InstanceOf<IButton>());
            Assert.That(guiFactory.CreateContextMenu(), Is.InstanceOf<IContextMenu>());
            Assert.That(guiFactory.CreateWindow(), Is.InstanceOf<IWindow>());
        }
    }
}