namespace DesignPatterns.ChainOfResponsibility
{
    public class ImpostoGPF: IImposto
    {
        private const double VALOR_IMPOSTO = 854;
        private const double PERCENTUAL = 0.3;

        public IImposto Proximo { get; set; }

        public ImpostoGPF(IImposto imposto)
        {
            Proximo = imposto;
        }

        public ImpostoGPF()
        {

        }

        public double Calcular(double valor)
        {
            if (valor <= 5)
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
