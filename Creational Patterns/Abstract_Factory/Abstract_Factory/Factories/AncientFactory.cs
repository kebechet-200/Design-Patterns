using Products.Abstract_Types;
using Products.Implementations;
using Products.Enum;

namespace Abstract_Factory.Factories
{
    public class AncientFactory : AbstractFactory
    {
        public IChair CreateChair()
        {
            return new AncientChair { Name = "Ancient Chair", Price = 20.00M, Type = DesignTypes.Ancient };
        }

        public ISofa CreateSofa()
        {
            return new AncientSofa { Name = "Ancient Sofa", Price = 20.00M, Type = DesignTypes.Ancient };
        }

        public ITable CreateTable()
        {
            return new AncientTable { Name = "Ancient Table", Price = 20.00M, Type = DesignTypes.Ancient };
        }
    }
}
