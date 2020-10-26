namespace DesignPatterns.Bridge
{
    class Filme : ICanal
    {
        public string Canal()
        {
            return "Canal de Filmes";
        }

        public string Programa()
        {
            return "Programa Os Vingadores";
        }
    }
}
