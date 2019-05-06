using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Singleton_with_locks
{
    /*
     * Thread safe using double-check locking
     * Easy to get wrong
     * Not perform as well as Lazy Implementation
     */
    public sealed class SingletonWithLocks
    {
        private static SingletonWithLocks _instance = null;
        private static readonly object _lockObject = new object();

        private SingletonWithLocks()
        {

        }

        public static SingletonWithLocks Instance
        {
            get
            {
                if(_instance == null)
                {
                    lock (_lockObject)
                    {
                        //Double check!
                        if(_instance == null)
                        {
                            _instance = new SingletonWithLocks();
                        }
                    }
                }
                return _instance;
            }
        }

        public string SayHello()
        {
            return $"Singleton double-check locking Implementation - {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")} - Hello!";
        }

    }
}
