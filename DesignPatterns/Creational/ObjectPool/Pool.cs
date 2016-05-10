namespace DesignPatterns.Creational.ObjectPool
{
    using System.Collections.Generic;

    public static class Pool<T> where T : PooledObject, new()
    {
        private static List<T> available = new List<T>();

        private static List<T> inUse = new List<T>();

        public static T GetObject()
        {
            lock(available)
            {
                if (available.Count > 0)
                {
                    T obj = available[0];
                    available.RemoveAt(0);
                    inUse.Add(obj);

                    return obj;
                }
                else
                {
                    T obj = new T();
                    inUse.Add(obj);

                    return obj;
                }
            }
        }

        public static void ReleaseObject(T obj)
        {
            lock (available)
            {
                obj.Cleanup();
                inUse.Remove(obj);
                available.Add(obj);
            }
        }
    }
}
