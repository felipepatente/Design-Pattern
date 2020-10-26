namespace DesignPatterns.State
{
    public class Orcamento
    {
        public double Valor { get; set; }
        public IEstadoOrcamento estado { get; set; }

        public double GetDesconto()
        {
            return estado.AplicaDesconto(this);
        }

        public Orcamento(double valor)
        {
            estado = new EmAprovacao();

            this.Valor = valor;
        }

        public void EmAprovacao()
        {
            estado.EmProvacao(this);
        }

        public void Aprovado()
        {
            estado.Aprovado(this);
        }

        public void Finalizado()
        {
            estado.Finalizado(this);
        }
    }
}
