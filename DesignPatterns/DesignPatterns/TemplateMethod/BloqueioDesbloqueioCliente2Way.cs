namespace DesignPatterns.TemplateMethod
{
    public class BloqueioDesbloqueioCliente2Way : TemplateSQLGetDados
    {
        protected override void ExecutandoComandoSQL()
        {
            System.Console.WriteLine("ExecutandoComandoSQL");
        }
    }
}
