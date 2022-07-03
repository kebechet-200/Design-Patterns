using Products.Enum;

namespace Products.Abstract_Types
{
    public interface ISofa
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DesignTypes Type { get; set; }
    }
}
