using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercs8
{
    public class DataStudents
    {
        /*
            Quando um estudante deseja alugar um quarto, deve-se registrar o nome e email deste estudante.
        */
        public string Name { get; set; }
        public string Email { get; set; }
        
        public DataStudents(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Name}, {Email}";
        }
    }
}