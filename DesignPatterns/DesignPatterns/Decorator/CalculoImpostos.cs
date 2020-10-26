namespace DesignPatterns.Decorator
{
    public class CalculoImpostos : ICalculoImposto
    {
        public double GetResultadoCalculoImpostos()
        {
            Orcamento orcamento = new Orcamento()
            {
                Valor = 20
            };

            Imposto imposto = new ICMS(new GPF(new DARF()));
            double resultadoImposto = imposto.CalcularImposto(orcamento);

            return resultadoImposto;
        }
    }
}
