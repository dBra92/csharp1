namespace Exercs8;
class Program
{
    static void Main(string[] args)
    {
        /*
            A dona de um pensionato possui dez quartos para alugar para estudantes, sendo esses quartos identificados pelos números 0 a 9.
            Fazer um programa que inicie com todos os dez quartos vazios, e depois
        */
        DataStudents[] ds = new DataStudents[10];

        /*
            leia uma quantidade N representando o número de estudantes que vão alugar quartos (N pode ser de 1 a 10).
        */
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Rent:#{i}");

            Console.Write("Name:");
            string name = Console.ReadLine();

            Console.Write("Email:");
            string email = Console.ReadLine();

            Console.Write("Room:");
            int room = int.Parse(Console.ReadLine());

            ds[room] = new DataStudents(name, email);
        }
        for (int i = 0; i < 10; i++)
        {
            if (ds[i] != null)
            {
                Console.WriteLine($"{i}: {ds[i]}");
            }
        }
    }
}
