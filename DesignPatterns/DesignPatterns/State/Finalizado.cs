using System;

namespace DesignPatterns.State
{
    public class Finalizado : IEstadoOrcamento
    {
        public double AplicaDesconto(Orcamento orcamento)
        {
            return orcamento.Valor * 2;
        }

        public void Aprovado(Orcamento orcamento)
        {
            Console.WriteLine("Não deu certo");
        }

        public void EmProvacao(Orcamento orcamento)
        {
            Console.WriteLine("Não deu certo");
        }

        void IEstadoOrcamento.Finalizado(Orcamento orcamento)
        {
            Console.WriteLine("Não deu certo");
        }
    }
}
