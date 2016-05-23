namespace DesignPatterns.Other.Creational.ObjectPool
{
    using System.Collections.Generic;

    public static class Pool<T>
        where T : PooledObject, new()
    {
        private static readonly List<T> Available = new List<T>();

        private static readonly List<T> InUse = new List<T>();

        public static T GetObject()
        {
            lock (Available)
            {
                if (Available.Count > 0)
                {
                    var obj = Available[0];
                    Available.RemoveAt(0);
                    InUse.Add(obj);

                    return obj;
                }
                else
                {
                    var obj = new T();
                    InUse.Add(obj);

                    return obj;
                }
            }
        }

        public static void ReleaseObject(T obj)
        {
            lock (Available)
            {
                obj.Cleanup();
                InUse.Remove(obj);
                Available.Add(obj);
            }
        }
    }
}