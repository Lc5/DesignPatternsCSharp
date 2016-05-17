namespace DesignPatterns.Tests.Creational.AbstractFactory
{
    using System;

    using DesignPatterns.Creational.AbstractFactory;
    using DesignPatterns.Creational.AbstractFactory.OSX;

    using NUnit.Framework;

    [TestFixture]
    public class IGUIFactoryTest
    {
        [TestCase(typeof(GuiFactory))]
        [TestCase(typeof(DesignPatterns.Creational.AbstractFactory.Windows.GuiFactory))]
        public void TestGuiFactoryCreatesComponents(Type guiFactoryType)
        {
            var guiFactory = (IGuiFactory)Activator.CreateInstance(guiFactoryType);

            Assert.That(guiFactory.CreateButton(), Is.InstanceOf<IButton>());
            Assert.That(guiFactory.CreateContextMenu(), Is.InstanceOf<IContextMenu>());
            Assert.That(guiFactory.CreateWindow(), Is.InstanceOf<IWindow>());
        }
    }
}