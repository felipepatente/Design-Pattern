using System;

namespace DesignPatterns.FlyWeight
{
    public class TartarugaVermelha : Tartaruga
    {
        public TartarugaVermelha()
        {
            Cor = "Vermelha";
            Tamanho = 251;
            Peso = 14;

            Console.WriteLine($"Estanciando a Tartaruga {Cor}");
        }

        public override void Mostrar()
        {
            Console.WriteLine($"Cor: {Cor}, Tamanho: {Tamanho}, Peso: {Peso}");
        }
    }
}
