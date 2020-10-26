namespace DesignPatterns.ChainOfResponsibility
{
    class ImpostoDARF : IImposto
    {
        private const double VALOR_IMPOSTO = 700;
        private const double PERCENTUAL = 0.3;

        public IImposto Proximo { get; set; }

        public ImpostoDARF(IImposto imposto)
        {
            Proximo = imposto;
        }

        public ImpostoDARF()
        {

        }

        public double Calcular(double valor)
        {
            if (valor > 5 && valor <= 10)
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
