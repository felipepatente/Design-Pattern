namespace DesignPatterns.Bridge
{
    class Esporte : ICanal
    {
        public string Canal()
        {
            return "Canal de Esportes";
        }

        public string Programa()
        {
            return "Programa F1";
        }
    }
}
