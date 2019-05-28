using AbstractFactory.Simple.Foods;
using System;

namespace AbstractFactory.Simple.Factories
{
    class ItalianFoodFactory : IFoodAbstractFactory
    {
        public ItalianFoodFactory()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public IBestFood CreateBestFood()
        {
            return new Lasagna();
        }

        public ISimpleFood CreateSimpleFood()
        {
            return new Spaghetti();
        }
    }
}
