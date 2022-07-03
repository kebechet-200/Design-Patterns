using Products.Abstract_Types;

namespace Abstract_Factory
{
    public interface AbstractFactory
    {
        public IChair CreateChair();
        public ISofa CreateSofa();
        public ITable CreateTable();
    }
}
