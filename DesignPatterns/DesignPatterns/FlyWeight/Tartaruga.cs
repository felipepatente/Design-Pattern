namespace DesignPatterns.FlyWeight
{
    public abstract class Tartaruga
    {
        protected string Cor { get; set; }
        protected double Tamanho { get; set; }
        protected double Peso { get; set; }

        public abstract void Mostrar();
    }
}
