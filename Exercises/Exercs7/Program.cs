using System.Globalization;

namespace Exercs7
{
    public class Program
    {
        static void Main(string[] args)
        {
            UserAccount ua;
            Console.Write("Enter the number of account:");
            int account = int.Parse(Console.ReadLine());

            Console.Write("Holder account:");
            string holder = Console.ReadLine();

            Console.Write("There will be a initial deposit[y/n]:");
            char answer = char.Parse(Console.ReadLine());
            if (answer == 'y' || answer == 'Y')
            {
                Console.Write("Enter the value of initial deposity:");
                double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                ua = new UserAccount(account, holder, initialDeposit);
            }
            else
            {
                ua = new UserAccount(account, holder);
            }

            Console.WriteLine("");
            Console.WriteLine("Data of account:");
            Console.Write($"{ua}");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.Write("Enter a value to deposity:");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ua.Deposit(amount);
            
            Console.WriteLine("");
            Console.WriteLine("Data of account updated:");
            Console.Write($"{ua}");
            Console.WriteLine("");

            Console.WriteLine("");
            Console.Write("Enter a value to withdraw:");
            amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ua.Withdraw(amount);

            Console.WriteLine("");
            Console.Write("Data of account updated. Pt2:");
            Console.Write($"{ua}");
            Console.WriteLine("");
        }
    }
}