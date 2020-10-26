namespace DesignPatterns.InjecaoDeDependencia
{
    public class TesteInjecaoDeDependencia
    {
        public void Testar()
        {
            EnderecoA enderecoA = new EnderecoA();
            enderecoA.Rua = "Rua Endereço A";
            enderecoA.Numero = 1;

            EnderecoB enderecoB = new EnderecoB();
            enderecoB.Cidade = "São Paulo";
            enderecoB.UF = "SP";

        }
    }
}
