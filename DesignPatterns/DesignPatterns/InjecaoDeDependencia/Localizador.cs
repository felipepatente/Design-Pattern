namespace DesignPatterns.InjecaoDeDependencia
{
    public class Localizador
    {
        public static IObjetoEndereco GetEndereco()
        {
            return new EnderecoA();
        }
    }
}
