using GerenciamentoFuncionario.Comuns.Modelos;
using GerenciamentoFuncionario.Comuns.ProvedorDados;
using System.Collections.Generic;
using System.Diagnostics;

namespace GerenciamentoFuncionario.AcessoDados
{
    public class FuncionarioProvedorDados : IFuncionarioProvedorDados
    {
        public IEnumerable<Cargo> CarregaCargos()
        {
            return new List<Cargo> {
                new Cargo(1, "Desenvolvedor"),
                new Cargo(2, "Engenheiro"),
                new Cargo(3, "Arquiteto"),
                new Cargo(4, "Gerente de Projetos")
            };
        }

        public IEnumerable<Funcionario> CarregaFuncionarios()
        {
            return new List<Funcionario> {
                new Funcionario(1, "Fulano de Tal", 1, false),
                new Funcionario(2, "Ciclano de Tal", 2, true),
                new Funcionario(3, "Beltrano de Tal", 3, true)
            };
        }

        public void SalvaFuncionario(Funcionario funcionario)
        {
            Debug.WriteLine($"Funcionário salvo: {funcionario.PrimeiroNome}");
        }
    }
}
