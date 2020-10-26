namespace DesignPatterns.Proxy
{
    public class TesteProxy
    {
        public void Testando()
        {
            Proxy proxy = new Proxy();
            Pessoa pessoa = proxy.GetRequisicao();

            pessoa.Nome = "Felipe";
            pessoa.Peso = 80;
            pessoa.MostrandoDados();
        }
    }
}
