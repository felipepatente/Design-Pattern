using System;

namespace DesignPatterns.Adapter
{
    public class Pessoa : ILocomocao
    {
        public void Andar()
        {
            Console.WriteLine("Uma pessoa andando");
        }

        public void Correr()
        {
            Console.WriteLine("Uma pessoa correndo");
        }
    }
}
