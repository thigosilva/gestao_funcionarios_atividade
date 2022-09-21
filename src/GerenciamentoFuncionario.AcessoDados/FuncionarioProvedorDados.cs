using GerenciamentoFuncionario.Comuns.Modelos;
using GerenciamentoFuncionario.Comuns.ProvedorDados;
using System.Collections.Generic;
using System.Diagnostics;

namespace GerenciamentoFuncionario.AcessoDados
{
    public class FuncionarioProvedorDados : IFuncionarioProvedorDados
    {
        private List<Funcionario> Funcionarios { get; set; }

        public FuncionarioProvedorDados()
        {
            Funcionarios = new List<Funcionario> {
                new Funcionario("Thiago Silva", 1, false),
                new Funcionario("Henrique Alexandre", 2, true),
                new Funcionario("Hudson Silva Alexandre", 3, true)
                new Funcionario("Marinele de Jesus", 4, true)
            };
        }

        public void AtualizaFuncionario(Funcionario funcionario)
        {
            //throw new System.NotImplementedException();
        }

        public void ExcluiFuncionario(Funcionario funcionario)
        {
            //throw new System.NotImplementedException();
        }

        public Funcionario RecuperaFuncionarioPorId(int id)
        {
            //throw new System.NotImplementedException();
        }

        public void SalvaFuncionario(Funcionario funcionario)
        {
            //Debug.WriteLine($"Funcionário salvo: {funcionario.PrimeiroNome}");
        }

        public IEnumerable<Funcionario> CarregaFuncionarios()
        {
            return Funcionarios;
        }
    }
}
