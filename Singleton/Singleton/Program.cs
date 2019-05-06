using Singleton.Classic_Singleton;
using Singleton.Singleton_v3;
using Singleton.Singleton_with_locks;
using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ClassicSingleton.Instance.SayHello());
            Console.WriteLine(SingletonWithLocks.Instance.SayHello());
            Console.WriteLine(SingletonLazy.Instance.SayHello());
        }
    }
}
