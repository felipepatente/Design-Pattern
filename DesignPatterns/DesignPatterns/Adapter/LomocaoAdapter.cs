namespace DesignPatterns.Adapter
{
    public class LomocaoAdapter : ILocomocao
    {
        private Aviao Aviao = null;
        public LomocaoAdapter(Aviao aviao)
        {
            Aviao = aviao;
        }

        public void Andar()
        {
            Aviao.Decolar();
        }

        public void Correr()
        {
            Aviao.Voar();
        }
    }
}
