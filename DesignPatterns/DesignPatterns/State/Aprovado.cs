using System;

namespace DesignPatterns.State
{
    public class Aprovado : IEstadoOrcamento
    {
        public double AplicaDesconto(Orcamento orcamento)
        {
            return orcamento.Valor * 4;
        }

        public void EmProvacao(Orcamento orcamento)
        {
            Console.WriteLine("Não deu certo");
        }

        public void Finalizado(Orcamento orcamento)
        {
            orcamento.estado = new Finalizado();
        }

        void IEstadoOrcamento.Aprovado(Orcamento orcamento)
        {
            Console.WriteLine("Não deu certo");
        }
    }
}
