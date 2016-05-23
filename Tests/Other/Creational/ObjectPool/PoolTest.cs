namespace DesignPatterns.Tests.Other.Creational.ObjectPool
{
    using DesignPatterns.Other.Creational.ObjectPool;

    using NUnit.Framework;

    [TestFixture]
    public class PoolTest
    {      
        [Test]
        public void TestPoolReturnsNewObjectWhenNotReleased()
        {
            var obj1 = Pool<ConcretePooledObject>.GetObject();
            var obj2 = Pool<ConcretePooledObject>.GetObject();

            Assert.That(obj1, Is.Not.EqualTo(obj2));
        }

        [Test]
        public void TestPoolReturnsSameObjectWhenReleased()
        {
            var obj1 = Pool<ConcretePooledObject>.GetObject();
            Pool<ConcretePooledObject>.ReleaseObject(obj1);
            var obj2 = Pool<ConcretePooledObject>.GetObject();

            Assert.That(obj1, Is.EqualTo(obj2));
        }

        private class ConcretePooledObject : PooledObject
        {
            public override void Cleanup()
            {
            }
        }
    }
}