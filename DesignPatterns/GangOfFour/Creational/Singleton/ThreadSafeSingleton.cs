namespace DesignPatterns.GangOfFour.Creational.Singleton
{
    using System;

    public sealed class ThreadSafeSingleton
    {
        private static readonly Lazy<ThreadSafeSingleton> Lazy =
            new Lazy<ThreadSafeSingleton>(() => new ThreadSafeSingleton());

        private ThreadSafeSingleton()
        {
        }

        public static ThreadSafeSingleton Instance
        {
            get
            {
                return Lazy.Value;
            }
        }
    }
}