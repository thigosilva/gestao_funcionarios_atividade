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
                new Funcionario(1, "Fulano de Tal", 1, false),
                new Funcionario(2, "Ciclano de Tal", 2, true),
                new Funcionario(3, "Beltrano de Tal", 3, true)
            }; 
        }

        public void AtualizaCargo(Cargo cargo)
        {
            throw new System.NotImplementedException();
        }

        public void AtualizaFuncionario(Funcionario funcionario)
        {
            throw new System.NotImplementedException();
        }

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
            return Funcionarios;
        }

        public void ExcluiCargo(Cargo cargo)
        {
            throw new System.NotImplementedException();
        }

        public void ExcluiFuncionario(Funcionario funcionario)
        {
            throw new System.NotImplementedException();
        }

        public Cargo RecuperaCargoPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public Funcionario RecuperaFuncionarioPorId(int id)
        {
            throw new System.NotImplementedException();
        }

        public void SalvaCargo(Cargo cargo)
        {
            throw new System.NotImplementedException();
        }

        public void SalvaFuncionario(Funcionario funcionario)
        {
            Debug.WriteLine($"Funcionário salvo: {funcionario.PrimeiroNome}");
        }
    }
}
