using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Singleton_v3
{
    /*
     * It's simple and performs well.
     * By default, Lazy objects are thread-safe.
     */
    public sealed class SingletonLazy
    {
        private static readonly Lazy<SingletonLazy> _instance =
            new Lazy<SingletonLazy>(() => new SingletonLazy());

        private SingletonLazy()
        {

        }

        public static SingletonLazy Instance
        {
            get
            {
                return _instance.Value;
            }
        }

        public string SayHello()
        {
            return $"Singleton Lazy Implementation - {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")} - Hello!";
        }

    }
}
