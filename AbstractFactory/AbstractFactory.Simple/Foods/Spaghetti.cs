using System;

namespace AbstractFactory.Simple.Foods
{
    class Spaghetti : ISimpleFood
    {
        public void DoSimpleStuff()
        {
            Console.WriteLine("Simple Italian Food - Spaghetti");
        }
    }
}
