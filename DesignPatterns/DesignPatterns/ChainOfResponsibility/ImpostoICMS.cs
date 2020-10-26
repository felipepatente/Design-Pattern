namespace DesignPatterns.ChainOfResponsibility
{
    public class ImpostoICMS : IImposto
    {
        private const double VALOR_IMPOSTO = 700;
        private const double PERCENTUAL = 0.3;

        public IImposto Proximo { get; set; }

        public ImpostoICMS(IImposto imposto)
        {
            Proximo = imposto;
        }

        public ImpostoICMS()
        {

        }

        public double Calcular(double valor)
        {
            if (valor > 10 && valor <= 20)
            {
                return VALOR_IMPOSTO * PERCENTUAL * valor;
            }
            else
            {
                return Proximo.Calcular(valor);
            }
        }
    }
}
