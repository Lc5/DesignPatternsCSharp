namespace DesignPatterns.Tests.Creational.AbstractFactory
{
    using System;

    using DesignPatterns.Creational.AbstractFactory;

    using NUnit.Framework;

    using OsxGuiFactory = DesignPatterns.Creational.AbstractFactory.OSX.GuiFactory;

    using WindowsGuiFactory = DesignPatterns.Creational.AbstractFactory.Windows.GuiFactory;

    [TestFixture]
    public class IGuiFactoryTest
    {
        [TestCase(typeof(OsxGuiFactory))]
        [TestCase(typeof(WindowsGuiFactory))]
        public void TestGuiFactoryCreatesComponents(Type guiFactoryType)
        {
            var guiFactory = (IGuiFactory)Activator.CreateInstance(guiFactoryType);

            Assert.That(guiFactory.CreateButton(), Is.InstanceOf<IButton>());
            Assert.That(guiFactory.CreateContextMenu(), Is.InstanceOf<IContextMenu>());
            Assert.That(guiFactory.CreateWindow(), Is.InstanceOf<IWindow>());
        }
    }
}