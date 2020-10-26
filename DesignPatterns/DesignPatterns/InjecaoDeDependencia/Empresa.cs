namespace DesignPatterns.InjecaoDeDependencia
{
    public class Empresa: IObjetoEnderecoIJ
    {
        public int Codigo { get; set; }
        public string RazaoSocial { get; set; }

        public IObjetoEndereco EnderecoConstrutor { get; set; }

        //Injeção de dependência por propriedade
        private IObjetoEndereco _endereco;

        public IObjetoEndereco Endereco
        {
            get
            {
                return _endereco;
            }

            set
            {
                _endereco = value;
            }
        }

        //Injeção de dependência por interface
        public void setEndereco(IObjetoEndereco obj)
        {
            _endereco = obj;
        }

        //Injeção de dependência por construtor
        public Empresa(IObjetoEndereco objeto)
        {
            EnderecoConstrutor = objeto;
        }

        public Empresa()
        {
            //Injeção de dependência por Service Locator
            EnderecoConstrutor = Localizador.GetEndereco();
        }
    }
}
