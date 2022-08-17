using GerenciamentoFuncionario.Comuns.Modelos;
using System.Collections.Generic;

namespace GerenciamentoFuncionario.Comuns.ProvedorDados
{
    public interface IFuncionarioProvedorDados
    {
        IEnumerable<Funcionario> CarregaFuncionarios();
        IEnumerable<Cargo> CarregaCargos();
        Cargo RecuperaCargoPorId(int id);
        Funcionario RecuperaFuncionarioPorId(int id);
        void SalvaFuncionario(Funcionario funcionario);
        void SalvaCargo(Cargo cargo);
        void AtualizaCargo(Cargo cargo);
        void AtualizaFuncionario(Funcionario funcionario);
        void ExcluiCargo(Cargo cargo);
        void ExcluiFuncionario(Funcionario funcionario);
    }
}
