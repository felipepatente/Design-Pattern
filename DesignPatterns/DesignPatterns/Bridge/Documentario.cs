namespace DesignPatterns.Bridge
{
    public class Documentario : ICanal
    {
        public string Canal()
        {
            return "Canal de Documentario";
        }

        public string Programa()
        {
            return "Programa O reino animal";
        }
    }
}
