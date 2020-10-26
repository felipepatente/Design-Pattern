namespace DesignPatterns.TemplateMethod
{
    public abstract class TemplateSQLGetDados
    {
        public string PegandoDadosClienteContas(string nomeProcedure, string MensagemException)
        {
            bool continua = true;

            while (continua)
            {
                try
                {
                    System.Console.WriteLine(nomeProcedure);
                    ExecutandoComandoSQL();
                    continua = false;
                }
                catch (System.Exception)
                {
                    System.Console.WriteLine(MensagemException);
                    throw;
                }
            }

            return "";
        }

        protected abstract void ExecutandoComandoSQL();
       
    }
}
