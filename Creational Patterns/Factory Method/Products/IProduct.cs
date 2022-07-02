namespace Products
{
    public interface IProduct
    {
        public string Name { get; set; }
        public int Price { get; set; }
        void DoStuff();
    }
}