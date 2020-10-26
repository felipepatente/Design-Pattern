namespace DesignPatterns.ChainOfResponsibility
{
    public class ImpostoSermValor : IImposto
    {
        public IImposto Proximo { get; set; }

        public double Calcular(double valor)
        {            
            return 0;            
        }
    }
}
