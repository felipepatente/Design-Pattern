namespace DesignPatterns.FactoryMethod
{
    public class FabricaDeMetodos
    {
        public IPersonagem EscolherPersonagem(string personagem)
        {
            switch (personagem)
            {
                case "LiuKang":
                    return new LiuKang();
                case "Scorpion":
                    return new Scorpion();
                case "SubZero":
                    return new SubZero();
                default:
                    return null;
            }
        }
    }
}
