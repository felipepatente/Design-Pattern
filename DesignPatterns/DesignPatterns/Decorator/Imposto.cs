namespace DesignPatterns.Decorator
{
    public abstract class Imposto
    {
        public Imposto OutroImposto { get; set; }

        public Imposto(Imposto outroImposto)
        {
            OutroImposto = outroImposto;
        }

        public Imposto()
        {

        }

        public abstract double CalcularImposto(Orcamento orcamento);

        protected virtual double CalcularOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto == null) return 0;
            
            return OutroImposto.CalcularImposto(orcamento);
        }
    }
}
