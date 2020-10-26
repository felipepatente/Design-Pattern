using System;

namespace DesignPatterns.Bridge
{
    public class TesteBridge
    {
        public void Testando()
        {
            Console.WriteLine("1 - Esporte");
            Console.WriteLine("1 - Filme");
            Console.WriteLine("1 - Documentario");
            Console.Write("Escolhe uma canal: ");
            int numeroCanal = Convert.ToInt32(Console.ReadLine());

            FabricaDeMetodo fabrica = new FabricaDeMetodo();

            SmartTV smart = new SmartTV(fabrica.GetCanal(numeroCanal));

            smart.AssistirCanal();
            smart.AssistirPrograma();

        }
    }
}
