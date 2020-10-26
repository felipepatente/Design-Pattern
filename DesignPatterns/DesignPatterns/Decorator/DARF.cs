namespace DesignPatterns.Decorator
{
    public class DARF : Imposto
    {
        public DARF(Imposto outroImposto) : base(outroImposto) { }
        public DARF() : base() { }

        public override double CalcularImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.36 + CalcularOutroImposto(orcamento);
        }
    }
}
