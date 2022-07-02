using Creator;

ICreator delivery;

Console.WriteLine("Which creator Do you prefer? \n1.ProductA creator\n2.ProductB creator");
int answer = Convert.ToInt32(Console.ReadLine());
if (answer == 1)
    delivery = new ConcreteCreatorA();
else
    delivery = new ConcreteCreatorB();

var product = delivery.CreateProduct();

Console.WriteLine(product.Name + " : " + product.Price);


