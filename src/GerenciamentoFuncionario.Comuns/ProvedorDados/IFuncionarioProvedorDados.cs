using GerenciamentoFuncionario.Comuns.Modelos;
using System.Collections.Generic;

namespace GerenciamentoFuncionario.Comuns.ProvedorDados
{
    public interface IFuncionarioProvedorDados
    {
        IEnumerable<Funcionario> CarregaFuncionarios();
        void SalvaFuncionario(Funcionario funcionario);
        IEnumerable<Cargo> CarregaCargos();
    }
}
