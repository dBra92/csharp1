using System.Collections.Generic;
using IComparabless.Entities;

namespace IComparabless;
class Program
{
    static void Main(string[] args)
    {
        string path = @"/home/dan92/Documentos/EstudoCsharp/testsFiles/file6.txt";

        try
        {
            using (StreamReader sr = File.OpenText(path))
            {
                List<Employee> strList = new List<Employee>();
                while (!sr.EndOfStream)
                {
                    strList.Add(new Employee(sr.ReadLine()));
                }
                strList.Sort();
                foreach (Employee employee in strList)
                {
                    Console.WriteLine(employee);
                }
            }
        }
        catch (IOException ioe)
        {
            Console.WriteLine("An error occurred");
            Console.WriteLine(ioe.Message);
        }
    }
}
