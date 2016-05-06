namespace DesignPatterns.Tests.Creational.AbstractFactory
{
    using System;

    using DesignPatterns.Creational.AbstractFactory;

    using NUnit.Framework;
    
    using OSXGUIFactory = DesignPatterns.Creational.AbstractFactory.OSX.GUIFactory;

    using WindowsGUIFactory = DesignPatterns.Creational.AbstractFactory.Windows.GUIFactory;

    [TestFixture]
    class IGUIFactoryTest
    {
        [TestCase(typeof(OSXGUIFactory))]
        [TestCase(typeof(WindowsGUIFactory))]
        public void TestGUIFactoryCreatesComponents(Type GUIFactoryType)
        {
            var GUIFactory = (IGUIFactory)Activator.CreateInstance(GUIFactoryType);

            Assert.That(GUIFactory.CreateButton(), Is.InstanceOf<IButton>());
            Assert.That(GUIFactory.CreateContextMenu(), Is.InstanceOf<IContextMenu>());
            Assert.That(GUIFactory.CreateWindow(), Is.InstanceOf<IWindow>());
        }
    }
}
