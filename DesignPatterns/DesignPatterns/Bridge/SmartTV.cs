using System;

namespace DesignPatterns.Bridge
{
    public class SmartTV
    {
        private ICanal Canal = null;

        public SmartTV(ICanal canal)
        {
            Canal = canal;
        }

        public void AssistirCanal()
        {
            Console.WriteLine(Canal.Canal());
        }

        public void AssistirPrograma()
        {
            Console.WriteLine(Canal.Programa());
        }
    }
}
