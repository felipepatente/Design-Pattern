namespace DesignPatterns.ChainOfResponsibility
{
    public interface IImposto
    {
        double Calcular(double valor);
        
        IImposto Proximo { get; set; }
    }
}
