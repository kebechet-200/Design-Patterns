using Abstract_Factory.Factories;
using Abstract_Factory;


// introductory part

Console.Write("What's your name? : ");
string? name = Console.ReadLine();

Console.WriteLine($"Hello and welcome to our factory Mr.{name}\n" +
    $"What type of furniture are you looking for?\n1. Ancient Furniture\n" +
    $"2. Standart Furniture\n3. Modern Furniture");

// declaring variables
int typeOfFurniture = 1;

int.TryParse(Console.ReadLine(), out typeOfFurniture);

AbstractFactory? factory = typeOfFurniture switch
{
    1 => new AncientFactory(),
    2 => new StandartFactory(),
    3 => new ModernFactory(),
    _ => throw new Exception("No such type of factory")
};


//fact that it creates only one type of chair,sofa,table

var chair = factory.CreateChair();
var sofa = factory.CreateSofa();
var table = factory.CreateTable();

// moment of truth

Console.WriteLine($"You choose \n{chair.Name} -> Price : {chair.Price} -> Type: {chair.Type.ToString()}\n" +
                                $"{sofa.Name} -> Price : {sofa.Price} -> Type: {sofa.Type.ToString()}\n" +
                                $"{table.Name} -> Price : {table.Price} -> Type: {table.Type.ToString()}\n"
                 );

