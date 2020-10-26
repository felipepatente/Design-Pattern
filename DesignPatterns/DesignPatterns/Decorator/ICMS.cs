namespace DesignPatterns.Decorator
{
    public class ICMS : Imposto
    {
        public ICMS(Imposto outroImposto) : base(outroImposto) { }
        public ICMS() : base() { }

        public override double CalcularImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.23 + CalcularOutroImposto(orcamento);
        }
    }
}
