using System;

namespace DesignPatterns.Adapter
{
    public class Aviao
    {
        public void Decolar()
        {
            Console.WriteLine("Avião decolando");
        }

        public void Voar()
        {
            Console.WriteLine("Avião voando");
        }
    }
}
