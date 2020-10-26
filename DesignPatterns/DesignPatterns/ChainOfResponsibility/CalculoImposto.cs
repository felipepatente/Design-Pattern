namespace DesignPatterns.ChainOfResponsibility
{
    public class CalculoImposto
    {
        private const double VALOR = 4;

        public double CalcularImpostos()
        {
            IImposto impostoSemValor = new ImpostoSermValor();
            IImposto impostoGPF = new ImpostoGPF(impostoSemValor);
            IImposto impostoDARF = new ImpostoDARF(impostoGPF);
            IImposto impostoICMS = new ImpostoICMS(impostoDARF);

            return impostoICMS.Calcular(VALOR);

        }
    }
}
