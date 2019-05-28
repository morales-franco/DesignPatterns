using System;

namespace AbstractFactory.Simple.Foods
{
    class Asado : IBestFood
    {
        public void DoBestStuff()
        {
            Console.WriteLine("Best Argentinian Food - Asado");
        }
    }
}
