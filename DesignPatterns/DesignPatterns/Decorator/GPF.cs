namespace DesignPatterns.Decorator
{
    public class GPF : Imposto
    {
        public GPF(Imposto outroImposto): base(outroImposto) { }
        public GPF() : base() { }

        public override double CalcularImposto(Orcamento orcamento)
        {
            return orcamento.Valor * 0.10 + CalcularOutroImposto(orcamento);
        }
    }
}
