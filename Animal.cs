using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POO;

namespace POO
{
    public abstract class Animal
    {
        public abstract void FazerSom();
    }


    public class Cachorro : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine("O cachorro late");
        }

    }
    public class Gato : Animal
    {
        public override void FazerSom()
        {
            Console.WriteLine("O gato mia");
        }

    }
}
