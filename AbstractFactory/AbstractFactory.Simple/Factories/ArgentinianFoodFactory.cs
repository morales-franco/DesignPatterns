using AbstractFactory.Simple.Foods;
using System;

namespace AbstractFactory.Simple.Factories
{
    class ArgentinianFoodFactory : IFoodAbstractFactory
    {
        public ArgentinianFoodFactory()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
        }
        public IBestFood CreateBestFood()
        {
            return new Asado();
        }

        public ISimpleFood CreateSimpleFood()
        {
            return new Milanesa();
        }
    }
}
