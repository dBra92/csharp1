namespace Exercs;
class Program
{
    static void Main(string[] args)
    {
        DataPerson person1 = new DataPerson();
        DataPerson person2 = new DataPerson();

        Console.WriteLine("Enter with the name of first person:");
        person1.name = Console.ReadLine();
        person1.age = int.Parse(Console.ReadLine());


        Console.WriteLine("Enter with the name of second person:");
        person2.name = Console.ReadLine();
        person2.age = int.Parse(Console.ReadLine());

        if (person1.age > person2.age)
        {
            Console.WriteLine($"Pessoa mais velha:{person1.name}");
        }
        else
        {
            Console.WriteLine($"Pessoa mais velha:{person2.name}");
        }
    }
}
