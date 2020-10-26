using System;

namespace DesignPatterns.FlyWeight
{
    public class TartarugaAmarela : Tartaruga
    {
        public TartarugaAmarela()
        {           
            Cor = "Amarela";
            Tamanho = 16;
            Peso = 541;

            Console.WriteLine($"Estanciando a Tartaruga {Cor}");
        }

        public override void Mostrar()
        {
            Console.WriteLine($"Cor: {Cor}, Tamanho: {Tamanho}, Peso: {Peso}");
        }
    }
}
