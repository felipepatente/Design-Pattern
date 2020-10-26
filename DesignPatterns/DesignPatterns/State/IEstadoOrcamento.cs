namespace DesignPatterns.State
{
    public interface IEstadoOrcamento
    {
        double AplicaDesconto(Orcamento orcamento);

        void EmProvacao(Orcamento orcamento);

        void Aprovado(Orcamento orcamento);

        void Finalizado(Orcamento orcamento);
    }
}
