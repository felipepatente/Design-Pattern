using System;

namespace DesignPatterns.State
{
    public class EmAprovacao : IEstadoOrcamento
    {
        public double AplicaDesconto(Orcamento orcamento)
        {
            return orcamento.Valor * 3;
        }

        public void Aprovado(Orcamento orcamento)
        {
            orcamento.estado = new Aprovado();
        }

        public void EmProvacao(Orcamento orcamento)
        {
            Console.WriteLine("Não deu certo");
        }

        public void Finalizado(Orcamento orcamento)
        {
            Console.WriteLine("Não deu certo");
        }
    }
}
