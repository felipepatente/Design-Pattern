namespace DesignPatterns.Proxy
{
    public class Proxy : Objeto
    {
        private Pessoa pessoa;

        public override Pessoa GetRequisicao()
        {
            if (pessoa == null)
                pessoa = new Pessoa();

            return pessoa;
        }
    }
}
