using Products.Abstract_Types;
using Products.Implementations;
using Products.Enum;

namespace Abstract_Factory.Factories
{
    public class ModernFactory : AbstractFactory
    {
        public IChair CreateChair()
        {
            return new ModernChair { Name = "Modern Chair", Price = 30.00M, Type = DesignTypes.Modern };
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa { Name = "Modern Sofa", Price = 30.00M, Type = DesignTypes.Modern };
        }

        public ITable CreateTable()
        {
            return new ModernTable { Name = "Modern Table", Price = 30.00M, Type = DesignTypes.Modern };
        }
    }
}
