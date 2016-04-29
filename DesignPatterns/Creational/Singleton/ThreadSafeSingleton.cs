namespace DesignPatterns.Creational.Singleton
{
    using System;

    public sealed class ThreadSafeSingleton
    {
        private static readonly Lazy<ThreadSafeSingleton> lazy =
            new Lazy<ThreadSafeSingleton>(() => new ThreadSafeSingleton());

        private ThreadSafeSingleton()
        {
        }

        public static ThreadSafeSingleton Instance
        {
            get
            {
                return lazy.Value;
            }
        }
    }
}
