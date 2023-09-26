
using Excecoes.Entities;
using Excecoes.Entities.Exceptions;

namespace Excecoes;
class Program
{
    static void Main(string[] args)
    {
        try
        {
            System.Console.Write("Room number:");
            int roomNumber = int.Parse(Console.ReadLine());

            System.Console.Write("Check-in date(dd/MM/yyyy):");
            DateTime checkin = DateTime.Parse(Console.ReadLine());

            System.Console.Write("Check-out date(dd/MM/yyyy):");
            DateTime checkout = DateTime.Parse(Console.ReadLine());

            Reservation rs = new Reservation(roomNumber, checkout, checkin);
            System.Console.WriteLine($"Reservation:{rs}");

            System.Console.WriteLine();
            System.Console.WriteLine("Enter data to update the reservation:");
            System.Console.Write("Check-in date(dd/MM/yyyy):");
            checkin = DateTime.Parse(Console.ReadLine());

            System.Console.Write("Check-out date(dd/MM/yyyy):");
            checkout = DateTime.Parse(Console.ReadLine());

            DateTime now = DateTime.Now;

            rs.UpdateDates(checkin, checkout);

            System.Console.WriteLine($"Reservation:{rs}");
            System.Console.WriteLine();
        }
        catch (DomainException de)
        {
            System.Console.WriteLine($"Error in reservation:{de.Message}");
        }
        catch (FormatException fe)
        {
            System.Console.WriteLine($"Error the imput:{fe.Message}");
        }
        catch(Exception e)
        {
            System.Console.WriteLine($"Error:{e.Message}");
        }
        /*
        System.Console.Write(":");
        System.Console.Write(":");
        System.Console.Write(":");
        System.Console.Write(":");
        System.Console.Write(":");
        System.Console.Write(":");
        System.Console.Write(":");
        System.Console.Write(":");
        System.Console.Write(":");
        System.Console.Write(":");
        System.Console.Write(":");
        System.Console.Write(":");
        */
    }
}
