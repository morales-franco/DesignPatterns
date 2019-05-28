using AbstractFactory.Simple.Factories;
using System;

namespace AbstractFactory.Simple
{
    class Program
    {
        private static IFoodAbstractFactory factory;

        static void Main(string[] args)
        {
            Console.WriteLine("Dev Restaurant");

            factory = new ArgentinianFoodFactory();

            var bestArgentinian = factory.CreateBestFood();
            var simpleArgentinian = factory.CreateSimpleFood();

            bestArgentinian.DoBestStuff();
            simpleArgentinian.DoSimpleStuff();

            factory = new ItalianFoodFactory();
            var bestItalian = factory.CreateBestFood();
            var simpleItalian = factory.CreateSimpleFood();

            bestItalian.DoBestStuff();
            simpleItalian.DoSimpleStuff();
        }
    }
}
