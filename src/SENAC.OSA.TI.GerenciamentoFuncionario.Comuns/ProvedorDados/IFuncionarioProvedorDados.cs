using SENAC.OSA.TI.GerenciamentoFuncionario.Comuns.Modelos;
using System.Collections.Generic;

namespace SENAC.OSA.TI.GerenciamentoFuncionario.Comuns.ProvedorDados
{
    public interface IFuncionarioProvedorDados
    {
        IEnumerable<Funcionario> CarregaFuncionarios();
        void SalvaFuncionario(Funcionario funcionario);
        IEnumerable<Cargo> CarregaCargos();
    }
}
