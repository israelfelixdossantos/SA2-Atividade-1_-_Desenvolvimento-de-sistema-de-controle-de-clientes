using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO
{
    public class Carro
    {
        public String Cor { get; set; }
        public String Modelo { get; set; }
        public void Acelerar() {
            Console.WriteLine("O Carro está acelerando");
        }
    }
}