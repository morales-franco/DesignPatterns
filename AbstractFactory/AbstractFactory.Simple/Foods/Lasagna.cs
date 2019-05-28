using System;

namespace AbstractFactory.Simple.Foods
{
    class Lasagna : IBestFood
    {
        public void DoBestStuff()
        {
            Console.WriteLine("Best Italian Food - Lasagna");
        }
    }
}
