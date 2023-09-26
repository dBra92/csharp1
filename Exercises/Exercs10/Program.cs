using Exercs10.Entities;
using System.Globalization;

namespace Exercs10;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter client data:");

        Console.Write("Name:");
        string name = Console.ReadLine();

        Console.Write("Email:");
        string email = Console.ReadLine();

        Console.Write("Birth date[dd/MM/yyyy]:");
        DateTime birthDate = DateTime.Parse(Console.ReadLine());

        Console.Write("Status:");
        OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());

        Client client = new Client(name, email, birthDate);
        Order order = new Order(DateTime.Now, status, client);

        Console.Write("How many items to this order:");
        int items = int.Parse(Console.ReadLine());

        for (int i = 1; i <= items; i++)
        {
            Console.WriteLine($"Enter #{i} item data:");

            Console.Write("Product name:");
            string productName = Console.ReadLine();

            Console.Write("Product price $");
            double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Product pd = new Product(productName, productPrice);

            Console.Write("Quantity:");
            int qtt = int.Parse(Console.ReadLine());

            OrderItem orderItem = new OrderItem(qtt, productPrice, pd);
            order.AddItem(orderItem);
        }

        System.Console.WriteLine();
        Console.WriteLine("ORDER SUMMARY:");
        System.Console.WriteLine(order);

    }
    }
    /*
    Ler os dados de um pedido com N itens (N fornecido pelo usuário). Depois, mostrar um
    sumário do pedido conforme exemplo (próxima página). Nota: o instante do pedido deve ser
    o instante do sistema: DateTime.Now
    */