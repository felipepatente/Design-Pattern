using System;

namespace DesignPatterns.FlyWeight
{
    public class TartarugaAzul : Tartaruga
    {
        public TartarugaAzul()
        {
            Cor = "Azul";
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
