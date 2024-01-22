using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    //create a singleton class, at most one instance of this class can be created, at the start of application
    internal class SingletonEager
    {
        private static SingletonEager Instance { get; set; } = new SingletonEager();

        public static SingletonEager GetInstance()
        {
            return Instance;
        }
    }

    // Lazy initialization, when actually needed but not thread safe
    internal class SingletonLazy
    {
        private static SingletonLazy Instance { get; set; }

        public static SingletonLazy GetInstance()
        {
            if (Instance == null)
            {
                Instance = new SingletonLazy();
            }

            return Instance;
        }
    }

    //Synchronized, thread safe but expensive

    internal class SingletonSynchronized
    {
        private static SingletonSynchronized Instance { get; set; }

        private static object lockObject = new object();
        public static SingletonSynchronized GetInstance()
        {
            lock (lockObject)
            {
                if (Instance == null)
                {
                    Instance = new SingletonSynchronized();
                }
            }
            return Instance;
        }
    }

    //Double checked locking, thread safe and lazy initialization

    internal class SingletonDoubleCheckedLocking
    {
        private static SingletonDoubleCheckedLocking Instance { get; set; }

        private static object lockObject = new object();
        public static SingletonDoubleCheckedLocking GetInstance()
        {
            if (Instance == null)
            {
                lock(lockObject)
                {
                    if (Instance == null)
                    {
                        Instance = new SingletonDoubleCheckedLocking();
                    }
                }
            }

            return Instance;
        }
    }
}
