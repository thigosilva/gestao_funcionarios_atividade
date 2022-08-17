using GerenciamentoFuncionario.AcessoDados;

namespace GerenciamentoFuncionario.Console
{
    class Program
    {
        static void Main()
        {
            var provedor = new FuncionarioProvedorDados();
            //var cargos = provedor.CarregaCargos();
            var funcionarios = provedor.CarregaFuncionarios();
            //System.Console.WriteLine("Hello World!");
        }
    }
}
