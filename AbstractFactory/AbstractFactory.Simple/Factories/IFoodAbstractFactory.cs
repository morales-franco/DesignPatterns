using AbstractFactory.Simple.Foods;

namespace AbstractFactory.Simple.Factories
{
    interface IFoodAbstractFactory
    {
        IBestFood CreateBestFood();
        ISimpleFood CreateSimpleFood();
    }
}
