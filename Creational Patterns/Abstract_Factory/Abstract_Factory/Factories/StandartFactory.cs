using Products.Abstract_Types;
using Products.Implementations;
using Products.Enum;

namespace Abstract_Factory.Factories
{
    public class StandartFactory : AbstractFactory
    {
        public IChair CreateChair()
        {
            return new StandartChair { Name = "Standart Chair", Price = 30.00M, Type = DesignTypes.Standart };
        }

        public ISofa CreateSofa()
        {
            return new StandartSofa { Name = "Standart Sofa", Price = 30.00M, Type = DesignTypes.Standart };
        }

        public ITable CreateTable()
        {
            return new StandartTable { Name = "Standart Table", Price = 30.00M, Type = DesignTypes.Standart };
        }
    }
}
