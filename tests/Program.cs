
using System.Globalization;
using System.Collections;


namespace tests;
class Program
{
    static void Main(string[] args)
    {

        // Cria e inicializa uma nova Stack.
        Stack minhaStack = new Stack();
        minhaStack.Push("Macoratti");
        minhaStack.Push(".net");
        minhaStack.Push(" 2022");
        // Exibe as propriedades e valores das  Stack.
        Console.WriteLine("minhaStack\n");
        Console.WriteLine($"\tQuantidade :\t {minhaStack.Count}");
        Console.Write("\tValores: ");
        foreach (Object obj in minhaStack)
        {
            Console.Write($"\t\n{obj}\n");
        }
    }
}

