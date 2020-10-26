namespace DesignPatterns.Bridge
{
    public class FabricaDeMetodo
    {
        public ICanal GetCanal(int numeroCanal)
        {
            switch (numeroCanal)
            {
                case 1:
                    return new Esporte();
                case 2:
                    return new Filme();
                case 3:
                    return new Documentario();
                default:
                    return null;
            }
        }
    }
}
