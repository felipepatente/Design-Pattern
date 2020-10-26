using System;

namespace DesignPatterns.Proxy
{
    public class Pessoa : Objeto
    {
        public string Nome { get; set; }
        public double Peso { get; set; }

        public override Pessoa GetRequisicao()
        {
            return this;
        }

        public void MostrandoDados()
        {
            Console.WriteLine($"Nome: {Nome}, Peso: {Peso}");
        }
    }
}
