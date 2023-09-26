
using POOPT3.Entities.Enums;
using POOPT3.Entities;
namespace POOPT3;
class Program
{
    static void Main(string[] args)
    {
        Order order = new Order
        {
            Id = 1000,
            Moment = DateTime.Now,
            Status = OrderStatus.Delivered
        };

        System.Console.WriteLine(order);
        string convert = OrderStatus.PendingPayment.ToString();
        System.Console.WriteLine(convert);

        OrderStatus os = Enum.Parse<OrderStatus>("Processing");
        System.Console.WriteLine(os);
    }
}
