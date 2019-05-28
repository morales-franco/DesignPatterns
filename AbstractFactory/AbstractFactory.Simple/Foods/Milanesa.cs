using System;

namespace AbstractFactory.Simple.Foods
{
    class Milanesa : ISimpleFood
    {
        public void DoSimpleStuff()
        {
            Console.WriteLine("Simple Argentinian Food - Milanesa");
        }
    }
}
