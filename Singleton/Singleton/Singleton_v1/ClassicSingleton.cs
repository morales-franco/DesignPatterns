using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Classic_Singleton
{
    /*
     * A Non-Thread-Safe Singleton implementation
     */
    public class ClassicSingleton
    {
        private static ClassicSingleton _instance;

        private ClassicSingleton()
        {
        }

        public static ClassicSingleton Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new ClassicSingleton();
                }

                return _instance;
            }
        }

        public string SayHello()
        {
            return $"Singleton Classic Implementation - {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")} - Hello!";
        }

        public string ShowMe()
        {
            return $"Singleton Classic Implementation - {DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss")} - Hello!";
        }
    }
}
