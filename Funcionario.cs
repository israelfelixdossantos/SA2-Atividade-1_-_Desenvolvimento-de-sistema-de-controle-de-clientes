using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public class Funcionario
    {
        public String Nome { get; set; }
        public Double Salario { get; set; }

    }

    public class Gerente : Funcionario
    {
        public String Setor { get; set;}
    }

}