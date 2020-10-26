using System;

namespace DesignPatterns.FlyWeight
{
    public class TesteFlyWeight
    {
        public void Testando()
        {
            TartarugaFlyWeight tartarugaFly = new TartarugaFlyWeight();

            while (true)
            {                
                Console.Write("Digite uma cor: ");
                string cor = Console.ReadLine();

                Tartaruga tartaruga = tartarugaFly.GetTartaruga(cor);

                tartaruga.Mostrar();
            }
        }
    }
}
